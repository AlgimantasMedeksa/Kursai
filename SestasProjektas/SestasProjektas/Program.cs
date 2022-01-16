using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SestasProjektas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite vardą:");
            string vardas = (Console.ReadLine());
            Console.WriteLine("Įveskite amžių:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite mėgstamą double skaičių:");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mano vardas yra " + vardas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mano amžius yra " + amzius + " metai");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mano mėgstamas skaičius yra " + skaicius);
            Console.ReadLine();
        }
    }
}
