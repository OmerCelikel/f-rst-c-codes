using System;

namespace object_metot_şirket_çalışanlar
{

    class calisan
    {
        string isim { get;  }
        //int maas { get; } maas oranı yapmadan buydu
        public double maas { get; set; }
        public void zam(double oran)
        {
            maas = maas * (1 + oran);
        }
        public calisan(string isim, int maas)
        {
            this.isim = isim;
            this.maas = maas;
        }

        override public string ToString() //yukardan gelenin üstünden basacak override
        {
            return "calisanin ismi: " + isim + "  "+ "maasi: " +maas;
        }    
    } 

    class Program
    {
        // ZAM yaptıracak bi metot yapacağız
        static void zam(calisan []s, double oran)
        {
            for(int i = 0; i < s.Length; i++)
            {
                s[i].zam(oran);
            }
        }
        
        static void ekranaBas(calisan[] s)
        {
            foreach(calisan x in s)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            calisan[] sirket = new calisan[5];
            sirket[0] = new calisan("ali", 100);
            sirket[1] = new calisan("ayse", 300);
            sirket[2] = new calisan("veli", 4100);
            sirket[3] = new calisan("fatma", 5000);
            sirket[4] = new calisan("ahmet", 150);
            //sirket[5] = new calisan("ahmet", 150); // 5 olmaz ama 0 1 2 3 4 olacağı için 5. eleman yok
            // try catch yapmaya çalışacağız 

            Console.WriteLine("2018 MAASLARI");
            ekranaBas(sirket);
            Console.WriteLine("ENTER A BAS DİĞER YIL İÇİN YENİ MAASLARI GÖR");
            Console.ReadKey();
            Console.WriteLine("2019 MAASLARI");
            zam(sirket, 0.2); //zam için gönlümüzden kopan
            ekranaBas(sirket);
            Console.ReadKey();
            Console.WriteLine("2020 MAASLARI");
            zam(sirket, 0.1);
            ekranaBas(sirket);
            Console.ReadKey();
        }     
    }
}
