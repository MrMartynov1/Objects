using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    abstract public class Elain
    {
        public int ika;
        public string nimi;
        public int x;
        private bool OnLihanSyoja;
        Random rng = new Random(Guid.NewGuid().GetHashCode());
        //public int ikaElain;

        public Elain() //konstruktori
        {

        }

        public void asetaElaimenNimi() //metodi
        {
            try
            {
                Console.Write("Aseta Eläimen nimi: ");
                nimi = Console.ReadLine();

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Virhe, yritä uudelleen...", e);
            }

        }

        public void asetaElaimenNimiTh11(string nimi)
        {
            this.nimi = nimi;
        }

        public void ArvoElaimenIka(int maxika)
        {
            ika = rng.Next(maxika);
        }
        /*public void Caset(int caserng)
        {
            x = rng.Next(caserng);
        }*/

        public void asetaElaimenIka()
        {
            Console.Write("Aseta Eläimen ikä: ");
            Int32.TryParse(Console.ReadLine(), out int Ika);

            try
            {
                this.ika = Ika;
                Console.ReadKey();
            }
            catch
            {
                Console.Write("Virhe, yritä uudelleen...");
                Console.ReadKey();
                Console.Clear();
            }

            /*if (Ika < 0)
            {
                Console.Write("Virhe, yritä uudelleen...");
                Console.ReadKey();
                Console.Clear();
                //System.Environment.Exit(1);
            }
            else
            {
                this.ika = Ika;
                Console.ReadKey();
            }*/
            Console.Clear();
        }

        public void asetaOnLihanSyoja(bool OnLihanSyoja = true)
        {
            this.OnLihanSyoja = OnLihanSyoja;
        }

        public void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine(ika);
            Console.WriteLine(nimi);
            Console.WriteLine(OnLihanSyoja);
        }

        public virtual void Aantele()
        {
            Console.WriteLine("Umph!");        
        }

       // public string Name { get; set; }
     

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
