using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Th11
{
    class Program
    {
        static void Main(string[] args)
        {
            var kissat = new List<Kissa>();
            var koirat = new List<Koira>();
            var hevot = new List<Hevonen>();
            var paput = new List<Papukaija>();
            int v;
            int g = 1;

            Console.Write("Aseta luotavien eläinten määrä: ");
            Int32.TryParse(Console.ReadLine(), out v);
            

            while (g <= v)
            {
                for (int i = 0; i < 3; i++, g++)
                {
                    if (g % 4 == 0)
                    {
                        if (g <= v)
                        {
                        Hevonen hevo = new Hevonen();
                        Console.WriteLine("Hevonen luotu.");
                        //Console.ReadKey();
                        hevo.nimi = string.Format("Hevonen #{0}", (g));
                        hevo.ArvoElaimenIka(15);
                        hevo.asetaOnLihanSyoja(false);
                        hevo.Print();
                        hevo.Aantele();
                        hevo.PrintAsetaSyntyy();
                        hevot.Add(hevo);
                        Console.Write("");
                        //Console.ReadKey();
                        }
                    }
                    else
                    {
                    
                    switch (i)
                    {
                        case 0:
                            Kissa katti = new Kissa();
                            Console.WriteLine("Kissa luotu.");
                            //Console.ReadKey();
                            katti.nimi = string.Format("Kissa #{0}", (g));
                            katti.ArvoElaimenIka(15);
                            katti.asetaOnLihanSyoja(false);
                            katti.Print();
                            katti.kehraa();
                            katti.Aantele();
                            katti.PrintAsetaSyntyy();
                            kissat.Add(katti);
                            Console.Write("");
                            //Console.ReadKey();
                            break;

                        case 1:
                            Koira kr = new Koira();
                            Console.WriteLine("Koira luotu.");
                            //Console.ReadKey();
                            kr.nimi = string.Format("Koira #{0}", (g));
                            kr.ArvoElaimenIka(15);
                            kr.asetaOnLihanSyoja(false);
                            kr.Print();
                            kr.Aantele();
                            kr.PrintAsetaSyntyy();
                            koirat.Add(kr);
                            Console.Write("");
                          //Console.ReadKey();
                            break;

                        case 2:
                            Papukaija papu = new Papukaija();
                            Console.WriteLine("Papukaija luotu.");
                            //Console.ReadKey();
                            papu.nimi = string.Format("Papukaija #{0}", (g));
                            papu.ArvoElaimenIka(15);
                            papu.asetaOnLihanSyoja(false);
                            papu.Print();
                            papu.Aantele();
                            papu.PrintAsetaLentaa();
                            paput.Add(papu);
                            Console.Write("");
                           // Console.ReadKey();
                            break;

                    }

                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
            foreach (Kissa katti in kissat)
            {
                
                katti.Print();
                katti.Aantele();
                katti.PrintAsetaSyntyy();
            }
            foreach (Koira kr in koirat)
            {

                kr.Print();
                kr.Aantele();
                kr.PrintAsetaSyntyy();
            }
            foreach (Hevonen hevo in hevot)
            {

                hevo.Print();
                hevo.Aantele();
                hevo.PrintAsetaSyntyy();
            }
            foreach (Papukaija papu in paput)
            {

                papu.Print();
                papu.Aantele();
                papu.PrintAsetaLentaa();
            }

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
