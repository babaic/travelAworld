using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;
using travelAworld.EF;
using travelAworld.Model;

namespace travelAworld.Services
{
    public class PonudaService : IPonudaService
    {
        private readonly MyContext _context;

        public PonudaService(MyContext context)
        {
            _context = context;
        }

        public Lokacija DodajLokaciju(LokacijaToAdd lokacijaToAdd)
        {
            var drzava = _context.Drzava.Where(x => x.Naziv == lokacijaToAdd.Drzava).FirstOrDefault();

            Lokacija novaLokacija = new Lokacija();

            if (drzava != null)
            {
                novaLokacija.DrzavaId = drzava.Id;
            }
            else
            {
                Drzava novaDrzava = new Drzava
                {
                    Naziv = lokacijaToAdd.Drzava
                };
                _context.Drzava.Add(novaDrzava);
                novaLokacija.DrzavaId = novaDrzava.Id;
            }
            novaLokacija.Naziv = lokacijaToAdd.Mjesto;
            _context.Lokacija.Add(novaLokacija);

            _context.SaveChanges();

            return novaLokacija;

        }

        public void DodajObavijest(ObavijestAdd obavijest, int objavioId)
        {
            var obavijestAdd = new Obavijesti
            {
                UserId = objavioId,
                PonudaId = obavijest.PonudaId,
                Tekst = obavijest.Tekst,
                Type = obavijest.Type
            };
            _context.Obavijesti.Add(obavijestAdd);
            _context.SaveChanges();
        }

        public Ponuda DodajPonudu(PonudaToAdd novaPonuda)
        {
            var ponuda = new Ponuda
            {
                Cijena = novaPonuda.Cijena,
                CijenaIskljuceno = novaPonuda.CijenaIskljuceno,
                CijenaUkljuceno = novaPonuda.CijenaUkljuceno,
                DatumPolaska = novaPonuda.DatumPolaska,
                DatumPovratka = novaPonuda.DatumPovratka,
                Hotel = novaPonuda.Hotel,
                LokacijaId = novaPonuda.LokacijaId,
                Napomena = novaPonuda.Napomena,
                Naslov = novaPonuda.Naslov,
                Opis = novaPonuda.Opis,
                Koordinata1 = novaPonuda.Koordinate1,
                Koordinata2 = novaPonuda.Koordinate2
            };
            _context.Add(ponuda);

            foreach (var vodic in novaPonuda.VodicId)
            {
                VodicPonuda vodicPonuda = new VodicPonuda
                {
                    PonudaId = ponuda.Id,
                    VodicId = vodic
                };
                _context.VodicPonuda.Add(vodicPonuda);
            }

            foreach (var slika in novaPonuda.Slike)
            {
                PonudaSlike ponudeSlike = new PonudaSlike
                {
                    PonudaId = ponuda.Id,
                    SlikaUrl = slika
                };
                _context.PonudaSlike.Add(ponudeSlike);
            }


            _context.SaveChanges();

            return ponuda;
        }

        public List<PonudaToDisplay> GetAktivnaPutovanja(int userId = 0, int vodicId = 0)
        {
            List<PonudaToDisplay> putovanja = new List<PonudaToDisplay>();

            if (userId != 0)
            {
                putovanja = _context.PonudaUser.Include(x => x.Ponuda).Where(x => x.UserId == userId).Select(x => new PonudaToDisplay
                {
                    Naslov = x.Ponuda.Naslov,
                    PonudaId = x.PonudaId
                }).ToList();
            }
            if(vodicId !=0)
            {
                putovanja = _context.VodicPonuda.Include(x=>x.Ponuda).Where(x=>x.VodicId == vodicId).Select(x => new PonudaToDisplay
                {
                    Naslov = x.Ponuda.Naslov,
                    PonudaId = x.PonudaId
                }).ToList();
            }

            return putovanja;
            
        }

