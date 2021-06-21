using eRent.Data;
using eRent.Helpers;
using eRent.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.EF;
using travelAworld.Model;

namespace eRent.Services
{
    public class NekretninaService : INekretninaService
    {
        private readonly MyContext _context;

        public NekretninaService(MyContext context)
        {
            _context = context;
        }

        public async Task DodajDrzavu(string naziv)
        {
            await _context.Drzava.AddAsync(new Drzava { Naziv = naziv });
            await _context.SaveChangesAsync();
        }

        public async Task DodajGrad(string naziv, int drzavaId)
        {
            await _context.Grad.AddAsync(new Grad { Naziv = naziv, DrzavaId = drzavaId });
            await _context.SaveChangesAsync();
        }

        public async Task DodajKategoriju(string naziv, string opis)
        {
            await _context.KategorijaNekretnina.AddAsync(new KategorijaNekretnina { Naziv = naziv, Opis = opis });
            await _context.SaveChangesAsync();
        }

        //public async Task DodajLokaciju(string adresa, int gradId)
        //{
        //    await _context.Lokacija.AddAsync(new Lokacija { Adresa = adresa, GradId = gradId });
        //    await _context.SaveChangesAsync();
        //}

        public async Task DodajNekretninu(NekretninaToAddVM nekretnina)
        {
            var nekretninaToAdd = new Nekretnina
            {
                Sprat = nekretnina.Sprat,
                BrojEtaza = nekretnina.BrojEtaza,
                Cijena = (decimal)nekretnina.Cijena,
                GodinaIzgradnje = nekretnina.GodinaIzgradnje,
                Grijanje = nekretnina.Grijanje,
                KategorijaNekretninaId = nekretnina.KategorijaNekretnineId,
                Kvadratura = nekretnina.Kvadratura, 
                GradId = nekretnina.GradId,
                Adresa = nekretnina.Adresa,
                Naziv = nekretnina.Naziv,
                Opis = nekretnina.Opis,
                PosjedujeKlimu = nekretnina.PosjedujeKlimu,
                PosjedujeLift = nekretnina.PosjedujeLift,
                UkljuceneRezije = nekretnina.UkljuceneRezije
            };
            await _context.AddAsync(nekretninaToAdd);

            foreach (var slika in nekretnina.Slike)
            {
                _context.NekretninaSlike.Add(new NekretninaSlike { NekretninaId = nekretninaToAdd.NekretninaId, SlikaUrl = slika });
            }
            await _context.SaveChangesAsync();
        }

        public List<NekretninaToDisplayVM> GetNekretnina(NekretninaToSearchVM search)
        {
            var query = _context.Nekretnina.Include(x=>x.Grad).Include(x => x.KategorijaNekretnina).AsQueryable();

            if (search.GradId != 0 && search.GradId.HasValue)
            {
                query = query.Where(x => x.GradId == search.GradId);
            }

            if (search.KategorijaNekretnineId != 0 && search.KategorijaNekretnineId.HasValue)
            {
                query = query.Where(x => x.KategorijaNekretninaId == search.KategorijaNekretnineId);
            }

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if (search?.GodinaIzgradnje != null)
            {
                query = query.Where(x => x.GodinaIzgradnje == search.GodinaIzgradnje);
            }
            if (search?.Kvadratura != null)
            {
                query = query.Where(x => x.Kvadratura == search.Kvadratura);
            }
            if (search?.Cijena != null)
            {
                query = query.Where(x => x.Cijena <= search.Cijena);
            }
            if (search?.UserId != null)
            {
                query = query.Where(x => x.UserId == search.UserId);
            }

            /// TO DO GLEDATI DA DODAS +- 5kvadrata i godina za pretragu

            var list = query.Select(x=> new NekretninaToDisplayVM
            {
                BrojEtaza = x.BrojEtaza,
                Slike = _context.NekretninaSlike.Where(c => c.NekretninaId == x.NekretninaId).Select(c => c.SlikaUrl).ToList(),
                Sprat = x.Sprat,
                Cijena = x.Cijena,
                GodinaIzgradnje = x.GodinaIzgradnje,
                Grijanje = x.Grijanje,
                KategorijaNekretnina = x.KategorijaNekretnina.Naziv,
                Kvadratura = x.Kvadratura,
                Adresa = x.Adresa,
                Grad = x.Grad.Naziv,
                Naziv = x.Naziv,
                Opis = x.Opis,
                PosjedujeLift = x.PosjedujeLift,
                PosjedujeKlimu = x.PosjedujeKlimu,
                NekretninaId = x.NekretninaId,
                UkljuceneRezije = x.UkljuceneRezije,
            }).ToList();

            return list;
        }

