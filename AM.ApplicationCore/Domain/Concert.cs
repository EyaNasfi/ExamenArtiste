﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public  class Concert
    {
        public double Cachet { get; set; }
        public DateTime DateConcert { get; set; }
        public int Duree { get; set; }
        public virtual Artiste Artiste { get; set; }
        public virtual Festival Festival { get; set; }
        public int FestivalFk { get; set; }
        public int ArtisteFk { get; set; }
    }
}
