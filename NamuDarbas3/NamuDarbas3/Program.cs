using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbas3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite informaciją");
            Console.Write("Kiek darbuotojas gali iškepti kepalų per valandą?: ");
            int nasumas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kiek darbuotojų turi kepykla?: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vieno kepalo savikaina (EUR): ");
            double VKsavikaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vieno kepalo pardavimo kaina (EUR): ");
            double kaina = Convert.ToDouble(Console.ReadLine());
            double apimtis = nasumas * darbuotojai * 8;
            double savikaina = apimtis * VKsavikaina;
            double GautosPajamos = apimtis * kaina;
            double pelnas = GautosPajamos - savikaina;
            Console.WriteLine("Kepykla per vieną dieną iškeps duonos kepalų: "+ apimtis);
            Console.WriteLine("Savikaina per dieną (EUR): " + apimtis);
            Console.WriteLine("Gautos pajamos per dieną (EUR): " + GautosPajamos);
            Console.WriteLine("Pelnas per dieną (EUR): " + pelnas);
            Console.ReadLine();
        }
    }
}
