using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " : " + musteri.Adi + " " + musteri.Soyadi + " : " + musteri.Sehir + " Eklendi ");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " : " + musteri.Adi + " " + musteri.Soyadi + " : " + musteri.Sehir +" Silindi");
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " : " + musteri.Adi + " " + musteri.Soyadi + " : " + musteri.Sehir + " Listelendi");
        }
    }
}
