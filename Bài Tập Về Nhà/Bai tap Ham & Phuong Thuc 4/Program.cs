using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a sample string.";
            Console.Write("Enter a character to count: ");
            char targetChar = Console.ReadKey().KeyChar;

            int count = CountOccurrences(inputString, targetChar);

            Console.WriteLine($"\nThe character '{targetChar}' appears {count} times in the string.");
        }

        private static int CountOccurrences(string inputString, char targetChar)
        {
            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == targetChar)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
