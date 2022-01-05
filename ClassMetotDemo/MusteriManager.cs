using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi + " adlı kullanıcı eklenmistir.");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi + " adlı kullanıcı silindi.");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.musteriAdi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.musteriSoyadi);
                Console.WriteLine("Müşteri Hesap No: " + musteri.musteriHesapNo);
                Console.WriteLine("------------------------");

            }
        }


    }
}