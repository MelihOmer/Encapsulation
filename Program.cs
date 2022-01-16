using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 123;
            ogrenci.Sinif = 3;
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriGetir();


            Ogrenci ogrenci1 = new Ogrenci(321,1,"Kamar","Melih Ömer");
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriGetir();


        }

    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get {return isim;}
            set {isim = value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get {return sinif;}
            set 
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Sınıf En Düşük 1 Olmalıdır.");
                    sinif = 1;
                }
                else
                    sinif = value;
            } 

        }

        public Ogrenci(int ogrenciNo, int sinif, string soyisim, string ısim)
        {
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
            Soyisim = soyisim;
            Isim = ısim;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriGetir()
        {
            System.Console.WriteLine("*** Öğrenci Bilgileri ***");
            System.Console.WriteLine("Öğrenci Adı   :{0}",this.Isim);
            System.Console.WriteLine("Öğrenci SoyAdı   :{0}",this.Soyisim);
            System.Console.WriteLine("Öğrenci No   :{0}",this.OgrenciNo);
            System.Console.WriteLine("Öğrenci Sınıfı   :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif +=1;
        }
        public void SinifDusur()
        {
            this.Sinif -=1;
        }


    }

}
