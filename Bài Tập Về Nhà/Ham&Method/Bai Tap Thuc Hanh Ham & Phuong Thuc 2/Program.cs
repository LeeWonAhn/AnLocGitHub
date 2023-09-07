namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int []array = {4, 12, 7, 8, 1, 6, 9};
            int index = MinValue(array);
            Console.WriteLine("The smallest element in the array is: " + array[index]);
        }

        public static int MinValue(int []array){
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

    }
}