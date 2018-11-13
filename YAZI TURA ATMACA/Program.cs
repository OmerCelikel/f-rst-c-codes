using System;

namespace deneme_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0 ; i <10 ; i++)
            {
                int yazıtura = r.Next(1,3);

                if(yazıtura==1)
                    Console.WriteLine("YAZI");
                else 
                    Console.WriteLine("TURA");


            }    
        }
    }
}
