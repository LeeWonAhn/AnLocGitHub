namespace Name
{
    class Program
    {
       static int FindMaxValue(int[,] array)
    {
        int maxValue = array[0, 0];

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] > maxValue)
                {
                    maxValue = array[i, j];
                }
            }
        }

        return maxValue;
    }

    static void Main(string[] args)
    {
        int[,] matrix = {
            { 5, 6, 7 },
            { 8, 9, 10 },
            { 11, 12, 13 }
        }; // Mảng hai chiều

        int maxElement = FindMaxValue(matrix);

        Console.WriteLine("Max value in the 2D array: " + maxElement);
    }
    }
}
