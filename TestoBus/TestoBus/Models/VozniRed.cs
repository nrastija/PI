using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestoBus.Models
{
    public class VozniRed
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Polazisna { get; set; }

        public string Odredisna { get; set; }

        public int Vrijeme { get; set; }

        public string Autobus { get; set; } 

    }
}
