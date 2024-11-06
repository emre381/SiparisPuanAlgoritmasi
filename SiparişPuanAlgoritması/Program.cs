using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Kullanici
    {
        public int KullaniciNo { get; set; }
        public int SiparisSayisi { get; set; }
        public int IadeSayisi { get; set; }
        public double PuanOrtalamasi { get; set; }
    }

    static void Main()
    {
        List<Kullanici> kullanicilar = new List<Kullanici>();
        VeriGirisi(kullanicilar);
        KullaniciIstatistikleri(kullanicilar);
        GenelIstatistikler(kullanicilar);
    }

    static void VeriGirisi(List<Kullanici> kullanicilar)
    {
        while (true)
        {
            Console.Write("Kullanıcı Numarası: ");
            int kullaniciNo = int.Parse(Console.ReadLine());

            int siparisSayisi;
            do
            {
                Console.Write("Sipariş Verdiği Ürün Sayısı: ");
                siparisSayisi = int.Parse(Console.ReadLine());
            } while (siparisSayisi < 0);

            int iadeSayisi;
            do
            {
                Console.Write("İade Ettiği Ürün Sayısı: ");
                iadeSayisi = int.Parse(Console.ReadLine());
            } while (iadeSayisi < 0 || iadeSayisi > siparisSayisi);

            double puanOrtalamasi;
            do
            {
                Console.Write("Verdiği Puanların Ortalaması (1-5): ");
                puanOrtalamasi = double.Parse(Console.ReadLine());
            } while (puanOrtalamasi < 1 || puanOrtalamasi > 5);

            kullanicilar.Add(new Kullanici
            {
                KullaniciNo = kullaniciNo,
                SiparisSayisi = siparisSayisi,
                IadeSayisi = iadeSayisi,
                PuanOrtalamasi = puanOrtalamasi
            });

            Console.Write("Başka kullanıcı var mı? (e/E/h/H): ");
            string devam = Console.ReadLine().ToLower();
            if (devam == "h") break;
        }
    }

    static void KullaniciIstatistikleri(List<Kullanici> kullanicilar)
    {
        Console.WriteLine("\nKullanıcı Bazlı İstatistikler:");
        foreach (var kullanici in kullanicilar)
        {
            double satinAlmaOrani = (double)(kullanici.SiparisSayisi - kullanici.IadeSayisi) / kullanici.SiparisSayisi * 100;
            Console.WriteLine($"Kullanıcı No: {kullanici.KullaniciNo}, Satın Alma Oranı: %{satinAlmaOrani:F2}, Verdiği Puan Ortalaması: {kullanici.PuanOrtalamasi:F2}");

            if (kullanici.PuanOrtalamasi >= 4)
            {
                Console.WriteLine($"4 veya 5 puan verdikleri için satın alma oranı: %{satinAlmaOrani:F2}");
            }
        }
    }

    static void GenelIstatistikler(List<Kullanici> kullanicilar)
    {
        Console.WriteLine("\nGenel İstatistikler:");
        double ortalamaSatinAlma = kullanicilar.Average(k => k.SiparisSayisi - k.IadeSayisi);
        Console.WriteLine($"Kullanıcı Başına Ortalama Satın Alınan Ürün Sayısı: {ortalamaSatinAlma:F2}");

        double iadeOrani = kullanicilar.Count(k => k.IadeSayisi > 0) / (double)kullanicilar.Count * 100;
        Console.WriteLine($"En az bir ürün iade eden kullanıcı oranı: %{iadeOrani:F2}");

        double hicBesVermeyenOrani = kullanicilar.Count(k => k.PuanOrtalamasi < 5) / (double)kullanicilar.Count * 100;
        Console.WriteLine($"Hiç 5 puan vermeyen kullanıcı oranı: %{hicBesVermeyenOrani:F2}");

        double puanOrtalamasiDusukOrani = kullanicilar.Count(k => k.PuanOrtalamasi < 2) / (double)kullanicilar.Count * 100;
        Console.WriteLine($"Puan ortalaması 2’den düşük olan kullanıcı oranı: %{puanOrtalamasiDusukOrani:F2}");

        var enCokUrunAlan = kullanicilar.OrderByDescending(k => k.SiparisSayisi).First();
        Console.WriteLine($"En çok ürün alan kullanıcı no: {enCokUrunAlan.KullaniciNo}, Satın Aldığı Ürün Sayısı: {enCokUrunAlan.SiparisSayisi - enCokUrunAlan.IadeSayisi}, İade Ettiği Ürün Sayısı: {enCokUrunAlan.IadeSayisi}, Verdiği Puan Ortalaması: {enCokUrunAlan.PuanOrtalamasi:F2}");
    }
}
