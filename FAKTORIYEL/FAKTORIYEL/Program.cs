using System;

namespace FAKTORIYEL
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long counter = 0; counter<=10; ++counter)
            {
                Console.WriteLine($"{counter}! = {Factorial(counter)}");
            }
            Console.ReadKey();
        }

        static long Factorial(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
            
        }
            
        
    }
}
