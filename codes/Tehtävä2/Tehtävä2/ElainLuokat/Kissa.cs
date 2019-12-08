using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa : Nisakkaat

    {
        private Kissa emo;

        public void kehraa()
        {
            Console.Write("hrrrr");
        }
        
        public override void Aantele() => Console.WriteLine(" Miau!");

        public List<Kissa> pennut = new List<Kissa>();

        public Kissa Emo { get => emo; set => emo = value; }

        public int LisaaPentu(string nimi,int ika = 0)
        {
            for (int i = 0; i < 1; i++)
            {
                Kissa kissanpentu = new Kissa();
                Console.WriteLine("Kissapentu luotu.");
                //Console.ReadKey();
                kissanpentu.nimi = nimi;
                kissanpentu.asetaOnLihanSyoja(false);
                kissanpentu.ika = ika;
                kissanpentu.Emo = this;
                kissanpentu.AsetaSyntyy();
                pennut.Add(kissanpentu);
                Console.Write("");
                Console.ReadKey();
            }
            foreach (Kissa kissanpentu in pennut)
            {
                kissanpentu.Print();
                kissanpentu.Aantele();
                kissanpentu.PrintAsetaSyntyy();
            }
            return pennut.Count;
        }

    }


}
