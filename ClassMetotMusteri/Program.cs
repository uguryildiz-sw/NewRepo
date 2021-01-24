using System;

namespace ClassMetotMusteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------- Müşteri Listesi --------------------------");
            Musteri musteri1 = new Musteri();
            musteri1.Id = "4641616511";
            musteri1.Adi = "James Mont";
            musteri1.Yasi = 22;
            musteri1.PhoneNumber = 35454545;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "80056404466";
            musteri2.Adi = "Elizabeth Katarina";
            musteri2.Yasi = 22;
            musteri2.PhoneNumber = 55524221;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "1212806554";
            musteri3.Adi = "Uğur Alp Yıldız";
            musteri3.Yasi = 18;
            musteri3.PhoneNumber = 53822454;

            Musteri musteri4 = new Musteri();
            musteri4.Id = "10024205424";
            musteri4.Adi = "Engin Demiroğ";
            musteri4.Yasi = 36;
            musteri4.PhoneNumber = 5328454;

            Musteri musteri5 = new Musteri();
            musteri5.Id = "15115742012";
            musteri5.Adi = "Miraç Karacabey";
            musteri5.Yasi = 23;
            musteri5.PhoneNumber = 548454;

            Musteri musteri6 = new Musteri();
            musteri6.Id = "15154872012";
            musteri6.Adi = "Adem Soydan";
            musteri6.Yasi = 17;
            musteri6.PhoneNumber = 5538454;

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2,musteri3,musteri4,musteri5,musteri6
            };

            foreach (Musteri musteri in musteriler) 
            {
               
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşteri Adi : " + musteri.Adi);
                Console.WriteLine("Müşteri Yaşı : " + musteri.Yasi);
                Console.WriteLine("Müşteri Telefon Numarası : " + musteri.PhoneNumber);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------Müşteri Ekleme----------------------------");
            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);
            Console.WriteLine("");
            Console.WriteLine("-------------------Müşteri Silme----------------------------");
            MusteriManager musteriManagerSilme = new MusteriManager();

            musteriManager.Sil(musteri6);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
