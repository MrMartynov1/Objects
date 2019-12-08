using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ika
{
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
}
