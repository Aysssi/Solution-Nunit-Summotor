using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
            if (result == 21)
            {
                Console.WriteLine("Test PASS");
            }
            else
            {
                Console.WriteLine("Test FAIL");
            }

            double average = Summator.Average(new long[] { 5, 10, 15 });
            if (average ==10)
            {
                Console.WriteLine("Test PASS");
            }
            else
            {
                Console.WriteLine("Test FAIL");
            }


        }
    }
}
