public class Program
{
    static void Main(string[] args)
    {
        int[] arr = GenerateRandomArray(100000);
        StopWatch stopwatch = new StopWatch();

        stopwatch.Start();
        SelectionSort(arr);
        stopwatch.Stop();

        Console.WriteLine($"Thời gian thực thi của thuật toán sắp xếp chọn: {stopwatch.GetElapsedTime()} ms");
    }

    public static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1, 1000000);
        }

        return arr;
    }

    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}