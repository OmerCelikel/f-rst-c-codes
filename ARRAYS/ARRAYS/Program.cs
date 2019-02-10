using System;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[5]; // array adlı dizinin 5 değeri var

           // int[] array2 = { 32, 27, 64, 18, 95 }; // new int demedik çünkü değerlerini yazmış olduk

            const int ArrayLenght = 5; // d,z,nin uzunluğu 5
            int[] array = new int[ArrayLenght]; //5 yazmak gibi buraya

            for (int counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = 2 + 2 * counter;
            }

            Console.WriteLine($"{"dizi sıra"}{"Değerler",8}");
            for (int counter = 0; counter <array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }
            Console.ReadKey();

        }
    }
}
