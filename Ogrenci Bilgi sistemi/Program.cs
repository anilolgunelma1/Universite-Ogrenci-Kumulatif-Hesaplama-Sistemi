using System;
using System.Collections.Generic;
using System.Collections;

namespace Ogrenci_Bilgi_sistemi
{
    class Program
    {
        static void Main(string[] args)
        { int deger ,goster;

           



            Console.WriteLine(" Lisans Ogrencisi Bilgerini Girmek İçin 1'e Basınız:");
            Console.WriteLine("YuksekLisans Ogrencisi Bılgilerini Girmek  İçin 2'ye basınız:");
            Console.WriteLine("Doktora Ogrencisi Bilgilerini Girmek İçin 3'e basınız :");
            deger = Convert.ToInt32(Console.ReadLine().ToString());
            
            switch(deger)
            {


                case 1:
                    Console.WriteLine("Sirasiyla ogrno,adsoyad,bolum ");
                    Ogrenci lisans = new Lisans(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

                    Ders ders = new Ders();
                    Console.WriteLine("Ders Sayısını Giriniz");
                    int c = Convert.ToInt32(Console.ReadLine());
                    ders.DersEkle(c);
                    ders.KumulatıfHesap();


                    for (int i = 0; i < c; i++)
                    {
                        Console.WriteLine("Ders Bilgileri");
                        Console.WriteLine(ders.kodlar[i]);
                        Console.WriteLine(ders.adlar[i]);
                        Console.WriteLine(ders.notlar[i]);
                        Console.WriteLine(ders.aktsler[i]);
                    }



                    break;

                case 2:

                    Console.WriteLine("Sirasiyla ogrno,adsoyad,bolum,lisansokul,lisansbolum");
                    Ogrenci yuksek = new YuksekLisans(int.Parse(Console.ReadLine()),Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    Ders ders1 = new Ders();
                    Console.WriteLine("Ders Sayısını Giriniz");
                    int l = Convert.ToInt32(Console.ReadLine());
                    ders1.DersEkle(l);
                    ders1.KumulatıfHesap();
                    break;

                case 3:

                    Console.WriteLine("Sirasiyla  ogrno,adsoyad,bolum,lisansokul,lisansbolum ,yukseklisansokul ,yukseklisansbolum");
                    Ogrenci doktora = new Doktora(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    Ders ders2= new Ders();
                    Console.WriteLine("Ders Sayısını Giriniz");
                    int m = Convert.ToInt32(Console.ReadLine());
                    ders2.DersEkle(m);
                    ders2.KumulatıfHesap();





                    break;
                default: Console.WriteLine("Yanlış Bir Tuşlama Yaptınız");
                    break;
            }
        }
    }
}