        public NekretninaToDisplayVM GetNekretninaById(int nekretninaId)
        {
            var nekretnina = _context.Nekretnina.Include(x => x.Grad).Include(x => x.KategorijaNekretnina)
                .Where(x => x.NekretninaId == nekretninaId)
                .Select(x => new NekretninaToDisplayVM
                {
                    BrojEtaza = x.BrojEtaza,
                    Slike = _context.NekretninaSlike.Where(c=>c.NekretninaId == x.NekretninaId).Select(c=>c.SlikaUrl).ToList(),
                    Sprat = x.Sprat,
                    Cijena = x.Cijena,
                    GodinaIzgradnje = x.GodinaIzgradnje,
                    Grijanje = x.Grijanje,
                    KategorijaNekretnina = x.KategorijaNekretnina.Naziv,
                    Kvadratura = x.Kvadratura,
                    Adresa = x.Adresa,
                    Grad = x.Grad.Naziv,
                    Naziv = x.Naziv,
                    Opis = x.Opis,
                    PosjedujeLift = x.PosjedujeLift,
                    PosjedujeKlimu = x.PosjedujeKlimu,
                    NekretninaId = x.NekretninaId,
                    UkljuceneRezije = x.UkljuceneRezije
                })
                .FirstOrDefault();

            return nekretnina;

        }

        public List<Drzava> GetDrzava()
        {
            return _context.Drzava.ToList();
        }

        public List<Grad> GetGrad(int? drzavaId)
        {
            var gradovi = _context.Grad.Include(x => x.Drzava).AsQueryable();
            if(drzavaId != null)
            {
                gradovi = gradovi.Where(x => x.DrzavaId == drzavaId);
            }

            return gradovi.ToList();
        }

        public List<KategorijaToDisplayVM> GetKategorije()
        {
            return _context.KategorijaNekretnina.Select(x=> new KategorijaToDisplayVM {KategorijaId = x.KategorijaNekretninaId, Naziv = x.Naziv }).ToList();
        }

        //public Lokacija GetLokacijaById(int id)
        //{
        //    return _context.Lokacija.FirstOrDefault(x => x.LokacijaId == id);
        //}

        //public List<Lokacija> GetLokacije(int? gradId)
        //{
        //    var lokacije = _context.Lokacija.Include(x => x.Grad).ThenInclude(x=>x.Drzava).AsQueryable();
        //    if (gradId != null)
        //    {
        //        lokacije = lokacije.Where(x => x.GradId == gradId);
        //    }

        //    return lokacije.ToList();
        //}

        public Task<Nekretnina> TraziNekretninu(NekretninaToSearchVM queryParams)
        {
            throw new NotImplementedException();
        }

        public Task DodajLokaciju(string adresa, int gradId)
        {
            throw new NotImplementedException();
        }

        public void UpdateNekretnina(int nekretninaId, NekretninaToAddVM nekretninaToUpdate)
        {
            var nekretnina = _context.Nekretnina.Find(nekretninaId);
            nekretnina.Naziv = nekretninaToUpdate.Naziv;
            nekretnina.Opis = nekretninaToUpdate.Opis;
            nekretnina.Cijena = (decimal)nekretninaToUpdate.Cijena;
            nekretnina.Adresa = nekretninaToUpdate.Adresa;
            nekretnina.BrojEtaza = nekretninaToUpdate.BrojEtaza;
            nekretnina.GodinaIzgradnje = nekretninaToUpdate.GodinaIzgradnje;
            nekretnina.Grijanje = nekretninaToUpdate.Grijanje;
            nekretnina.PosjedujeKlimu = nekretninaToUpdate.PosjedujeKlimu;
            nekretnina.PosjedujeLift = nekretninaToUpdate.PosjedujeLift;
            nekretnina.UkljuceneRezije = nekretninaToUpdate.UkljuceneRezije;
            nekretnina.KategorijaNekretninaId = nekretninaToUpdate.KategorijaNekretnineId;
            nekretnina.GradId = nekretninaToUpdate.GradId;

            //foreach (var slika in ponudaToUpdate.Slike)
            //{
            //    PonudaSlike ps = new PonudaSlike { PonudaId = ponudaId, SlikaUrl = slika };
            //    _context.PonudaSlike.Add(ps);
            //}

            _context.SaveChanges();
        }

