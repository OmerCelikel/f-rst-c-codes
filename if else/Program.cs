using System;
// 1000 liraya %10 
// 1000 lira üzerine % 20 vergi
// 10.000 üzerine de %30 vergi alacağız
// toplam vergiyi de e n sona bastırdık

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelir;

            double toplamVergi = 0;

            Console.WriteLine("VERGİ KURALI");
            Console.WriteLine("1.000tl ye kadar %10");
            Console.WriteLine("1.000tl üstü %20");
            Console.WriteLine("10.000tl üstü %30");
            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                
                
                Console.WriteLine("LÜTFEN "+  i+ ". KİŞİNİN GELİRİNİZİ GİRİNİZ");


                string okunan = Console.ReadLine(); // girileni stringe çevirdil
                gelir = int.Parse(okunan); // sonra bunu int e çevirdik NORMALDE klavyeden okunan dizgiymiş
                                           // int gelir = int.Parse(Console.ReadLine()); yapılabilirdi

                double vergi; // int olmaz 875 çarparsak küsüratlı olacak

                if (gelir <= 1000)
                {
                    vergi = (double)gelir * 0.1; // çarpmanın nedeni yüzdeliğe göre alıyoruz vergiyi
                                                 // normalde bunda hata verecek çünkü 875 i çevirirsek tam sayı olmayacak double kullanacağız   
                }

                else if (gelir <= 10000)
                {
                    vergi = (double)gelir * 0.2; // %20vergi aldık
                }

                else
                {
                    vergi = (double)gelir * 0.3;
                }
                toplamVergi += vergi; // toplamVergi = toplamVergi + vergi
                Console.WriteLine(i+". kişinin vergisi =" + vergi);
                //Console.ReadKey();  çok enter a basmamak için
            }
            Console.WriteLine("Toplam vergi: " + toplamVergi);
            Console.ReadKey();
        }
    }
}
