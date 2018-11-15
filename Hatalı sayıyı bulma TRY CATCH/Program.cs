using System;

namespace DENEME_7
{
    class StudentPoll
    {
        static void Main()
        {
            int [] responses = {1,2,5,4,3,5,2,1,3,3,1,4,3,3,3,2,3,3,2,14};

            var frequency = new int [6];

            for ( var answer = 0 ; answer < responses.Length; ++answer)
            {
                try
                {
                    ++frequency[responses[answer]];

                }

                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"[{answer}]= {responses[answer]}\n");
                }
            }
        }
    }
}