        public void PonudaUserAdd(PonudaUserAdd ponudaUser)
        {
            var ponuda = new Rezervacija
            {
                NekretninaId = ponudaUser.PonudaId,
                UserId = ponudaUser.UserId,
                DatumKreiranjaRezervacije = DateTime.Now,
                DatumObilaska = DateTime.Now,
                Status = "AKTIVNO",
                DatumPrijave = ponudaUser.DatumPrijave,
                VrijemePrijave = ponudaUser.VrijemePrijave,
                VrijemeOdjave = ponudaUser.VrijemeOdjave
            };
            _context.Rezervacija.Add(ponuda);
            _context.SaveChanges();

        }

        string generisiBoju(string status)
        {
            string boja;
            switch(status)
            {
                case "ODBIJENO": boja = "red"; break;
                case "PRIHVACENO": boja = "green"; break;
                case "OTKAZANO": boja = "IndianRed"; break;
                default: boja = "white"; break;
            }
            return boja;
        }

        public List<NekretninaToDisplayVM> GetRezervisaneNekretnine(int userId = 0)
        {
            List<NekretninaToDisplayVM> nekretnine = new List<NekretninaToDisplayVM>();

            if (userId != 0)
            {
                nekretnine = _context.Rezervacija.Include(x => x.Nekretnina).Where(x => x.UserId == userId).Select(x => new NekretninaToDisplayVM
                {
                    NekretninaId = x.NekretninaId,
                    Naziv = x.Nekretnina.Naziv,
                    Slike = _context.NekretninaSlike.Where(c=>c.NekretninaId == x.NekretninaId).Select(c=>c.SlikaUrl).ToList(),
                    Ocjena = _context.Ocjena.Where(c=>c.NekretninaId == x.NekretninaId).Select(c=>c.Vrijednost).FirstOrDefault(),
                    RezervacijaId = x.RezervacijaId,
                    Status = x.Status,
                    Boja = generisiBoju(x.Status)
                }).ToList();
            }
            
            return nekretnine;
        }

        public void Ocijeni(OcjeniPonuduVM ocjena)
        {
            _context.Add(new Ocjena
            {
                Datum = DateTime.Now,
                NekretninaId = ocjena.NekretninaId,
                UserId = ocjena.KorisnikId,
                Vrijednost = ocjena.Ocjena
            });
            _context.SaveChanges();
        }

        public void OtkaziRezervaciju(int rezervacijaId)
        {
            var rezervacija = _context.Rezervacija.FirstOrDefault(x => x.RezervacijaId == rezervacijaId);
            if(rezervacija != null)
            {
                if(rezervacija.Status != "PRIHVACENO")
                {
                    rezervacija.Status = "OTKAZANO";
                    _context.SaveChanges();
                }
            }
        }

        public List<NekretninaToDisplayVM> Preporuke(int myId)
        {
            //var movies = _db.Movies.Where(p => p.Genres.Any(x => listOfGenres.Contains(x));
            var preporuke = new List<NekretninaToDisplayVM>();

            var mojeRezervisaneNekretnineId = _context.Ocjena.Where(x => x.UserId == myId).Where(x => x.Vrijednost >= 8).Select(x=>x.NekretninaId).ToList();
            var sveNekretnineId = _context.Nekretnina.Include(x => x.Grad).Include(x => x.KategorijaNekretnina).ToList();

            foreach (var item in sveNekretnineId)
            {
                foreach(var mojeRezervacije in mojeRezervisaneNekretnineId)
                {
                    if(item.NekretninaId == mojeRezervacije)
                    {
                        preporuke.Add(new NekretninaToDisplayVM
                        {
                            BrojEtaza = item.BrojEtaza,
                            Slike = _context.NekretninaSlike.Where(c => c.NekretninaId == item.NekretninaId).Select(c => c.SlikaUrl).ToList(),
                            Sprat = item.Sprat,
                            Cijena = item.Cijena,
                            GodinaIzgradnje = item.GodinaIzgradnje,
                            Grijanje = item.Grijanje,
                            KategorijaNekretnina = item.KategorijaNekretnina.Naziv,
                            Kvadratura = item.Kvadratura,
                            Adresa = item.Adresa,
                            Grad = item.Grad.Naziv,
                            Naziv = item.Naziv,
                            Opis = item.Opis,
                            PosjedujeLift = item.PosjedujeLift,
                            PosjedujeKlimu = item.PosjedujeKlimu,
                            NekretninaId = item.NekretninaId,
                            UkljuceneRezije = item.UkljuceneRezije,
                        });
                    }
                }
            }

            return preporuke;
            

            //get stanove iz istog grada, stanovi koje je vec rentao i imaju ocjenu vecu od 8
        }

