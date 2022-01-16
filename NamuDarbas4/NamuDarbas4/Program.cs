using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbas4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string ciklas = "y";
            while (ciklas == "y")
            {
                Console.Write("iveskite pirma skaiciu: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("iveskite antra skaiciu: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Pasirinkite artmetini veiksma (+,-,*,/): ");
                string veiksmas = Console.ReadLine();
                Console.Write("Rezultatas: ");
                if (veiksmas == "+")
                {
                    Console.WriteLine(p.Suma(a, b));
                }
                else if (veiksmas == "-")
                {
                    Console.WriteLine(p.Skirtumas(a, b));
                }
                else if (veiksmas == "*")
                {
                    Console.WriteLine(p.Sandauga(a, b));
                }
                else if (veiksmas == "/")
                {
                    Console.WriteLine(p.Dalmuo(a, b));
                }
                else
                {
                    Console.WriteLine("Tokio artmetinio veiksmo nera");
                }
                Console.WriteLine("Ar norite dar karta skaiciuoti");
                Console.WriteLine("Jei taip spauskite Y (Yes)");
                ciklas = Console.ReadLine();
            }
        }
        public double Suma(double a, double b)
        {
            return a + b;
        }
        public double Skirtumas(double a, double b)
        {
            return a - b;
        }
        public double Sandauga(double a, double b)
        {
            return a * b;
        }
        public double Dalmuo(double a, double b)
        {
            return a / b;
        }
    }
}
