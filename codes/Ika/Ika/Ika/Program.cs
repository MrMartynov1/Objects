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
                int rng1 = new Random().Next(10);

                Console.WriteLine("Luodaan Kissa...");
                var kissa = new List<Kissa>();
                kissa.Add(new Kissa() { Name = "Kissa #" + (i + 1), ika = rng1 });
                Console.ReadKey();
                Console.Write("Kissan nimi on: ");
                kissa.ForEach(x => Console.WriteLine(x.Name));
                Console.ReadKey();
                Console.Write("Kissan ikä on: ");
                kissa.ForEach(x => Console.WriteLine(x.palautaKissanIka()));
                Console.WriteLine();

                int rng2 = new Random().Next(15);
                Console.WriteLine("Luodaan Koira...");
                var koira = new List<Koira>();
                koira.Add(new Koira { Name = "Koira #" + (i + 1), korika = rng2 });
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
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (rng1 > rng2)
                {
                    Console.WriteLine("Kissa on vanhempi");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Molemmat ovat samanikäisiä");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
