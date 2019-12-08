using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ika
{
    class Hevonen
    {
            public int hevika;
            public string hevnimi;
            public int ikaHevonen;

            public Hevonen() //konstruktori
            {
                // ika = 0;
                // nimi = "";
            }

            public Hevonen(int ika, string nimi) //parametrillinen konstruktori
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

            //----------------------------



        
    }
}
