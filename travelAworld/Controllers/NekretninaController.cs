using eRent.Data;
using eRent.Helpers;
using eRent.Model;
using eRent.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using travelAworld.EF;
using travelAworld.Model;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NekretninaController : ControllerBase
    {
        private readonly INekretninaService _nekretninaService;

        public NekretninaController(INekretninaService nekretninaService)
        {
            _nekretninaService = nekretninaService;
        }

        [HttpPost("nova")]
        public async Task<IActionResult> NovaNekretninaAsync(NekretninaToAddVM nekretninaToAdd)
        {
            await _nekretninaService.DodajNekretninu(nekretninaToAdd);
            return Ok();
        }

        [HttpPut("updatenekretnina/{id}")]
        public IActionResult UpdatePonuda(int id, NekretninaToAddVM nekretninaToUpdate)
        {
            _nekretninaService.UpdateNekretnina(id, nekretninaToUpdate);

            return Ok();
        }


        [HttpGet("GetNekretnina")]
        public List<NekretninaToDisplayVM> GetNekretnina([FromQuery]NekretninaToSearchVM search)
        {
            return _nekretninaService.GetNekretnina(search);
        }

        [HttpGet("GetNekretninaById/{id}")]
        public ActionResult<NekretninaToDisplayVM> GetNekretninaById(int id)
        {
            var nekretnina = _nekretninaService.GetNekretninaById(id);
            if(nekretnina == null)
            {
                throw new Exception("Nepostojeci ID");
            }
            return nekretnina;
        }

        [HttpPost("DodajDrzavu")]
        public async Task<IActionResult> DodajDrzavu(string naziv)
        {
            await _nekretninaService.DodajDrzavu(naziv);
            return Ok();
        }

        [HttpPost("DodajGrad")]
        public async Task<IActionResult> DodajGrad(string naziv, int drzavaId)
        {
            await _nekretninaService.DodajGrad(naziv, drzavaId);
            return Ok();
        }

        [HttpPost("DodajLokaciju")]
        public async Task<IActionResult> DodajLokaciju(string adresa, int gradId)
        {
            await _nekretninaService.DodajLokaciju(adresa, gradId);
            return Ok();
        }

        [HttpGet("GetDrzave")]
        public List<Drzava> GetDrzave()
        {
            return _nekretninaService.GetDrzava();
        }

        [HttpGet("GetGrad")]
        public List<Grad> GetGrad(int? drzavaId)
        {
            return _nekretninaService.GetGrad(drzavaId);
        }

        [HttpPost("DodajKategoriju")]
        public async Task<IActionResult> DodajKategorijuAsync(string naziv, string opis)
        {
            await _nekretninaService.DodajKategoriju(naziv, opis);
            return Ok();
        }

        [HttpGet("GetKategorije")]
        public List<KategorijaToDisplayVM> GetKategorije()
        {
            return _nekretninaService.GetKategorije();
        }

        [HttpPost("ponudauser")]
        public IActionResult PonudaUser(PonudaUserAdd ponudaUser)
        {
            _nekretninaService.PonudaUserAdd(ponudaUser);
            return Ok();
        }

        [HttpGet("GetRezervisaneNekretnine")]
        public IActionResult GetRezervisaneNekretnine(int userId)
        {
            return Ok(_nekretninaService.GetRezervisaneNekretnine(userId));
        }

        [Authorize]
        [HttpPost("ocijeni")]
        public IActionResult Ocijeni(OcjeniPonuduVM ocjena)
        {
            ocjena.KorisnikId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _nekretninaService.Ocijeni(ocjena);
            return Ok();
        }

        [HttpPost("otkazi")]
        public IActionResult Otkazi([FromBody]int id)
        {
            _nekretninaService.OtkaziRezervaciju(id);
            return Ok();
        }

        [HttpGet("preporuke")]
        public List<NekretninaToDisplayVM> PreporukeNekretnine()
        {
            var result = _nekretninaService.Preporuke(Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));
            return result;
        }

        [HttpGet("zahtjeviRezervacije")]
        public List<RezervacijaZahtjevVM> ZahtjeviRezervacije()
        {
            var result = _nekretninaService.ZahtjeviRezervacije();
            return result;
        }

        [Authorize]
        [HttpPost("napraviUgovor")]
        public IActionResult NapraviUgovor(RezervacijaZahtjevVM rezervacija)
        {
            _nekretninaService.NapraviUgovor(rezervacija, Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));
            return Ok();
        }
        
        [HttpGet("statistika")]
        public IActionResult Statistika()
        {
            return Ok(_nekretninaService.Statistika());
        }

        [HttpPost("prebaciOglas")]
        public IActionResult PrebaciOglas(PrebaciOglasVM oglas)
        {
            _nekretninaService.PrebaciOglase(oglas);
            return Ok();
        }

    }
}
