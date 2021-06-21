using eRent.Data;
using eRent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Model;

namespace eRent.Services
{
    public interface INekretninaService
    {
        Task DodajNekretninu(NekretninaToAddVM nekretninaToAdd);
        Task<Nekretnina> TraziNekretninu(NekretninaToSearchVM queryParams);
        Task DodajDrzavu(string naziv);
        Task DodajGrad(string naziv, int drzavaId);
        Task DodajLokaciju(string adresa, int gradId);
        Task DodajKategoriju(string naziv, string opis);
        List<KategorijaToDisplayVM> GetKategorije();
        List<NekretninaToDisplayVM> GetNekretnina(NekretninaToSearchVM search);
        NekretninaToDisplayVM GetNekretninaById(int nekretninaId);
        List<Drzava> GetDrzava();
        List<Grad> GetGrad(int? drzavaId);
        void UpdateNekretnina(int nekretninaId, NekretninaToAddVM nekretninaToUpdate);
        void PonudaUserAdd(PonudaUserAdd ponudaUser);
        List<NekretninaToDisplayVM> GetRezervisaneNekretnine(int userId = 0);
        void Ocijeni(OcjeniPonuduVM ocjena);
        void OtkaziRezervaciju(int rezervacijaId);
        List<NekretninaToDisplayVM> Preporuke(int myId);
        List<RezervacijaZahtjevVM> ZahtjeviRezervacije();
        void NapraviUgovor(RezervacijaZahtjevVM rezervacija, int userid);
        StatistikaVM Statistika();
        void PrebaciOglase(PrebaciOglasVM oglas);
        //List<Lokacija> GetLokacije(int? gradId);
        //Lokacija GetLokacijaById(int id);
    }
}
