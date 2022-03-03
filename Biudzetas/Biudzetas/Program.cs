using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biudzetas
{
    class Program
    {
        static void Main(string[] args)
        {
            atidarytiPagrindinilanga();
            

        }
        public static void atidarytiPagrindinilanga()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pagrindinis langas  \n" +
                "Pajamu ivedimas    1\n" +
                "Islaidu ivedimas   2\n" +
                "Pajamu perziura    3\n" +
                "Islaidu perziura   4\n" +
                "Pajamu suma        5\n" +
                "Islaidu suma       6\n" +
                "Balansas           7\n" +
                "Islaidu filtras    8\n" +
                "Baigti darba       9\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iveskite reikalingos operacijos numeri");
            int operacijosNr = 0;
            while (operacijosNr != 9)
            {
                operacijosNr = Convert.ToInt32(Console.ReadLine());
                switch (operacijosNr)
                {
                    case 1:
                        IvestiPajamas();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 2:
                        IvestiIslaidas();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 3:
                        PajamuPerziura();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 4:
                        IslaiduPerziura();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 5:
                        SuskaiciuotiPajamuSuma();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 6:
                        SuskaiciuotiIslaiduSuma();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 7:
                        SuskaiciuotiBalansa();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                    case 8:
                        FiltruotiIslaidas();
                        Console.WriteLine("Iveskite sekancios operacijos numeri");
                        break;
                }
            }
        }

        public static void IvestiPajamas()
        {
            string relativePath = @"..\..\..\Pajamos.txt";
            Console.WriteLine("Iveskite pajamas:\n menesis pavadinimas suma");
            string pajamos = Console.ReadLine();
            File.AppendAllLines(relativePath, new string[] { pajamos });
            PapildytiPajamas();
        }
        public static void PapildytiPajamas()
        {

            Console.WriteLine("Jei toliau pildysite spauskite y(Yes)\njei uzbaigete spauskite n(No)");
            string p = Console.ReadLine();
            switch (p)
            {
                case "y":
                    IvestiPajamas();
                    break;
                case "n":
                    IvestiIslaidas();
                    break;
            }
        }
        public static void IvestiIslaidas()
        {
            string relativePath1 = @"..\..\..\Islaidos.txt";
            Console.WriteLine("Iveskite islaidas:\n menesis pavadinimas suma");
            string islaidos = Console.ReadLine();
            File.AppendAllLines(relativePath1, new string[] { islaidos });
            PapildytiIslaidas();
        }
        public static void PapildytiIslaidas()
        {

            Console.WriteLine("Jei toliau pildysite spauskite y(Yes)\njei uzbaigete spauskite n(No)");
            string p = Console.ReadLine();
            switch (p)
            {
                case "y":
                    IvestiIslaidas();
                    break;
                case "n":

                    break;
            }
        }
        public static void PajamuPerziura()
        {
            string relativePath = @"..\..\..\Pajamos.txt";
            string pajamuFailas = File.ReadAllText(relativePath);
            Console.WriteLine(pajamuFailas);
        }
        public static void IslaiduPerziura()
        {
            string relativePath1 = @"..\..\..\Islaidos.txt";
            string islaiduFailas = File.ReadAllText(relativePath1);
            Console.WriteLine(islaiduFailas);
        }
        public static double SuskaiciuotiPajamuSuma()
        {
            string relativePath = @"..\..\..\Pajamos.txt";
            string[] pajamuTekstas = File.ReadAllLines(relativePath);
            List<Pajamos> pajamuSarasas = new List<Pajamos>();
            foreach (var pajamuDalys in pajamuTekstas)
            {
                string[] pajamos = pajamuDalys.Split(' ');
                pajamuSarasas.Add(new Pajamos(Convert.ToString(pajamos[0]), Convert.ToString(pajamos[1]), Convert.ToDouble(pajamos[2])));
            }
            var pajamuSuma = pajamuSarasas.Sum(x => x.Kiekis);
            Console.WriteLine($"Pajamu suma: {pajamuSuma} EUR");
            return pajamuSuma;
        }
        public static double SuskaiciuotiIslaiduSuma()
        {
            string relativePath1 = @"..\..\..\Islaidos.txt";
            string[] islaiduTekstas = File.ReadAllLines(relativePath1);
            List<Islaidos> islaiduSarasas = new List<Islaidos>();
            foreach (var islaiduDalys in islaiduTekstas)
            {
                string[] islaidos = islaiduDalys.Split(' ');
                islaiduSarasas.Add(new Islaidos(Convert.ToString(islaidos[0]), Convert.ToString(islaidos[1]), Convert.ToDouble(islaidos[2])));
            }
            var islaiduSuma = islaiduSarasas.Sum(x => x.Kiekis);
            Console.WriteLine($"Islaidu suma: {islaiduSuma} EUR");
            return islaiduSuma;
        }
        public static void SuskaiciuotiBalansa()
        {
            double balansas = SuskaiciuotiPajamuSuma() - SuskaiciuotiIslaiduSuma();
            Console.WriteLine($"Balansas {balansas} EUR");
        }
        public static void FiltruotiIslaidas()
        {
            string relativePath1 = @"..\..\..\Islaidos.txt";
            string[] islaiduTekstas = File.ReadAllLines(relativePath1);
            List<Islaidos> islaiduSarasas = new List<Islaidos>();
            foreach (var islaiduDalys in islaiduTekstas)
            {
                string[] islaidos = islaiduDalys.Split(' ');
                islaiduSarasas.Add(new Islaidos(Convert.ToString(islaidos[0]), Convert.ToString(islaidos[1]), Convert.ToDouble(islaidos[2])));
            }
            Console.WriteLine("Iveskite islaidu pavadinima");
            string reiksme = Convert.ToString(Console.ReadLine());
            var filtruotasSarasas = islaiduSarasas.Where(Islaidos => Islaidos.Pavadinimas == reiksme);
            foreach (var islaidos in filtruotasSarasas)
            {
                Console.WriteLine($"{islaidos.Menesis}     {islaidos.Kiekis}");
            }
        }
    }
}
