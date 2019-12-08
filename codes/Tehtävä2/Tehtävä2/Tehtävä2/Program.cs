using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtävä2
{
    class Program
    {

        static void Main(string[] args)
        {
            
            ElainLuokat.Kissa2 Kissa1 = new ElainLuokat.Kissa2();
            Kissa1.nimi = "Pekka";
            Console.Write(Kissa1.nimi);
            Console.ReadKey();
            Console.Clear();
            
            Kissa1.asetaKissanNimi("Hermanni");
            Kissa1.asetaKissanIka(5);

            Kissa1.palautaKissanNimi();
            Kissa1.palautaKissanIka();
            Console.ReadKey();
            Console.Clear();


            ElainLuokat.Kissa2 Kissa2 = new ElainLuokat.Kissa2();
            Console.WriteLine("Kissa luotu.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Anna nimi: ");
            Kissa2.nimi = Console.ReadLine();

            if (Kissa2.nimi == "Hilda" || Kissa2.nimi == "HILDA" || Kissa2.nimi == "hilda" || Kissa2.nimi == "HiLDA" || Kissa2.nimi == "hILDA" || Kissa2.nimi == "HIlDA" || Kissa2.nimi == "HILdA" || Kissa2.nimi == "HILDa" || Kissa2.nimi == "hIlda" || Kissa2.nimi == "hiLda" || Kissa2.nimi == "hilDa" || Kissa2.nimi == "hildA")
            {
                Console.WriteLine("Virhe. Yritä uudelleen.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                Kissa2.nimi = Console.ReadLine();
            }

            Console.Write("Anna ika: ");
            int ikaKissa2;
            Int32.TryParse(Console.ReadLine(), out ikaKissa2);
            

            if (!(Kissa2.ika < 0))
            {
                Kissa2.asetaKissanIka(ikaKissa2);
            }
            else
            {
                Console.WriteLine("Virhe. Yritä uudelleen.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }

            Kissa2.palautaKissanNimi();
            Kissa2.palautaKissanIka();
            Console.ReadKey();
            Console.Clear();

            //-----------------------------

            Koira2 Koira1 = new Koira2();
            Koira1.nimi = "Haukkuli";
            Console.Write(Koira1.nimi);
            Console.ReadKey();
            Console.Clear();

            Koira1.asetaKoiranNimi("Eemeli");
            Koira1.asetaKoiranIka(5);

            Koira1.palautaKoiranNimi();
            Koira1.palautaKoiranIka();
            Console.ReadKey();
            Console.Clear();


            Koira2 Koira2 = new Koira2();
            Console.WriteLine("Koira luotu.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Anna nimi: ");
            Koira2.nimi = Console.ReadLine();

            if (Koira2.nimi == "Musti" || Koira2.nimi == "MUSTI" || Koira2.nimi == "musti" || Koira2.nimi == "MuSTI" || Koira2.nimi == "mUSTI" || Koira2.nimi == "MUsTI" || Koira2.nimi == "MUStI" || Koira2.nimi == "MUSTi" || Koira2.nimi == "mUsti" || Koira2.nimi == "muSti" || Koira2.nimi == "musTi" || Koira2.nimi == "mustI")
            {
                Console.WriteLine("Virhe. Yritä uudelleen.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                Koira2.nimi = Console.ReadLine();
            }

            Console.Write("Anna ika: ");
            int ikaKoira2;
            Int32.TryParse(Console.ReadLine(), out ikaKoira2);


            if (!(Koira2.ika < 0))
            {
                Koira2.asetaKoiranIka(ikaKoira2);
            }
            else
            {
                Console.WriteLine("Virhe. Yritä uudelleen.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }

            Koira2.palautaKoiranNimi();
            Koira2.palautaKoiranIka();
            Console.ReadKey();
            Console.Clear();

            //----------------------------------

            ElainLuokat.Elain2 Elain1 = new ElainLuokat.Elain2();
            Elain1.elnimi = "Haukkuli";
            Console.Write(Elain1.elnimi);
            Console.ReadKey();
            Console.Clear();

            Elain1.asetaElaimenNimi("Hemuli");
            Elain1.asetaElaimenIka(5);

            Elain1.palautaElaimenNimi();
            Elain1.palautaElaimenIka();
            Console.ReadKey();
            Console.Clear();


            ElainLuokat.Elain2 Elain2 = new ElainLuokat.Elain2();
            Console.WriteLine("Eläin luotu.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Anna nimi: ");
            Elain2.elnimi = Console.ReadLine();

            Console.Write("Anna ika: ");
            int ikaelain2;
            Int32.TryParse(Console.ReadLine(), out ikaelain2);


            if (!(Elain2.elika < 0))
            {
                Elain2.asetaElaimenIka(ikaelain2);
            }
            else
            {
                Console.WriteLine("Virhe. Yritä uudelleen.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }

            Elain2.palautaElaimenNimi();
            Elain2.palautaElaimenIka();
            Console.ReadKey();
            Console.Clear();

        }
    }
}
