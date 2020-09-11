using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using travelAworld.Model;
using travelAworld.Services;

namespace travelAworld.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PonudaController : ControllerBase
    {
        private readonly IPonudaService _ponudaService;

        public PonudaController(IPonudaService ponudaService)
        {
            _ponudaService = ponudaService;
        }

        //[AllowAnonymous]
        [HttpPost("dodajponudu")]
        public IActionResult DodajPonudu(PonudaToAdd novaPonuda)
        {
            var ponuda = _ponudaService.DodajPonudu(novaPonuda);

            return Ok(ponuda);
        }

        //[AllowAnonymous]
        [HttpGet("getvodici")]
        public IActionResult GetVodici()
        {
            return Ok(_ponudaService.GetVodici());
        }

        //[AllowAnonymous]
        [HttpGet("getlokacija")]
        public IActionResult GetLokacija()
        {
            return Ok(_ponudaService.GetLokacija());
        }

        //[AllowAnonymous]
        [HttpPost("dodajlokaciju")]
        public IActionResult Dodajlokaciju(LokacijaToAdd lokacijaToAdd)
        {
            return Ok(_ponudaService.DodajLokaciju(lokacijaToAdd));
        }

        //[AllowAnonymous]
        [HttpPut("updateponuda/{id}")]
        public IActionResult UpdatePonuda(int id, PonudaToAdd ponudaToUpdate)
        {
            _ponudaService.UpdatePonuda(id, ponudaToUpdate);

            return Ok();
        }

        //[AllowAnonymous]
        [HttpGet("getponude")]
        public IActionResult GetPonude([FromQuery] PonudaToSearch queryParams)
        {
            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(_ponudaService.GetPonuda(queryParams, userid));
        }

        //[AllowAnonymous]
        [HttpGet("getponuda/{id}")]
        public IActionResult GetPonudaById(int id)
        {
            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(_ponudaService.GetPonudaById(id, userid));
        }

        //[AllowAnonymous]
        [HttpGet("getdrzave")]
        public IActionResult GetDrzave()
        {
            return Ok(_ponudaService.GetDrzave());
        }

        //[AllowAnonymous]
        [HttpPost("ponudauser")]
        public IActionResult PonudaUser(PonudaUserAdd ponudaUser)
        {
            _ponudaService.PonudaUserAdd(ponudaUser);
            return Ok();
        }

        //[AllowAnonymous]
        [HttpGet("getponudeusers")]
        public IActionResult GetPonudeUsers([FromQuery]PonudaUserToSearch queryParams)
        {
            return Ok(_ponudaService.GetPonudaUsers(queryParams));
        }

        [HttpPost("dodajobavijest")]
        public IActionResult DodajObavijest(ObavijestAdd obavijest)
        {
            var token = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _ponudaService.DodajObavijest(obavijest, token);
            return Ok();
        }

        //[AllowAnonymous]
        [HttpGet("getobavijesti")]
        public IActionResult GetObavijesti([FromQuery]ObavijestToSearch queryParams)
        {
            queryParams.UserId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            //queryParams.UserId = 51;

            return Ok(_ponudaService.GetObavijest(queryParams));
        }

        //[AllowAnonymous]
        [HttpGet("GetAktivnaPutovanja")]
        public IActionResult GetAktivnaPutovanja([FromQuery] AktivnaPutovanjaPretraga query)
        {
            return Ok(_ponudaService.GetAktivnaPutovanja(query.userId, query.vodicId));
        }

        [HttpGet("zabiljeziPosjetu/{id}")]
        public IActionResult ZabiljeziPosjetu(int id)
        {
            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _ponudaService.ZabiljeziPosjetu(id, userid);
            return Ok();
        }

        //[AllowAnonymous]
        [HttpGet("preporuke")]
        public IActionResult Preporuke()
        {
            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(_ponudaService.GetPreporuke(userid));
        }

        [AllowAnonymous]
        [HttpGet("popularnaputovanja")]
        public IActionResult PopularnaPutovanja()
        {
            return Ok(_ponudaService.PopularnaPutovanja());
        }

        [AllowAnonymous]
        [HttpPost("otkaziRezervaciju")]
        public IActionResult OtkaziRezervaciju(OtkaziRezervaciju rez)
        {
            _ponudaService.OtkaziRezervaciju(rez.RezervacijaId);
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("otkaziPonudu")]
        public IActionResult OtkaziPonudu(OtkaziPonudu ponuda)
        {
            _ponudaService.OtkaziPonudu(ponuda.Id);
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("getdisputeid/{id}")]
        public IActionResult GetDisputeId(int id)
        {
            return Ok(_ponudaService.GetDisputeInfo(id));
        }

        [AllowAnonymous]
        [HttpPut("DisputeUpdate/{id}")]
        public IActionResult DisputeUpdate(int id, DisputeToDisplay disputeToDisplay)
        {
            //disputeToDisplay.IznosPovrata = 120;
            _ponudaService.DisputeUpdate(id, disputeToDisplay);
            return Ok();
        }

    }
}