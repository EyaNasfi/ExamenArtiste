using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IConcert:IService<Concert>
    {
        public double gethighercachet(Festival f);
        public IList<Concert> getconcerts(StyleMusical sm);
    }
}
