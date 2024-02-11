
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer("Ahmet");
            SelamVer("Alper");
            SelamVer();

            int sonuc = Topla(3, 5);

            // Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Alper";
            ogrenciler[1] = "Tugba";
            ogrenciler[2] = "Caner";
            //ogrenciler[3] = "Selim";

            ogrenciler = new string[4];
            ogrenciler[3] = "Selim";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Mersin" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";

            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;

            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);

            Person person1 = new Person();
            person1.FirstName = "ALPER";
            person1.LastName = "DOĞAN";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Tuğba";

            foreach (string sehir in sehirler1 )
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 0, int sayi2 = 0)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }


        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000; // db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Alper";
            string soyad = "Dogan";
            int dogumYili = 1999;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
