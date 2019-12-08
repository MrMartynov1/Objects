using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ika
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ElainLuokat.Kissa> kissat = new List<ElainLuokat.Kissa>(); // Thats how it works you retard
            //Object Kissa = new { };                   //examples for some other shit
            //String Kissanimi = Kissa.GetType().Name;

            for (int i = 0; i < 10; i++)
            {
                int rng1 = new Random().Next(11);

                Console.WriteLine("Luodaan Kissa...");
                var kissa = new List<ElainLuokat.Kissa>();
                kissa.Add(new ElainLuokat.Kissa() { Name = "Kissa #" + (i + 1), ika = rng1 });
                Console.ReadKey();
                Console.Write("Kissan nimi on: ");
                kissa.ForEach(x => Console.WriteLine(x.Name));
                Console.ReadKey();
                Console.Write("Kissan ikä on: ");
                kissa.ForEach(x => Console.WriteLine(x.palautaKissanIka()));
                Console.WriteLine();

                int rng2 = new Random().Next(16);
                Console.WriteLine("Luodaan Koira...");
                var koira = new List<Tehtävä2.Koira>();
                koira.Add(new Tehtävä2.Koira { Name = "Koira #" + (i + 1), korika = rng2 });
                Console.ReadKey();
                Console.Write("Koiran nimi on: ");
                koira.ForEach(y => Console.WriteLine(y.Name));
                Console.ReadKey();
                Console.Write("Koiran ikä on: ");
                koira.ForEach(y => Console.WriteLine(y.palautaKoiranIka()));
                Console.WriteLine();
                //
                if (rng2 > rng1)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
            }
        }
    }
}
