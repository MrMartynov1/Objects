using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat

{
    public class Koira: Nisakkaat
    {
        public override void Aantele() => Console.WriteLine("Hau!");
        
        /*
        public int korika;
        public string kornimi;
        public int ikaKoira;

        public Koira() //konstruktori
        {
            // ika = 0;
            // nimi = "";
        }

        public Koira(int korika, string nimi) //parametrillinen konstruktori
        {
            this.korika = korika;
            this.kornimi = kornimi;
        }

        
        public byte Ika
        {
            get
            {
                return ika;
            }

            set
            {
                ika = value;
            }
        }
    //    */

        //    public void asetaKoiranNimi(string nimi) //metodi
        //    {
        //        this.kornimi = kornimi;

        //    }

        //    public string palautaKoiranNimi()
        //    {
        //        return kornimi;
        //    }

        //    public void asetaKoiranIka(int ika)
        //    {

        //        this.korika = korika;
        //    }

        //    public int palautaKoiranIka()
        //    {
        //        return korika;
        //    }

        //    public string Name { get; set; }
        //}

        /*
        class Kissa
        {
            public int ika;
            public string nimi;
            public int ikaKissa;

            public Kissa() //konstruktori
            {
               // ika = 0;
               // nimi = "";
            }

            public Kissa(int ika, string nimi) //parametrillinen konstruktori
            {
                this.ika = ika;
                this.nimi = nimi;
            }

            public void asetaKissanNimi(string nimi) //metodi
            {
                this.nimi = nimi;

            }

            public string palautaKissanNimi()
            {
                return nimi;
            }

            public void asetaKissanIka(int ika)
            {

                this.ika = ika;
            }

            public int palautaKissanIka()
            {
                return ika;
            }*/
    }

}
