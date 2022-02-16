﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Model
{
    public partial class Proizvodi
    {

        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaId { get; set; }
        public int JedinicaMjereId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Status { get; set; }

        public virtual JediniceMjere JedinicaMjere { get; set; }
        public virtual VrsteProizvoda Vrsta { get; set; }
        //public virtual ICollection<IzlazStavke> IzlazStavke { get; set; }
        //public virtual ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        //public virtual ICollection<Ocjene> Ocjene { get; set; }
        //public virtual ICollection<UlazStavke> UlazStavke { get; set; }
    }
}
