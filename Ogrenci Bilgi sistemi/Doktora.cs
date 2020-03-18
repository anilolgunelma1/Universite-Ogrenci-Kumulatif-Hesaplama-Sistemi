using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ogrenci_Bilgi_sistemi
{
    class Doktora:Ogrenci
    {
     


        

        
        public string LisansOkul;
        public string LisansBolum;
        public string YuksekLisansOkul;
        public string YuksekLisansBolum;

        public Doktora( int OgrenciNo, string AdSoyad, string BolumAdı,string LisansOkul, string LisansBolum, string YuksekLisansOkul, string YuksekLisansBolum ) : base(OgrenciNo,AdSoyad,BolumAdı)
        {
            this.LisansOkul = LisansOkul;
            this.LisansBolum = LisansBolum;
            this.YuksekLisansOkul = YuksekLisansOkul;
            this.YuksekLisansBolum = YuksekLisansBolum;



        }

     
        

       
    }
}