        public List<RezervacijaZahtjevVM> ZahtjeviRezervacije()
        {
            var rezervacije = _context.Rezervacija.Include(x => x.Nekretnina).ThenInclude(x => x.Grad).Include(x => x.User).Where(x=>x.Status == "AKTIVNO").Select(x => new RezervacijaZahtjevVM
            {
                Slike = _context.NekretninaSlike.Where(c => c.NekretninaId == x.NekretninaId).Select(c => c.SlikaUrl).ToList(),
                Sprat = x.Nekretnina.Sprat,
                Adresa = x.Nekretnina.Adresa + ", "+x.Nekretnina.Grad.Naziv,
                Status = x.Status,
                Grad = x.Nekretnina.Grad.Naziv,
                Naziv = x.Nekretnina.Naziv,
                DatumRezervacije = x.DatumPrijave,
                KorisnikIznajmio = x.User.Ime + " " + x.User.Prezime,
                NekretninaId = x.NekretninaId,
                RezervacijaId = x.RezervacijaId,
                Cijena = x.Nekretnina.Cijena,
                KlijentId = x.UserId,
                CheckIn = x.VrijemePrijave,
                CheckOut = x.VrijemeOdjave
            }).ToList();

            return rezervacije;
        }

        public void NapraviUgovor(RezervacijaZahtjevVM rezervacija, int korisnikId)
        {
            var updateRezervacija = _context.Rezervacija.FirstOrDefault(x => x.RezervacijaId == rezervacija.RezervacijaId);

            if (rezervacija.Status == "ODBIJENO")
            {
                updateRezervacija.Status = "ODBIJENO";
                _context.SaveChanges();

                return;
            }

            Ugovor ugovor = new Ugovor
            {
                Cijena = rezervacija.Cijena,
                KlijentId = rezervacija.KlijentId,
                KorisnikId = korisnikId,
                NekretninaId = rezervacija.NekretninaId,
                PocetakKoristenja = rezervacija.DatumRezervacije,
                KrajKoristenja = rezervacija.DatumRezervacije.AddDays(1)
            };
            _context.Add(ugovor);

            string userEmail = _context.Users.Where(x => x.Id == rezervacija.KlijentId).Select(x => x.Email).FirstOrDefault();
            if(userEmail != null) 
                Email.SendEmail(new Email.EmailParameters(userEmail, rezervacija.EmailSadrzaj));

            updateRezervacija.Status = "PRIHVACENO";
            _context.SaveChanges();

        }

        public StatistikaVM Statistika()
        {
            var putovanja = from rezervacija in _context.Rezervacija group rezervacija by rezervacija.RezervacijaId into g select new { PonudaId = g.Key, Count = g.Count(), naziv = g.Select(x => x.Nekretnina.Naziv) };

            putovanja = putovanja.OrderByDescending(x => x.Count).Take(3);

            List<Model.TopThree> top3 = new List<Model.TopThree>();
            foreach (var item in putovanja)
            {
                top3.Add(new Model.TopThree { NazivNekretnine = item.naziv.FirstOrDefault(), UkupnoRentano = item.Count });
            }

            var statistika = new StatistikaVM
            {
                BrojKorisnika = _context.Users.Count(),
                TrenutnoIzdatihStanova = _context.Rezervacija.Where(x => x.DatumPrijave.Date == DateTime.Now).Count(),
                UkupnoIzdatihStanova = _context.Rezervacija.Count(),
                UkupnoZakljucenihUgovora = _context.Ugovor.Count(),
                Top3 = top3
            };
            return statistika;
        }

        public void PrebaciOglase(PrebaciOglasVM oglas)
        {
            var oglasEdit = _context.Nekretnina.FirstOrDefault(x => x.NekretninaId == oglas.OglasId);
            oglasEdit.UserId = oglas.UserId;
            _context.SaveChanges();
        }
    }
}
