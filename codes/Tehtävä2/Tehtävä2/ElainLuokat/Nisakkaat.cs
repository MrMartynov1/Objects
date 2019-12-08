using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    abstract public class Nisakkaat: Elain
    {
        private bool Syntyy;
        public void AsetaSyntyy(bool Syntyy = true)
        {
            this.Syntyy = Syntyy;
        }
        public void PrintAsetaSyntyy()
        {
            Console.WriteLine(Syntyy);
        }
    }
}
