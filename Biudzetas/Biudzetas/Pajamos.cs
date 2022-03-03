using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biudzetas
{
    public class Pajamos
    {
        public string Menesis { get; set; }
        public string Pavadinimas { get; set; }
        public double Kiekis { get; set; }
        public Pajamos (string menesis, string pavadinimas, double kiekis)
        {
            Menesis = menesis;
            Pavadinimas = pavadinimas;
            Kiekis = kiekis;
        }
    }
}
