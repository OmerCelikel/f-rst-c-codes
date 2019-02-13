using System;

namespace array_devam
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci sayıları

            int[] fib = new int[10];  // 10 terimli fibonacci yapacağız

            fib[0] = 1;
            fib[1] = 1;

            for(int i = 2; i<10; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2]; // ilk ikisini zaten verdil
                //o yüzden i-2 deb sıkıntı çıkmaz
            }
            
            //for(int i = 0; i<fib.Length; i++)
            foreach(int i in fib) // fib içinden i değerlerini al bastır
            {
                // Console.WriteLine(" "+fib[i]);
                Console.WriteLine(" " +i);
            }
            Console.ReadKey();
        }
    }
}
