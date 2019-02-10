using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)//statici n içinde statik tanımlayabiliriz
        {
            /*basit zar atma

            Random randomNumbers = new Random();

            for (int counter = 1; counter <=6; ++counter) //6 tane zar atacak
            {
                int face = randomNumbers.Next(1, 7);
                Console.Write($"{face}  ");
            }

            Console.WriteLine();
            Console.ReadKey(); */

            Random randomNumbers = new Random();

            int sayısı1 = 0;
            int sayısı2 = 0;
            int sayısı3 = 0;
            int sayısı4 = 0;
            int sayısı5 = 0;
            int sayısı6 = 0;

            for (int roll = 1; roll <=60000000; ++roll)
            {
                int face = randomNumbers.Next(1,7);

                switch (face)
                {
                    case 1:
                        ++sayısı1;
                        break;
                    case 2:
                        ++sayısı2;
                        break;
                    case 3:
                        ++sayısı3;
                        break;
                    case 4:
                        ++sayısı4;
                        break;
                    case 5:
                        ++sayısı5;
                        break;
                    case 6:
                        ++sayısı6;
                        break;
                }
            }

            Console.WriteLine("Zardaki sayı\tkaç kere olduğu");
            Console.WriteLine($"1\t         {sayısı1}");// \t hizzalamaya yarar
            Console.WriteLine($"2\t         {sayısı2}");
            Console.WriteLine($"3\t         {sayısı3}");
            Console.WriteLine($"4\t         {sayısı4}");
            Console.WriteLine($"5\t         {sayısı5}");
            Console.WriteLine($"6\t         {sayısı6}");

            Console.ReadKey();

        }
    }
}
