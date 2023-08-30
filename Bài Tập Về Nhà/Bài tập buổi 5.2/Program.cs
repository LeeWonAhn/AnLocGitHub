namespace Name
{
    class Program
    {
        static int CalculateMainDiagonalSum(int[,] array)
        {
            int sum = 0;

            int size = array.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                sum += array[i, i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[,] matrix = {
            { 5, 6, 7 },
            { 8, 9, 10 },
            { 11, 12, 13 }
        };

            int diagonalSum = CalculateMainDiagonalSum(matrix);

            Console.WriteLine("Sum of main diagonal elements: " + diagonalSum);
        }
    }
}