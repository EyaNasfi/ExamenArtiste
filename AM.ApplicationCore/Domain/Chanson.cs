using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum StyleMusical { Classique,Pop,Rap,Rock}
    public class Chanson
    {
        public int ArtistFk { get; set; }

        [ForeignKey("ArtistFk")]
        public virtual Artiste Artiste { get; set; }
        public int ChansonId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }
        public int Duree { get; set; }
        public StyleMusical StyleMusical { get; set; }
        [MaxLength(12)]
        [MinLength(3)]
        public string Titre { get; set; }
        [Range(0, int.MaxValue,ErrorMessage ="faut etre positive"),]
        public int VuesYoutubes { get; set; }
    }
}
