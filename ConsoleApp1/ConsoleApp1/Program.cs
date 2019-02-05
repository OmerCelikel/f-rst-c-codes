using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string isim = "omer";
            //Console.WriteLine($"Kıme Hosgeldin Diyelim: " + $" {isim}");
            // stringi {isim} yaparak başına $ işareti koyarak koymuş olduk

            string ad;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Merhaba: " + ad);
            Console.ReadKey();
            Console.WriteLine("selam proglamalama");
            //Console.ReadKey(); // Direk kapanıp açılmasını engellemek için

            int n1;
            int n2;
            int n3;
            int sum;

            Console.WriteLine(" 3 SAYI GIRIP SONUCU TOPLAYACAĞIM");
            Console.WriteLine("LÜTFEN İLK SAYIYI GIRINIZ");
            n1 = int.Parse(Console.ReadLine()); // Parse leyip readline ile kullanıcıdan bir sayı aloyoruz
            Console.WriteLine("LUTFEN IKINCI SAYIYI GIRINIZ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("LUTFEN UCUNCU SAYIYI GIRINIZ");
            n3 = int.Parse(Console.ReadLine());

            sum = n1 + n2 + n3;
            Console.WriteLine("TESEKKURLER SONUCUNUZ =" + sum);
            Console.ReadKey();

        }
    }
}
