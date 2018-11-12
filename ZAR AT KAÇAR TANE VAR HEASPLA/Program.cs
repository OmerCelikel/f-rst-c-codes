using System;
// olasılık bulmacalar zar
namespace c__deneme_5
{
    class RollDie
    {
        static void Main()
        {
            Random randomNumbers = new Random();

            int frequency1 = 0 ;
            int frequency2 = 0 ;
            int frequency3 = 0 ;
            int frequency4 = 0 ;
            int frequency5 = 0 ;
            int frequency6 = 0 ;

            for (int roll = 1 ;roll <= 60000000; ++roll)
            {
                int face = randomNumbers.Next(1,7);

                switch ( face )
                {
                    case 1:
                    ++frequency1;                   
                    break;

                    case 2:
                    ++frequency2;                   
                    break;
                    case 3:
                    ++frequency3;                   
                    break;
                    case 4:
                    ++frequency4;                   
                    break;
                    case 5:
                    ++frequency5;                   
                    break;
                    case 6:
                    ++frequency6;                   
                    break;
                    
                }
            }
            
            Console.WriteLine($"1\t {frequency1}\n");
            Console.WriteLine($"2\t {frequency2}\n");
            Console.WriteLine($"3\t {frequency3}\n");
            Console.WriteLine($"4\t {frequency4}\n");
            Console.WriteLine($"5\t {frequency5}\n");
            Console.WriteLine($"6\t {frequency6}\n");
        }
    }
}
