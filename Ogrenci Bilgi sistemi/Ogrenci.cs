using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ogrenci_Bilgi_sistemi
{
    abstract class Ogrenci
    {

        private int OgrenciNo;
        private string AdSoyad;
        private string BolumAdı;
       
        

        public int OGRENCİNO
        {
            get { return OgrenciNo; }
            set { OgrenciNo = value; }

        }
        public string ADSOYAD
        {
            get { return AdSoyad; }
            set { AdSoyad = value; }

        }
        public string BOLUMADI
        {
            get { return BolumAdı; }
            set { BolumAdı = value; }

        }
        public Ogrenci( int No,string AdSoyad,string Bolum)
        {
            this.OGRENCİNO = No;
            this.ADSOYAD = AdSoyad;
            this.BOLUMADI = Bolum;

        }


      

     


    }


  
    
    
   



}
