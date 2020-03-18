using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ogrenci_Bilgi_sistemi
{
    class YuksekLisans:Ogrenci
    {

       
        


        
        public string LisansOkulu;
        public string LisansBolumu;

       


        public YuksekLisans(int OgrenciNo,string AdSoyad,string BolumAdı,string LisansOkulu, string LisansBolumu) :base(OgrenciNo,AdSoyad,BolumAdı)
        {
            this.LisansOkulu = LisansOkulu;
            this.LisansBolumu = LisansBolumu;

        }

       
    }
}
