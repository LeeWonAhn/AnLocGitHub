using System;
using Logic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Choose ");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Exit");
                
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Game.InitializeGame();
                            break;
                        case 2:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
        }
    }
}
