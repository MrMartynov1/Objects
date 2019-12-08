using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Pennut
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kissa katti = new Kissa();
            Console.WriteLine("Kissa luotu.");
            //Console.ReadKey();
            katti.nimi = string.Format("Kissa #1");
            katti.ArvoElaimenIka(15);
            katti.asetaOnLihanSyoja(false);
            katti.Print();
       
            katti.PrintAsetaSyntyy();
          
            katti.LisaaPentu("miuku");
            katti.LisaaPentu("mauku", 5);
            katti.LisaaPentu("mouku");
           // return pennut.Count;
            Console.Write("");

            foreach (Kissa kissanpentu in katti.pennut)
            {
                kissanpentu.Print();
                Console.Write("Emo: ");
                Console.WriteLine(kissanpentu.Emo.nimi);
                kissanpentu.Aantele();
                kissanpentu.PrintAsetaSyntyy();
            }
            Console.ReadLine();
        }
    }
}