        public List<LokacijaToDisplay> GetDrzave()
        {
            var drzave = _context.Drzava.Select(x => new LokacijaToDisplay
            {
                Drzava = x.Naziv,
                DrzavaId = x.Id,
                LokacijaId = x.Id,
                Mjesto = "null"
            }).OrderBy(x=>x.Drzava).ToList();

            return drzave;
        }

        public List<LokacijaToDisplay> GetLokacija()
        {
            return _context.Lokacija.Include(x => x.Drzava).Select(x => new LokacijaToDisplay
            {
                LokacijaId = x.Id,
                Mjesto = x.Naziv,
                Drzava = x.Drzava.Naziv
            }).ToList();
        }

        public List<ObavijestToDisplay> GetObavijest(ObavijestToSearch queryParams)
        {

            List<ObavijestToDisplay> obavijesti = new List<ObavijestToDisplay>();

            if (queryParams.PonudaId != 0)
            {
                obavijesti = _context.Obavijesti.Include(x => x.User).Where(x => x.PonudaId == queryParams.PonudaId && x.Type == queryParams.Type)
                .Select(x => new ObavijestToDisplay
                {
                    Datum = x.Datum.ToString("dd/MM/yyyy HH:mm"),
                    Objavio = x.User.Ime + " " + x.User.Prezime,
                    Tekst = x.Tekst,
                    PonudaId = x.PonudaId
                })
                .ToList();
            }
            else
            {
                if (queryParams.Type == "poruka")
                {
                    //prikazi sve obavijesti od ponuda gdje je korisnik prijavljen, koje su aktivne
                    var obavijestiToAdd = new List<ObavijestToDisplay>();
                    var ponudeUser = _context.PonudaUser.Include(x=>x.Ponuda).Where(x => x.UserId == queryParams.UserId).ToList();

                    foreach (var pu in ponudeUser)
                    {
                        obavijesti.Add(new ObavijestToDisplay { PonudaNaslov = pu.Ponuda.Naslov, PonudaId = pu.PonudaId,
                            BrojClanova = _context.PonudaUser.Where(x=>x.PonudaId == pu.PonudaId).Count()+ " članova".ToString(),
                            BrojPoruka = _context.Obavijesti.Where(x=>x.PonudaId == pu.PonudaId && x.Type == "poruka").Count() + " poruka".ToString()  });
                    }
                }
                else
                {
                    //prikazi sve obavijesti od ponuda gdje je korisnik prijavljen, koje su aktivne
                    var obavijestiToAdd = new List<ObavijestToDisplay>();
                    var ponudeUser = _context.PonudaUser.Where(x => x.UserId == queryParams.UserId).ToList();

                    foreach (var pu in ponudeUser)
                    {
                        obavijestiToAdd = _context.Obavijesti.Where(x => x.PonudaId == pu.PonudaId && x.Type == queryParams.Type).Select(x => new ObavijestToDisplay
                        {
                            Datum = x.Datum.ToString("dd/MM/yyyy HH:mm"),
                            Objavio = x.User.Ime + " " + x.User.Prezime,
                            Tekst = x.Tekst,
                            PonudaNaslov = x.Ponuda.Naslov,
                            PonudaId = x.PonudaId
                        }).ToList();
                        obavijesti.AddRange(obavijestiToAdd);
                    }
                }

            }
            return obavijesti;
        }

