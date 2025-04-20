using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ChansonService : Service<Chanson>, IChanson
    {
        public ChansonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Chanson> getcinqChanson(Artiste a)
        {
            return GetAll().Where(p => p.Artiste.Equals(a) && p.DateSortie >= DateTime.Now.AddYears(-2)).OrderByDescending(p => p.VuesYoutubes).TakeLast(5).ToList();
        }
    }
}
