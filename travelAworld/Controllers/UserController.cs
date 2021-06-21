using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using eRent.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using travelAworld.Data;
using travelAworld.Model;
using travelAworld.Services;

namespace travelAworld.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(IConfiguration config, IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager)
        {
            _config = config;
            _userService = userService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserToRegister userToRegister)
        {

            // Copy data from RegisterViewModel to IdentityUser
            var user = new User
            {
                Ime = userToRegister.Ime,
                Prezime = userToRegister.Prezime,
                UserName = userToRegister.Username.ToLower(),
                Email = userToRegister.Email,
                Adresa = userToRegister.Email,
                DatumRodjenja = userToRegister.Dob,
                Slika = userToRegister.Picture,
                PhoneNumber = userToRegister.Telefon
            };
            // Store user data in AspNetUsers database table
            var result = await _userManager.CreateAsync(user, userToRegister.Password);

            //_userManager.AddToRoleAsync(user, "Member").Wait();
            _userManager.AddToRoleAsync(user, userToRegister.Role).Wait();

            var createdUser = new UsertoDisplay
            {
                Id = user.Id,
                Username = user.UserName,
                Ime = user.Ime,
                Prezime = user.Prezime,
                Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault(),
                ProfilePic = user.Slika
            };


            return Ok(createdUser);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserToLogin userToLogin)
        {
            var user = await _userManager.FindByNameAsync(userToLogin.Username);

            if(user == null)
            {
                return Ok(new
                {
                    token = "error"
                });
            }

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, userToLogin.Password, false);

            if (result.Succeeded)
            {
                var appUser = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.NormalizedUserName == userToLogin.Username.ToUpper());

                var userToReturn = new UsertoDisplay
                {
                    Id = user.Id,
                    Ime = user.Ime,
                    Prezime = user.Prezime,
                    Username = user.UserName,
                    Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault(),
                    ProfilePic = user.Slika
                };

                return Ok(new
                {
                    token = GenerateJwtToken(appUser).Result,
                    user = userToReturn
                });
            }
            return Ok(new
            {
                token = "error"
            });
        }

        private async Task<string> GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult GetUsers([FromQuery] UserToSearch queryParams)
        {
            var users = _userService.Get(queryParams);

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUserById(id);

            return Ok(user);
        }


        [AllowAnonymous]
        [HttpGet("GetRoles")]
        public IActionResult GetRoles([FromQuery] int userid = 0)
        {
            var result = _userService.GetRoles(userid);

            return Ok(result);
        }

        //[AllowAnonymous]
        [HttpPut("edituser/{id}")]
        public async Task<IActionResult> EditUser(int id, UserToEdit data)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            //await _userService.UpdateRole(id, data.Role);


            user.Adresa = data.Adresa != null ? data.Adresa : user.Adresa;
            user.DatumRodjenja = data.Dob != null ? data.Dob : user.DatumRodjenja;
            user.Email = data.Email != null ? data.Email : user.Email;
            user.Ime = data.Ime != null ? data.Ime : user.Ime;
            user.Prezime = data.Prezime != null ? data.Prezime : user.Prezime;
            user.UserName = data.Username != null ? data.Username : user.UserName;
            user.Slika = data.Picture != null ? data.Picture : user.Slika;

            var result = await _userManager.UpdateAsync(user);

            var oldRole = _userService.GetRoles(id);
            IdentityResult deletionResult = await _userManager.RemoveFromRoleAsync(user, oldRole[0].RoleName);
            _userManager.AddToRoleAsync(user, data.Role).Wait();

            //if (data.Role != null)
            //{
            //await _userService.UpdateRole(id, data.Role);
            //}



            return Ok();
        }
        [AllowAnonymous]
        [HttpPost("deleteUser")]
        public async Task<bool> DeleteUserAsync([FromBody]int id)
        {
            if (!_userService.CanDeleteUser(id))
            {
                return false;
            }
            else
            {
                var user = await _userManager.FindByIdAsync(id.ToString());
                await _userManager.DeleteAsync(user);
            }

            return true;
        }
        [AllowAnonymous]
        [HttpPost("sendEmail")]
        public void SendEmail(string to, string content)
        {
            Email.SendEmail(new Email.EmailParameters(to, content));
        }
    }
}