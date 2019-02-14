using System;

namespace çok_boyutlu_diziler
{
    class Program
    {


        static int diyagonTopla(int[,] a)
        {

            int toplam = 0;
            for (int satir = 0; satir <a.GetLength(0); satir++)
            {
                for( int sutun = 0; sutun < a.GetLength(1); sutun++)
                {
                    if(satir == sutun)// yani 0 ın 0 1 dir ---> 1 in 1 i 66 
                    toplam = toplam + a[satir, sutun];
                }
            }

            Console.WriteLine("metottaki toplam: "+ toplam);
            return toplam;
            
        }
        static void Main(string[] args)
        {
            int[,] a = {{1,2,3,4 },
                        {4,66,32,43 },
                        {32,43,66,54 },
                        {324,497,548,032 } }; // diyegon dediği 1. satırdan 1. eleman 
                                              // 2. satırdan 2. elaman
                                              // 3. satırdan 3. elamanı alacağoz TOPLAYACAĞIZ




            // 1. si için
            /*for (int satir = 0; satir <a.GetLength(0); satir++)
            {
                for( int sutun = 0; sutun < a.GetLength(1); sutun++)
                {
                    if(satir == sutun)// yani 0 ın 0 1 dir ---> 1 in 1 i 66 
                    toplam = toplam + a[satir, sutun];
                }
            }

            Console.WriteLine(toplam);
            Console.ReadKey();*/

            Console.WriteLine(diyagonTopla(a));
            Console.ReadKey();
        }

    }
}
