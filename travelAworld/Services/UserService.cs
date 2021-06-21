using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.EF;
using Microsoft.EntityFrameworkCore;
using travelAworld.Model;

namespace travelAworld.Services
{
    public class UserService : IUserService
    {
        private readonly MyContext _context;

        public UserService(MyContext context)
        {
            _context = context;
        }

        public bool CanDeleteUser(int userId)
        {
            var userNekretnina = _context.Nekretnina.Where(x => x.UserId == userId).ToList();
            if (userNekretnina.Count() != 0)
            {
                return false;
            }
            var admin = _context.Users.FirstOrDefault(x => x.UserName.ToLower() == "admin");
            if(admin == null)
            {
                var uid = _context.UserRoles.Include(x => x.User).Where(x => x.Role.Name == "Uposlenik" && x.UserId!=userId).Select(x=>x.UserId).FirstOrDefault();
                admin = _context.Users.FirstOrDefault(x=>x.Id == uid);
            }
            if(admin == null)
            {
                return false;
            }
            var ugovori = _context.Ugovor.Where(x => x.KorisnikId == userId).ToList();
            foreach(var u in ugovori)
            {
                u.KorisnikId = admin.Id;
            }
            _context.SaveChanges();
            return true;
        }

        

        public List<RoleToDisplay> GetRoles(int userId = 0)
        {
            if(userId == 0)
            {
                var roles = _context.Roles
                .Select(x => new RoleToDisplay
                {
                    RoleId = x.Id,
                    RoleName = x.Name
                })
                .ToList();

                return roles;
            }
            else
            {
                var roles = _context.UserRoles.Include(x => x.Role).Where(x => x.UserId == userId).Select(x=> new RoleToDisplay
                {
                    RoleId = x.RoleId,
                    RoleName = x.Role.Name
                }).ToList();

                return roles;
            }
            
        }

        public UsertoDisplay GetUserById(int id)
        {
            var user = _context.Users.Where(x => x.Id == id).Select(x => new UsertoDisplay
            {
                Id = x.Id,
                Username = x.UserName,
                Role = _context.UserRoles.Include(c=>c.Role).Where(c=>c.UserId==id).Select(c=>c.Role.Name).FirstOrDefault(),
                Ime = x.Ime,
                Prezime = x.Prezime,
                Adresa = x.Adresa,
                Email = x.Email,
                DatumRodjenja = x.DatumRodjenja
            }).FirstOrDefault();

            return user;
        }

        public async Task UpdateRole(int userId, string roleName)
        {
            var roleId = _context.Roles.Where(x => x.Name == roleName).Select(x=>x.Id).FirstOrDefault();


            var userRoles = _context.UserRoles.Where(x => x.UserId == userId).FirstOrDefault();

            userRoles.RoleId = roleId;

            await _context.SaveChangesAsync();
        }

        PageResult<UsertoDisplay> IUserService.Get(UserToSearch queryParams)
        {
            var query = _context.Users.Select(x => new UsertoDisplay
            {
                Id = x.Id,
                Username = x.UserName,
                //Roles = _context.UserRoles.Include(c=>c.Role).Where(c=>c.UserId == x.Id).Select(c=>c.Role).ToList(),
                Ime = x.Ime,
                Prezime = x.Prezime,
                Adresa = x.Adresa,
                Email = x.Email,
                DatumRodjenja = x.DatumRodjenja,
                ProfilePic = x.Slika,
                Role = _context.UserRoles.Include(c => c.Role).Where(c => c.UserId == x.Id).Select(c => c.Role.Name).FirstOrDefault()
            }).AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryParams.Role))
            {
                if(queryParams.Role == "Bilo koja")
                {
                    query = query.Where(x => x.Role == "Administrator" || x.Role == "Agent" || x.Role == "Vodić");
                }
                else
                {
                    query = query.Where(x => x.Role == queryParams.Role);
                }
            }

            if (!string.IsNullOrWhiteSpace(queryParams.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(queryParams.Ime));
            }
            if(!string.IsNullOrWhiteSpace(queryParams.Prezime))
            {
                query = query.Where(x=>x.Prezime.StartsWith(queryParams.Prezime));
            }

            var users = query.ToList();

            var result = new PageResult<UsertoDisplay>
            {
                Count = users.Count,
                PageIndex = queryParams.PageNumber,
                PageSize = queryParams.PageSize,
                Items = users.Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
              .Take(queryParams.PageSize)
              .ToList()
            };

            return result;
        }

    }
}