        public PageResult<PonudaToDisplay> GetPonuda(PonudaToSearch queryParams, int userid)
        {

            var vodici = _context.VodicPonuda.Include(x => x.Vodic).Select(x => new UsertoDisplay
            {
                Ime = x.Vodic.Ime,
                Prezime = x.Vodic.Prezime,
                Username = x.Vodic.Ime + " " + x.Vodic.Prezime
            }).ToList();

            var query = _context.Ponuda.Select(x => new PonudaToDisplay
            {
                PonudaId = x.Id,
                Cijena = x.Cijena,
                CijenaIskljuceno = x.CijenaIskljuceno,
                CijenaUkljuceno = x.CijenaUkljuceno,
                DatumPolaska = x.DatumPolaska,
                DatumPovratka = x.DatumPovratka,
                Hotel = x.Hotel,
                Lokacija = _context.Lokacija.Include(c => c.Drzava).Where(c => c.Id == x.LokacijaId).Select(c => c.Naziv + " (" + c.Drzava.Naziv + ")").FirstOrDefault(),
                DrzavaId = x.Lokacija.DrzavaId,
                Napomena = x.Napomena,
                Naslov = x.Naslov,
                Opis = x.Opis,
                Koordinate1 = x.Koordinata1,
                Koordinate2 = x.Koordinata2,
                _Drzava = x.Lokacija.Drzava.Naziv,
                _Mjesto = x.Lokacija.Naziv,
                IsActive = x.IsActive,
                Slike = _context.PonudaSlike.Where(s => s.PonudaId == x.Id).Select(s => s.SlikaUrl).ToList(),
                Vodic = _context.VodicPonuda.Include(b => b.Vodic).Where(b => b.PonudaId == x.Id).Select(b => new UsertoDisplay
                {
                    Ime = b.Vodic.Ime,
                    Prezime = b.Vodic.Prezime,
                    Username = b.Vodic.Ime + " " + b.Vodic.Prezime
                }).ToList()
            }).AsQueryable();

            if(queryParams.PrikaziObrisane == true)
            {
                query = query.Where(x => x.IsActive == false);
            }

            if (queryParams.LokacijaId != 0)
            {
                query = query.Where(x => x.DrzavaId == queryParams.LokacijaId);
            }
            if (queryParams.Datum.Year != 1990)
            {
                query = query.Where(x => x.DatumPolaska.Month == queryParams.Datum.Month && x.DatumPolaska.Year == queryParams.Datum.Year);
            }
            // pretraga klijenta iz aplikacije
            if (!string.IsNullOrEmpty(queryParams.Naziv))
            {
                query = query.Where(x => x.Lokacija.Contains(queryParams.Naziv));
            }


            var ponude = query.ToList();

            var result = new PageResult<PonudaToDisplay>
            {
                Count = ponude.Count,
                PageIndex = queryParams.PageNumber,
                PageSize = queryParams.PageSize,
                Items = ponude.Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
              .Take(queryParams.PageSize)
              .ToList()
            };

            return result;
        }

        public PonudaToDisplay GetPonudaById(int id, int userid)
        {

            var ponuda = _context.Ponuda.Where(x => x.Id == id).Select(x => new PonudaToDisplay
            {
                PonudaId = x.Id,
                Cijena = x.Cijena,
                CijenaIskljuceno = x.CijenaIskljuceno,
                CijenaUkljuceno = x.CijenaUkljuceno,
                DatumPolaska = x.DatumPolaska,
                DatumPovratka = x.DatumPovratka,
                Hotel = x.Hotel,
                Lokacija = _context.Lokacija.Include(c => c.Drzava).Where(c => c.Id == x.LokacijaId).Select(c => c.Naziv + " (" + c.Drzava.Naziv + ")").FirstOrDefault(),
                DrzavaId = x.Lokacija.DrzavaId,
                Napomena = x.Napomena,
                Naslov = x.Naslov,
                Opis = x.Opis,
                Koordinate1 = x.Koordinata1,
                Koordinate2 = x.Koordinata2,
                _Mjesto = x.Lokacija.Naziv,
                _Drzava = x.Lokacija.Drzava.Naziv,
                IsActive = x.IsActive,
                Slike = _context.PonudaSlike.Where(s => s.PonudaId == id).Select(s => s.SlikaUrl).ToList(),
                Vodic = _context.VodicPonuda.Include(b => b.Vodic).Where(b => b.PonudaId == x.Id).Select(b => new UsertoDisplay
                {
                    Id = b.VodicId,
                    Ime = b.Vodic.Ime,
                    Prezime = b.Vodic.Prezime,
                    Username = b.Vodic.Ime + " " + b.Vodic.Prezime
                }).ToList()
            }).FirstOrDefault();

            return ponuda;
        }

