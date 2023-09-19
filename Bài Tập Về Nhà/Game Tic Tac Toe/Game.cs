namespace Logic
{
    class Game
    {   
          public static void InitializeGame()
        {
            char[,] board = new char[3, 3];
            char currentPlayer = 'X';
            int moves = 0;
            bool gameEnd = false;

            Console.CursorVisible = false;
            Console.Clear();
            DrawBoard(board);

            while (!gameEnd)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        MoveCursor(-1, 0, board);
                        break;

                    case ConsoleKey.RightArrow:
                        MoveCursor(1, 0, board);
                        break;

                    case ConsoleKey.UpArrow:
                        MoveCursor(0, -1, board);
                        break;

                    case ConsoleKey.DownArrow:
                        MoveCursor(0, 1, board);
                        break;

                    case ConsoleKey.Spacebar:
                        int x = Console.CursorLeft / 4;
                        int y = Console.CursorTop / 2;

                        if (IsValidMove(x, y, board))
                        {
                            MakeMove(x, y, currentPlayer, board);
                            moves++;

                            DrawBoard(board);

                            if (CheckWin(x, y, currentPlayer, board))
                            {
                                gameEnd = true;
                                Console.SetCursorPosition(0, 5);
                                Console.WriteLine($"Player {currentPlayer} wins!");
                            }
                            else if (moves == 9)
                            {
                                gameEnd = true;
                                Console.SetCursorPosition(0, 5);
                                Console.WriteLine("It's a draw!");
                            }

                            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                        }

                        break;
                }
            }

            Console.CursorVisible = true;
            SaveGameResult(currentPlayer);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void DrawBoard(char[,] board)
        {
            Console.Clear();
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("Use Arrow Keys to Move, Space to Place Your Move");
            Console.WriteLine("┌───┬───┬───┐");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("│");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {board[j, i]} │");
                }
                Console.WriteLine("\n├───┼───┼───┤");
            }
        }

        static void MoveCursor(int deltaX, int deltaY, char[,] board)
        {
            int newX = Math.Max(0, Math.Min(Console.CursorLeft / 4 + deltaX, 2));
            int newY = Math.Max(0, Math.Min(Console.CursorTop / 2 + deltaY, 2));

            Console.SetCursorPosition(newX * 4 + 1, newY * 2 + 1);
        }

        static bool IsValidMove(int x, int y, char[,] board)
        {
            return board[x, y] == ' ';
        }

        static void MakeMove(int x, int y, char currentPlayer, char[,] board)
        {
            board[x, y] = currentPlayer;
        }

        static bool CheckWin(int x, int y, char currentPlayer, char[,] board)
        {
            
            if (board[0, y] == currentPlayer && board[1, y] == currentPlayer && board[2, y] == currentPlayer)
            {
                return true;
            }

            
            if (board[x, 0] == currentPlayer && board[x, 1] == currentPlayer && board[x, 2] == currentPlayer)
            {
                return true;
            }

            
            if (x == y && board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            {
                return true;
            }
            if (x + y == 2 && board[2, 0] == currentPlayer && board[1, 1] == currentPlayer && board[0, 2] == currentPlayer)
            {
                return true;
            }

            return false;
        }

        static void SaveGameResult(char winner)
        {
            string result;
            if (winner == 'X')
            {
                result = "Player X wins!\n";
            }
            else if (winner == 'O')
            {
                result = "Player O wins!\n";
            }
            else
            {
                result = "It's a draw!\n";
            }

            File.AppendAllText("TicTacToeResults.txt", result);
        }
    }
}