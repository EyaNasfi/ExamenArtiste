using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ConcertService : Service<Concert>, IConcert
    {
        public ConcertService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Concert> getconcerts(StyleMusical sm)
        {
            return GetAll().Where(p => p.Artiste.Chansons.Any(a => a.StyleMusical.Equals(sm)) && p.DateConcert.Year.Equals(DateTime.Now.Year)).ToList();
        }

        public double gethighercachet(Festival f)
        {
            return GetAll().Where(o => o.Festival.Equals(f)).Select(o => o.Cachet).OrderByDescending(c=>c).First();
        }
    }
}
