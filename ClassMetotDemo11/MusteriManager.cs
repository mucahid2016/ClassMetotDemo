using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo11
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müsteri Eklendi :  " + musteri.Ad + "  " + musteri.Soyad);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Bravo Email'iniz listeleniyor:  " + musteri.Email);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Şahane Id'niz siliniyor:  " + musteri.Id);
        }
    }
}
