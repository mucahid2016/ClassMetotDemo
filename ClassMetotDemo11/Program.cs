using System;

namespace ClassMetotDemo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ertan";
            musteri1.Soyad = "Balaban";
            musteri1.Email = "ertanbalaban@gmail.com";
            musteri1.Id = 1234;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ege";
            musteri2.Soyad = "Cinel";
            musteri2.Email = "egecinel@hotmail.com";
            musteri2.Id = 159753;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Mücahid";
            musteri3.Soyad = "Ekmekçi";
            musteri3.Email = "mucahid@gmail.com";
            musteri3.Id = 987654;
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Email);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("**********METOTLAR**********");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("         ***********          ");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            Console.WriteLine("          ************       ");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            Console.WriteLine("++++++++++++BİTTİ+++++++");
            Console.WriteLine("       ");
        }
    }
}
