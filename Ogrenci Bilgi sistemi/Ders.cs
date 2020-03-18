using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ogrenci_Bilgi_sistemi
{
    class Ders
    {

       public List<string> kodlar = new List<string>();
      public  List<string> adlar = new List<string>();
       public List<double> aktsler = new List<double>();
     public   List<double> notlar = new List<double>();

        public double BaşarıNotu { get; set; }
        public double Akts { get; set; }
        public string DersAdı { get; set; }
        public string DersKodu { get; set; }

        public void DersEkle(int c)
        {
            
            for (int i = 0; i < c; i++)
            {


                try
                {
                    Console.WriteLine("Ders Kodunu Giriniz:");
                    DersKodu = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ders Adını Giriniz:");
                    DersAdı = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ders AKTSİNİ Giriniz:");
                    Akts = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ders Notunu Giriniz:");
                    BaşarıNotu = Convert.ToDouble(Console.ReadLine());

                    adlar.Add(DersAdı);
                    kodlar.Add(DersKodu);
                    aktsler.Add(Akts);
                    notlar.Add(BaşarıNotu);

                }
                catch (Exception e)
                {
                 Console.WriteLine("Hatalı boş bırakmayınız: ");
                }


             


            }


        }
        public void KumulatıfHesap(double ects=5)
        {
            double kbn = 0;
           
            double toplamKredi = 0;
            for (int i = 0; i < aktsler.Count; i++)
            {
                kbn += aktsler[i] * notlar[i];
                toplamKredi += aktsler[i];
              
            }
            kbn /= toplamKredi;

            Console.WriteLine("Kumulatıf Notunuz:");
            Console.WriteLine( kbn);

        }
    
       


    }
}

