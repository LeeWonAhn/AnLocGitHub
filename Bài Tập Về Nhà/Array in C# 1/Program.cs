using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 7, 8, 9, 10, 11 };
            int maxValue = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            Console.WriteLine("Max value in the array: " + maxValue);
        }
    }
}
