﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Model
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            //KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? Status { get; set; }

        //public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}