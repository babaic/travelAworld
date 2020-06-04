using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;
using travelAworld.EF;
using travelAworld.Model;

namespace travelAworld.Helpers
{
    public class CatchAction
    {
        private readonly MyContext _context;

        public CatchAction(MyContext context)
        {
            _context = context;
        }

        public void SpasiAkciju(HelperActionToSave content)
        {
            UserSearch us = new UserSearch
            {
                UserId = content.UserId,
                rCijena = content.rCijena,
                rDrzava = content.rDrzava,
                rMjesto = content.rMjesto,
                rMjesec = content.rMjesec
            };

            _context.Add(us);
            _context.SaveChanges();


        }

        public void dbSave()
        {
            UserSearch us2 = new UserSearch
            {
                UserId = 51,
                rCijena = 22,
                rDrzava = "dede",
                rMjesto = "frefef",
                rMjesec = DateTime.Now
            };

            _context.Add(us2);
            _context.SaveChanges();
        }
    }
}
