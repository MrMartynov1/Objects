using System;

namespace ElainLuokat
{
    public class Kissa2
    {
        public int ika;
        public string nimi;
        public int ikaKissa;

        public Kissa2() //konstruktori
        {
            // ika = 0;
            // nimi = "";
        }

        public Kissa2(int ika, string nimi) //parametrillinen konstruktori
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
        }

        
        public int Ika
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
        public string Name { get; set; }
    }

    public class Koira2
    {
        public int ika;
        public string nimi;
        public int ikaKoira;

        public Koira2() //konstruktori
        {
            // ika = 0;
            // nimi = "";
        }

        public Koira2(int ika, string nimi) //parametrillinen konstruktori
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public void asetaKoiranNimi(string nimi) //metodi
        {
            this.nimi = nimi;

        }

        public string palautaKoiranNimi()
        {
            return nimi;
        }

        public void asetaKoiranIka(int ika)
        {

            this.ika = ika;
        }

        public int palautaKoiranIka()
        {
            return ika;
        }


        public int Ika
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
        public string Name { get; set; }
    }
    //----------------------------

    public class Hevonen2
    {
        public int hevika;
        public string hevnimi;
        public int ikaHevonen;

        public Hevonen2() //konstruktori
        {
            // ika = 0;
            // nimi = "";
        }

        public Hevonen2(int ika, string nimi) //parametrillinen konstruktori
        {
            this.hevika = hevika;
            this.hevnimi = hevnimi;
        }

        public void asetaHevosenNimi(string nimi) //metodi
        {
            this.hevnimi = hevnimi;

        }

        public string palautaHevosenNimi()
        {
            return hevnimi;
        }

        public void asetaHevosenIka(int ika)
        {

            this.hevika = hevika;
        }

        public int palautaHevosenIka()
        {
            return hevika;
        }

    }

        //----------------------------

    public class Elain2
    {
        public int elika;
        public string elnimi;
        public int ikaElain;

        public Elain2() //konstruktori
        {
            // ika = 0;
            // nimi = "";
        }

        public Elain2(int ika, string nimi) //parametrillinen konstruktori
        {
            this.elika = ika;
            this.elnimi = nimi;
        }

        public void asetaElaimenNimi(string nimi) //metodi
        {
            this.elnimi = nimi;

        }

        public string palautaElaimenNimi()
        {
            return elnimi;
        }

        public void asetaElaimenIka(int ika)
        {

            this.elika = ika;
        }

        public int palautaElaimenIka()
        {
            return elika;
        }

        /*private bool onLihanSyoja()
        {

        }*/

        /*public string asetaOnLihanSyoja()
        {

        }*/

        /*public bool palautaOnLihanSyoja()
        {

        }*/
        /*
          4) Luo vain Elain-luokkaan uusi attribuutti, joka on kaikille eläimille yhteinen (muista private): 

      - bool onLihanSyoja 

 

          5) Tee funktiot (muista public) 

      - asetaOnLihanSyoja(<parametri>) 

      - bool palautaOnLihanSyoja() 
         */
    }

}
