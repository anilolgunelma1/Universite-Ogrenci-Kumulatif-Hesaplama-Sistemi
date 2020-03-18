using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ogrenci_Bilgi_sistemi
{
    class Lisans : Ogrenci
    {

        Dictionary<double, Ogrenci> ogrencilist = new Dictionary<double, Ogrenci>();

        

        public Lisans(int OgrenciNo, string AdSoyad, string BolumAdı) : base(OgrenciNo, AdSoyad, BolumAdı)
        {

        }



       
    }
}

