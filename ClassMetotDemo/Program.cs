using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.musteriAdi = "Tarık";
            musteri1.musteriSoyadi = "Bayram";
            musteri1.musteriHesapNo = "123456";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musteriAdi = "Samed";
            musteri2.musteriSoyadi = "Adalı";
            musteri2.musteriHesapNo = "15316";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.musteriAdi = "Osman";
            musteri3.musteriSoyadi = "Türkmenoğlu";
            musteri3.musteriHesapNo = "18619874";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listeleme(musteriler);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

            Console.WriteLine("----------------------------------");

        }
    }
}
