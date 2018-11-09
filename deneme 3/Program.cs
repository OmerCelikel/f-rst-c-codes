using System;
// 1000 liraya kadar %10 vergi
// 1000 lira üzeri %20
// 10000 lira üzerinde de %30
namespace deneme_3
{
    class sum
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine("LUTFEN GELIRINIZI GIRINIZ");
            int gelir;

            string okunan = Console.ReadLine();
            gelir = int.Parse(okunan);

            //int gelir = int.Parse(Console.ReadLine());
            double vergi;
            if (gelir <= 1000)
            {
                vergi = gelir *0.1 ;
            }

            else if( gelir <= 10000)
            {
                vergi = (double)gelir * 0.2;
            }

            else 
            {
                vergi = (double)gelir * 0.3;
            }
            Console.WriteLine("vergi: " + vergi);
            
        }
    }
}