        public PageResult<PonudaUserDisplay> GetPonudaUsers(PonudaUserToSearch queryParams)
        {
            var query = _context.PonudaUser.Include(x => x.User).Include(x => x.Ponuda)
                .Select(x => new PonudaUserDisplay
                {
                    Id = x.Id,
                    BrojOsoba = x.BrojOsoba,
                    Cijena = x.Cijena,
                    DatumRodjenja = x.User.DatumRodjenja.ToShortDateString(),
                    TipSobe = x.TipSobe,
                    ImePrezime = x.User.Ime + " " + x.User.Prezime,
                    NazivPonuda = x.Ponuda.Naslov,
                    VrijemePlacanja = x.VrijemePlacanja,
                    PonudaId = x.PonudaId,
                    TransakcijaId = x.TransakcijaId,
                    Telefon = x.User.PhoneNumber,
                    DatumPolaska = x.Ponuda.DatumPolaska,
                }).OrderBy(x => x.PonudaId).ToList().AsQueryable();

            //filter za mjesece rezervacije
            query = query.Where(x => x.DatumPolaska.Year == queryParams.Datum.Year && x.DatumPolaska.Month == queryParams.Datum.Month);

            if (queryParams.PonudaId != 0)
            {
                query = query.Where(x => x.PonudaId == queryParams.PonudaId);
            }
            var ponudeUser = query.ToList();

            var result = new PageResult<PonudaUserDisplay>
            {
                Count = ponudeUser.Count,
                PageIndex = queryParams.PageNumber,
                PageSize = queryParams.PageSize,
                Items = ponudeUser.Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
              .Take(queryParams.PageSize)
              .ToList()
            };

            return result;
        }

        public List<PonudaToDisplay> GetPreporuke(int userId)
        {
            var mojePretrage = _context.UserSearch.Where(x => x.UserId == userId).ToList();
            var svePonude = _context.Ponuda.Include(x=>x.Lokacija).ThenInclude(x=>x.Drzava).AsQueryable();

            List<PonudaToDisplay> preporuke = new List<PonudaToDisplay>();

            foreach (var pretraga in mojePretrage)
            {
                foreach (var ponuda in svePonude)
                {
                    if(pretraga.rDrzava == ponuda.Lokacija.Drzava.Naziv || pretraga.rMjesto == ponuda.Lokacija.Naziv)
                    {
                        if (preporuke.Any(x => x.PonudaId == ponuda.Id))
                        {
                            //skip
                        }
                        else
                        {
                            preporuke.Add(new PonudaToDisplay
                            {
                                PonudaId = ponuda.Id,
                                Cijena = ponuda.Cijena,
                                CijenaIskljuceno = ponuda.CijenaIskljuceno,
                                CijenaUkljuceno = ponuda.CijenaUkljuceno,
                                DatumPolaska = ponuda.DatumPolaska,
                                DatumPovratka = ponuda.DatumPovratka,
                                Hotel = ponuda.Hotel,
                                Lokacija = _context.Lokacija.Include(c => c.Drzava).Where(c => c.Id == ponuda.LokacijaId).Select(c => c.Naziv + " (" + c.Drzava.Naziv + ")").FirstOrDefault(),
                                DrzavaId = ponuda.Lokacija.DrzavaId,
                                Napomena = ponuda.Napomena,
                                Naslov = ponuda.Naslov,
                                Opis = ponuda.Opis,
                                Koordinate1 = ponuda.Koordinata1,
                                Koordinate2 = ponuda.Koordinata2,
                                _Mjesto = ponuda.Lokacija.Naziv,
                                _Drzava = ponuda.Lokacija.Drzava.Naziv,
                                Slike = _context.PonudaSlike.Where(s => s.PonudaId == ponuda.Id).Select(s => s.SlikaUrl).ToList(),
                                Vodic = _context.VodicPonuda.Include(b => b.Vodic).Where(b => b.PonudaId == ponuda.Id).Select(b => new UsertoDisplay
                                {
                                    Id = b.VodicId,
                                    Ime = b.Vodic.Ime,
                                    Prezime = b.Vodic.Prezime,
                                    Username = b.Vodic.Ime + " " + b.Vodic.Prezime
                                }).ToList()
                            });
                        }
                    }
                }
            }

            
            return preporuke;

        }

