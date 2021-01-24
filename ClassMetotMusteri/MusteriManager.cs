using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotMusteri
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + ".... Yeni müşteri kaydı tamamlandı ----- bugün: 15:05");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + ".... Müşteri silme işlemi tamamlandı ----- bugün: 16:22");
        }


    }
}
