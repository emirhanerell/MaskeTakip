using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();
            vatandas.Ad = "Emirhan";
            SelamVer(isim: "Emirhan");

            int sonuc = Topla(sayi1: 5, sayi2: 6);

            List<string> ogrencilerr = new List<string>();

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };

            foreach (string s in sehirler1)
            {
                Console.WriteLine(s);
            }


            // -------- MaskeTakip projesi kodları --------

            Person person1 = new Person();
            person1.FirstName = "Emirhan";
            person1.LastName = "EREL";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Eda";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            
        }
        static void SelamVer(string isim)
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString());
            return sonuc;
        }       
    }
  
    // pascal casing 
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
    }
   
}
