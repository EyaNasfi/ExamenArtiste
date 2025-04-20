using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Artiste
    {
        public int ArtisteId { get; set; }
        public string Contact { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Nationalite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual IList<Chanson> Chansons { get; set; }
        public virtual IList<Concert> Concerts { get; set; }

    }
}
