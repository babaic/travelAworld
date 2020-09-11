using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;
using travelAworld.Model;

namespace travelAworld.Services
{
    public interface IPonudaService
    {
        Ponuda DodajPonudu(PonudaToAdd ponuda);
        List<UsertoDisplay> GetVodici();
        List<LokacijaToDisplay> GetLokacija();
        List<LokacijaToDisplay> GetDrzave();
        Lokacija DodajLokaciju(LokacijaToAdd lokacijaToAdd);
        void UpdatePonuda(int ponudaId, PonudaToAdd ponudaToUpdate);
        PageResult<PonudaToDisplay> GetPonuda(PonudaToSearch queryParams, int userid);
        PonudaToDisplay GetPonudaById(int id, int userid);
        void PonudaUserAdd(PonudaUserAdd ponudaUser);
        PageResult<PonudaUserDisplay> GetPonudaUsers(PonudaUserToSearch queryParams);

        void DodajObavijest(ObavijestAdd obavijest, int objavioId);
        List<ObavijestToDisplay> GetObavijest(ObavijestToSearch queryParams);
        List<PonudaToDisplay> GetAktivnaPutovanja(int userId = 0, int vodicId = 0);
        void ZabiljeziPosjetu(int ponudaid, int userid);
        List<PonudaToDisplay> GetPreporuke(int userId);
        Statistika PopularnaPutovanja();
        void OtkaziRezervaciju(int rezervacijaId);
        void DisputeUpdate(int id, DisputeToDisplay disputeToDisplay);
        DisputeToDisplay GetDisputeInfo(int otkazanaPonudaId);
        void OtkaziPonudu(int ponudaId);
    }
}
