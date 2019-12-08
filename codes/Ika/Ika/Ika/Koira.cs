using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ika
{
    class Koira
    {
        
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

            /*
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
            */

            public void asetaKoiranNimi(string nimi) //metodi
            {
                this.kornimi = kornimi;

            }

            public string palautaKoiranNimi()
            {
                return kornimi;
            }

            public void asetaKoiranIka(int ika)
            {

                this.korika = korika;
            }

            public int palautaKoiranIka()
            {
                return korika;
            }

            public string Name { get; set; }
        

    }
}
