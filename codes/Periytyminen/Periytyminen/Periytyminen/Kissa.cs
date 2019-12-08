using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    public class Kissa : Elain

    {

        public Kissa() : base ()
        {

        }

        public Kissa(int kissanika, string kissannimi) : base (kissanika, kissannimi)
        {
            base.Ika = kissanika;
            base.Nimi = kissannimi;


        }

        public void kehraa()
        {
            Console.Write("hrrrr");
        }

    }

    
}
