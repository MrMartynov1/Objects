using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hevonen
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen Pieni = new Hevonen();

            Console.Write("Pienen hevosen tiedot:");
            Console.WriteLine();
            Console.Write(Pieni.Nimi);
            Console.WriteLine();
            Console.Write(Pieni.Paino);
            Console.ReadKey();
            Console.Clear();

            Pieni.Nimi = "Pieni";
            Pieni.Paino = 6;

            Console.Write("Pienen hevosen tiedot:");
            Console.WriteLine();
            Console.Write(Pieni.Nimi);
            Console.WriteLine();
            Console.Write(Pieni.Paino);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