        public List<UsertoDisplay> GetVodici()
        {
            return _context.UserRoles.Include(x => x.Role).Include(x => x.User).Where(x => x.Role.Name == "Vodić").Select(x => new UsertoDisplay
            {
                Id = x.User.Id,
                Ime = x.User.Ime,
                Prezime = x.User.Prezime
            }).ToList();
        }

        public void OtkaziRezervaciju(int rezervacijaId)
        {
            var rezervacija = _context.PonudaUser.Include(x=>x.Ponuda).FirstOrDefault(x => x.Id == rezervacijaId);
            rezervacija.IsCanceled = true;

            var dispute = new OtkazanaPonudaUser
            {
                CijenaPonude = rezervacija.Ponuda.Cijena,
                DatumOtkazivanja = DateTime.Now,
                PonudaUserId = rezervacijaId,
                StatusDisputa = Data.StatusDisputa.Aktivno,
            };
            _context.Add(dispute);
            _context.SaveChanges();
        }
        public void DisputeUpdate(int id, DisputeToDisplay disputeToDisplay)
        {
            var dispute = _context.OtkazanaPonudaUser.FirstOrDefault(x => x.Id == id);
            dispute.IznosPovrata = disputeToDisplay.IznosPovrata;
            dispute.StatusDisputa = (Data.StatusDisputa) 1;
            if(disputeToDisplay.StatusDisputa == Model.StatusDisputa.Zavrseno)
            {
                dispute.DatumZavrsetkaDisputa = DateTime.Now;
            }
            _context.SaveChanges();
        }

        public void PonudaUserAdd(PonudaUserAdd ponudaUser)
        {
            var ponuda = new PonudaUser
            {
                PonudaId = ponudaUser.PonudaId,
                UserId = ponudaUser.UserId,
                BrojOsoba = ponudaUser.BrojOsoba,
                TipSobe = ponudaUser.TipSobe,
                Cijena = ponudaUser.Cijena,
                VrijemePlacanja = DateTime.Now,
                TransakcijaId = ponudaUser.TransakcijaId
            };
            _context.PonudaUser.Add(ponuda);
            _context.SaveChanges();


            Helpers.CatchAction catchAction = new Helpers.CatchAction(_context);
            catchAction.SpasiAkciju(new HelperActionToSave { UserId = ponudaUser.UserId, rCijena = Convert.ToSingle(ponudaUser.Cijena), rMjesec = _context.Ponuda.Where(x=>x.Id == ponudaUser.PonudaId).Select(x=>x.DatumPolaska).FirstOrDefault()});

        }

        public Statistika PopularnaPutovanja()
        {

            var putovanja = from ponudauser in _context.PonudaUser group ponudauser by ponudauser.PonudaId into g select new { PonudaId = g.Key, Count = g.Count(), naziv = g.Select(x=>x.Ponuda.Naslov)};

            putovanja = putovanja.OrderByDescending(x => x.Count).Take(3);

            List<TopThree> top3 = new List<TopThree>();
            foreach (var item in putovanja)
            {
                top3.Add(new TopThree { NazivPutovanja = item.naziv.FirstOrDefault(), UkupnoPrijavljeno=item.Count });
            }

            Statistika statistika = new Statistika
            {
                BrDestinacija = _context.Ponuda.Count(),
                BrKorisnika = _context.Users.Count(),
                BrRezervacija = _context.PonudaUser.Count(),
                BrPregleda = _context.UserSearch.Count(),
                Top3 = top3
            };

            return statistika;
        }

