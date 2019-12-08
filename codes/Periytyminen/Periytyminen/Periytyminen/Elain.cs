using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    public class Elain
    {
        public int Ika;
        public string Nimi;
        //public int ikaElain;

        public Elain() //konstruktori
        {

        }

        public Elain(int ika, string nimi) //parametrillinen konstruktori
        {
            this.Ika = ika;
            this.Nimi = nimi;
        }

        public void asetaElaimenNimi(string nimi) //metodi
        {
            try
            {
                Console.WriteLine("Aseta Eläimen nimi: ");
                Console.ReadLine();

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Virhe yritä uudelleen...", e);
            }

            this.Nimi = Console.ReadLine();

        }

        public string palautaElaimenNimi()
        {
            return Nimi;
        }

        public void asetaElaimenIka(int ika)
        {
            Console.WriteLine("Aseta Eläimen ikä: ");
            Int32.TryParse(Console.ReadLine(), out ika);


            if (ika < 0)
            {
                Console.WriteLine("Virhe yritä uudelleen...");
                Console.ReadKey();
                Console.Clear();
                System.Environment.Exit(1);
            }
            else
            {
                this.Ika = ika;
            }
            Console.ReadKey();
            Console.Clear();
        }

        public int palautaElaimenIka()
        {
            return Ika;
        }

        private bool OnLihanSyoja = true;

        public void asetaOnLihanSyoja(bool OnLihanSyoja = true)
        {
            OnLihanSyoja = true;
        }
        public bool PalautaOnLihanSyoja()
        {
            return OnLihanSyoja;
        }

        //--------------------------------

        

            /*public void asetaElaimenNimi(string nimi) //metodi
            {
                try
                {
                    Console.WriteLine("Aseta Eläimen nimi: ");
                    Console.ReadLine();

                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Virhe yritä uudelleen...", e);
                }

                this.Nimi = Console.ReadLine();

            }

            public string palautaElaimenNimi()
            {
                return Nimi;
            }

            public void asetaElaimenIka(int ika)
            {
                Console.WriteLine("Aseta Eläimen ikä: ");
                Int32.TryParse(Console.ReadLine(), out ika);


                if (ika < 0)
                {
                    Console.WriteLine("Virhe yritä uudelleen...");
                    Console.ReadKey();
                    Console.Clear();
                    System.Environment.Exit(1);
                }
                else
                {
                    this.Ika = ika;
                }
                Console.ReadKey();
                Console.Clear();
            }

            public int palautaElaimenIka()
            {
                return Ika;
            }*/

        
    }
}
