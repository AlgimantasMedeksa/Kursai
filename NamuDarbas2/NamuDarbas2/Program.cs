using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b && a < 100)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrą ir mažesnis už 100.");
                Console.WriteLine();
            }
            if (b > 0 && b > a)
            {
                Console.WriteLine("Antras skaičius yra teigiamas ir didesnis už pirmą.");
                Console.WriteLine();
            }
            if ((a > b && a > c) || a > 0)
            {
                Console.WriteLine("Pirmas skaičius yra teigiamas, arba didesnis už antrą ir trečią skaičių.");
                Console.WriteLine();
            }
            if ((c >= 5 && c <= 10) || c > a || c > b)
            {
                Console.WriteLine("Trečias skaičius yra lygus arba didesnis už 5 bet mažesnis arba lygus už 10,");
                Console.WriteLine("arba didesnis už pirmą arba antrą skaičių.");
            }
            else
            {
                Console.WriteLine("Skaičių reikšmės neatitinka nei vienai sąlygai.");
            }
            Console.ReadLine();
        }
    }
}
