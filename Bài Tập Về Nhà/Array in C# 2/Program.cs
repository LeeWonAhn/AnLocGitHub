using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 7, 8, 9, 10, 11, 22, 21, 31, 98, 99 };

            int maxOddValue = Int32.MinValue; 
            foreach (int number in numbers)
            {
                if (number % 2 == 1 && number > maxOddValue)
                {
                    maxOddValue = number;
                }
            }
                Console.WriteLine("Max odd value in the array: " + maxOddValue);
        }
    }
}
