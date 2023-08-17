namespace ConvertUsdToVndApp
{
    class Bai2
{
    static void Main(string[] args)
    {
        int VND = 23000;
        int USD;
        Console.WriteLine("Enter your amount in USD: ");
        string amount = Console.ReadLine();
        USD = int.Parse(amount);
        int vndAmount = VND * USD;
        Console.WriteLine("Your amount is: " + vndAmount + "VND");
    }
}
}