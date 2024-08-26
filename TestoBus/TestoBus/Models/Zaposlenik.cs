using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestoBus.Models
{
    public class Zaposlenik : Osoba
    {
        public string Adresa { get; set; }
        public string Mobitel { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }

        public bool ProvjeraLozinke(string lozinka)
        {
            return Password == lozinka;
        }
    }
}
