using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa Kissa1 = new Kissa();
            Console.WriteLine("Kissa luotu.");
            Console.ReadKey();
            Console.Clear();
            Kissa1.asetaElaimenNimi();
            Kissa1.asetaElaimenIka();
            Kissa1.asetaOnLihanSyoja(false);
            Kissa1.Print();
            Kissa1.kehraa();
            Kissa1.Aantele();
            Kissa1.PrintAsetaSyntyy();
            Console.ReadKey();
            Console.Clear();
            
            Koira Koira1 = new Koira();
            Console.WriteLine("Koira luotu.");
            Console.ReadKey();
            Console.Clear();
            Koira1.asetaElaimenNimi();
            Koira1.asetaElaimenIka();
            Koira1.asetaOnLihanSyoja(true);
            Koira1.Print();
            Koira1.Aantele();
            Koira1.PrintAsetaSyntyy();
            Console.ReadKey();
            Console.Clear();

            Hevonen Hevonen1 = new Hevonen();
            Console.WriteLine("Hevonen luotu.");
            Console.ReadKey();
            Console.Clear();
            Hevonen1.asetaElaimenNimi();
            Hevonen1.asetaElaimenIka();
            Hevonen1.asetaOnLihanSyoja(false);
            Hevonen1.Print();
            Hevonen1.Aantele();
            Hevonen1.PrintAsetaSyntyy();
            Console.ReadKey();
            Console.Clear();

            Kilpikonna Kilpikonna1 = new Kilpikonna();
            Console.WriteLine("Kilpikonna luotu.");
            Console.ReadKey();
            Console.Clear();
            Kilpikonna1.asetaElaimenNimi();
            Kilpikonna1.asetaElaimenIka();
            Kilpikonna1.asetaOnLihanSyoja(false);
            Kilpikonna1.Print();
            Kilpikonna1.Aantele();
            Kilpikonna1.PrintAsetaSyntyy();
            Console.ReadKey();
            Console.Clear();

            Papukaija Papukaija1 = new Papukaija();
            Console.WriteLine("Papukaija luotu.");
            Console.ReadKey();
            Console.Clear();
            Papukaija1.asetaElaimenNimi();
            Papukaija1.asetaElaimenIka();
            Papukaija1.asetaOnLihanSyoja(false);
            Papukaija1.Print();
            Papukaija1.Aantele();
            Papukaija1.PrintAsetaLentaa();
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);

        }
    }
}
