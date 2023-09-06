namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 40;
            int height = 40;
            int[,] walls = new int[width, height];
            int score = 0;

            Random randomFood = new Random();
            int foodRow = randomFood.Next(1, height - 1);
            int foodCol = randomFood.Next(1, width - 1);

            int SnakePositionRow = 2;
            int SnakePositionCol = 2;

            int tempRow = 0;
            int tempCol = 0;

            bool gameOn = true;

            while (gameOn)
            {
                Console.SetCursorPosition(44, 4);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Your score: " + score);

                Console.SetCursorPosition(SnakePositionRow, SnakePositionCol);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write('.');

                Console.SetCursorPosition(foodRow, foodCol);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("o");

                Console.BackgroundColor = ConsoleColor.Red;

                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("#");
                }

                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, height - 1);
                    Console.Write("#");
                }

                for (int i = 1; i < height - 1; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("#");
                }

                for (int i = 1; i < height - 1; i++)
                {
                    Console.SetCursorPosition(width - 1, i);
                    Console.Write("#");
                }

                ConsoleKeyInfo playerInput = Console.ReadKey();

                Console.SetCursorPosition(SnakePositionRow, SnakePositionCol);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");

                if (playerInput.Key == ConsoleKey.RightArrow)
                {
                    tempRow = SnakePositionRow + 1;
                    tempCol = SnakePositionCol;
                }
                else if (playerInput.Key == ConsoleKey.LeftArrow)
                {
                    tempRow = SnakePositionRow - 1;
                    tempCol = SnakePositionCol;
                }
                else if (playerInput.Key == ConsoleKey.UpArrow)
                {
                    tempRow = SnakePositionRow;
                    tempCol = SnakePositionCol - 1;
                }
                else if (playerInput.Key == ConsoleKey.DownArrow)
                {
                    tempRow = SnakePositionRow;
                    tempCol = SnakePositionCol + 1;
                }

                SnakePositionRow = tempRow;
                SnakePositionCol = tempCol;

                Console.SetCursorPosition(SnakePositionRow, SnakePositionCol);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(' ');

                if (SnakePositionRow == foodRow && SnakePositionCol == foodCol)
                {
                    Console.SetCursorPosition(foodRow, foodCol);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" ");

                    foodRow = randomFood.Next(1, height - 1);
                    foodCol = randomFood.Next(1, width - 1);
                    score++;
                }

                if (SnakePositionRow >= height - 1 || SnakePositionRow <= 0 || SnakePositionCol >= width - 1 || SnakePositionCol <= 0)
                {
                    gameOn = false;
                }
            }

            Console.SetCursorPosition(2, 5);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Game Over");
            Console.ReadKey();
        }
    }
}
