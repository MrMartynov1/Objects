using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public class Linnut : Elain
    {
        private bool Lentaa;
        public void AsetaLentaa(bool Lentaa = true)
        {
            this.Lentaa = Lentaa;
        }

        public void PrintAsetaLentaa()
        {
            Console.WriteLine(Lentaa);
        }
    }
}
