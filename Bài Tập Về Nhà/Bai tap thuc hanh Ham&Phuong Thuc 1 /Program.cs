//Chuyen doi do C sang do F
namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            float doC;
            float doF;
            int choice;
            Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
            // do{
            //     Console.WriteLine("Menu.");
            //     Console.WriteLine("1. Fahrenheit to Celsius");
            //     Console.WriteLine("2. Celsius to Fahrenheit");
            //     Console.WriteLine("0. Exit");
            //     Console.WriteLine("Enter your choice: ");
            //     choice = Int32.Parse(Console.ReadLine());
            //     switch (choice)
            //     {
            //         case 1:
            //         Console.WriteLine("Enter fahrenheit: ");
            //         doF = float.Parse(Console.ReadLine());
            //         Console.WriteLine("Fahrenheit to Celsius: " + ChuyenDoFSangC(doF));
            //         break;
            //         case 2:
            //         Console.WriteLine("Enter Celsius: ");
            //         doC = float.Parse(Console.ReadLine());
            //         Console.WriteLine("Celsius to Fahrenheit: " + ChuyenDoCSangF(doC));
            //         break;
            //         case 0:
            //         Environment.Exit(0);
            //         break;
            //     }
            // }while (choice != 0);

            if (choice == 1)
            {
                Console.WriteLine("Enter Fahrenheit: ");
                doF = float.Parse(Console.ReadLine());
                Console.WriteLine("Fahrenheit to Celsius: " + ChuyenDoFSangC(doF));
            }else if (choice == 2)
            {
                Console.WriteLine("Enter Celsius: ");
                doC = float.Parse(Console.ReadLine());
                Console.WriteLine("Celsius to Fahrenheit: " + ChuyenDoCSangF(doC));
            }else {
                Environment.Exit(0);
            }
        }
        
        private static float ChuyenDoCSangF (float doC){
            return doC * 1.8f + 32;
        }
        private static float ChuyenDoFSangC(float doF){
            return (doF - 32) / 1.8f;
        }
    }
}