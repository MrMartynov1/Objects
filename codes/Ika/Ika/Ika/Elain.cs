using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ika
{
    class Elain
    {
        public int Eluika;
        public string Elunimi;
        public int ikaElain;

        public Elain() //konstruktori
        {
            
        }

        public Elain(int ika, string nimi) //parametrillinen konstruktori
        {
            this.Eluika = Eluika;
            this.Elunimi = Elunimi;
        }

        public void asetaElaimenNimi(string nimi) //metodi
        {
            this.Elunimi = Elunimi;

        }

        public string palautaElaimenNimi()
        {
            return Elunimi;
        }

        public void asetaElaimenIka(int ika)
        {
            Console.WriteLine("Aseta Eläimen ikä: ");
            Int32.TryParse(Console.ReadLine(), out ikaElain);

            
            if (ikaElain < 0)
            {
                Console.WriteLine("Virhe yritä uudelleen...");
                Console.ReadKey();
                Console.Clear();
                System.Environment.Exit(1);
            }
            else
            {
                this.Eluika = ikaElain;
            }
            Console.ReadKey();
            Console.Clear();
        }

        public int palautaElaimenIka()
        {
            return Eluika;
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
    }
}
