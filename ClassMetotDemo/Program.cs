using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Mert";
            musteri1.Sehir = "İstanbul";
            musteri1.Id = 100;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Hakan";
            musteri2.Soyadi = "Demir";
            musteri2.Sehir = "Erzincan";
            musteri2.Id = 200;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Eray";
            musteri3.Soyadi = "Pamuk";
            musteri3.Sehir = "Sivas";
            musteri3.Id = 300;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------");

            musteriManager.Silme(musteri3);

            Console.WriteLine("-------------------");

            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            musteriManager.Listeleme(musteri3);
        }
    }
}
