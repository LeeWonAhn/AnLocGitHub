using System;

class Program
{
    static void Main(string[] args)
    {
        string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if ( number < 10)
        {
            Console.WriteLine(ones[number]);
        }
        else if (number < 20)
        {
                Console.WriteLine(teens[number - 10]);
        }
        else if (number < 100)
        {
            int tensNumber = number / 10;
            int onesNumber = number % 10;
            if (onesNumber == 0)
                Console.WriteLine(tens[tensNumber]);
            else
                Console.WriteLine(tens[tensNumber] + " " + ones[onesNumber]);
        }
        else if (number < 1000)
        {
            int hundredsNumber = number / 100;
            int remainingTwoNumber = number % 100;
            Console.Write(ones[hundredsNumber] + " Hundred");
            if (remainingTwoNumber > 0)
            {
                Console.Write(" and ");
                if (remainingTwoNumber < 10)
                    Console.WriteLine(ones[remainingTwoNumber]);
                else if (remainingTwoNumber < 20)
                    Console.WriteLine(teens[remainingTwoNumber - 10]);
                else
                {
                    int tensNumber = remainingTwoNumber / 10;
                    int onesNumber = remainingTwoNumber % 10;

                    if (onesNumber == 0)
                        Console.WriteLine(tens[tensNumber]);
                    else
                        Console.WriteLine(tens[tensNumber] + " " + ones[onesNumber]);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("Done");
    }
}
