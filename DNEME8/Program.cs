using System;
// 0 a 0 --- 1 e 1 --- 2 ye 2--- 3 e 3 --- toplamı

namespace DNEME8
{
    class Program
    {
        static void Main(string[] args)
        {
           int [,] a = {{1,2,3,4},
                        {4,66,32,43},
                        {32,43,66,54},
                        {324, 497,548,032}};
            int toplam = 0 ;
            for (int satir = 0 ; satir < a.GetLength(0) ; satir++)
            {
                for(int sutun = 0; sutun < a.GetLength(1); sutun++)
                {
                    // satır sütüna eşit olduğunda topllama yapacağız
                    if(satir==sutun)
                    toplam = toplam + a[satir , sutun];    
                }
            }

            Console.Write(toplam);
        }
    }
}