        public void UpdatePonuda(int ponudaId, PonudaToAdd ponudaToUpdate)
        {
            var ponuda = _context.Ponuda.Find(ponudaId);
            ponuda.Hotel = ponudaToUpdate.Hotel;
            ponuda.LokacijaId = ponudaToUpdate.LokacijaId;
            ponuda.Napomena = ponudaToUpdate.Napomena;
            ponuda.Naslov = ponudaToUpdate.Naslov;
            ponuda.Opis = ponudaToUpdate.Opis;
            ponuda.Cijena = ponudaToUpdate.Cijena;
            ponuda.CijenaIskljuceno = ponudaToUpdate.CijenaIskljuceno;
            ponuda.CijenaUkljuceno = ponudaToUpdate.CijenaUkljuceno;
            ponuda.DatumPolaska = ponudaToUpdate.DatumPolaska;
            ponuda.DatumPovratka = ponudaToUpdate.DatumPovratka;
            ponuda.Koordinata1 = ponudaToUpdate.Koordinate1;
            ponuda.Koordinata2 = ponudaToUpdate.Koordinate2;

            var vodiciPonuda = _context.VodicPonuda.Where(x => x.PonudaId == ponudaId).ToList();
            foreach (var vodic in vodiciPonuda)
            {
                _context.VodicPonuda.Remove(vodic);
            }

            foreach (var vodic in ponudaToUpdate.VodicId)
            {
                VodicPonuda vp = new VodicPonuda { PonudaId = ponudaId, VodicId = vodic };
                _context.VodicPonuda.Add(vp);
            }

            //foreach (var slika in ponudaToUpdate.Slike)
            //{
            //    PonudaSlike ps = new PonudaSlike { PonudaId = ponudaId, SlikaUrl = slika };
            //    _context.PonudaSlike.Add(ps);
            //}

            _context.SaveChanges();

        }

        public void ZabiljeziPosjetu(int ponudaid, int userid)
        {
            var ponuda = _context.Ponuda.Include(x=>x.Lokacija).ThenInclude(x=>x.Drzava).Where(x => x.Id == ponudaid).FirstOrDefault();

            Helpers.CatchAction catchAction = new Helpers.CatchAction(_context);
            catchAction.SpasiAkciju(new HelperActionToSave { rMjesto = ponuda.Lokacija.Naziv, rDrzava = ponuda.Lokacija.Drzava.Naziv, UserId = userid });
        }

        public DisputeToDisplay GetDisputeInfo(int otkazanaPonudaId)
        {
            return _context.OtkazanaPonudaUser.Where(x => x.PonudaUserId == otkazanaPonudaId).Select(x=> new DisputeToDisplay
            {
                Id = x.Id,
                IznosPovrata = x.IznosPovrata,
                DatumZavrsetkaDisputa = x.DatumZavrsetkaDisputa != null ? x.DatumZavrsetkaDisputa.ToString() : "-",
                DatumOtkazivanja = x.DatumOtkazivanja,
                StatusDisputa = (Model.StatusDisputa) x.StatusDisputa,
            }).FirstOrDefault();
        }

        public void OtkaziPonudu(int ponudaId)
        {
            var ponuda = _context.Ponuda.Where(x => x.Id == ponudaId).FirstOrDefault();
            ponuda.IsActive = false;

            var rezervacije = _context.PonudaUser.Where(x => x.PonudaId == ponudaId).ToList();

            foreach(var rezervacija in rezervacije)
            {
                rezervacija.IsCanceled = true;
                var otkazanaPonudaUser = new OtkazanaPonudaUser
                {
                    CijenaPonude = rezervacija.Cijena,
                    DatumOtkazivanja = DateTime.Now,
                    PonudaUserId = rezervacija.Id,
                    StatusDisputa = Data.StatusDisputa.Aktivno
                };
                _context.Add(otkazanaPonudaUser);
            }
            _context.SaveChanges();
        }
    }
}
