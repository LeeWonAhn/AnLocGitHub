public class Program
{
    
    static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        Fan fan2 = new Fan();
        
        fan1.SetSpeed(Fan.FAST);
        fan1.SetColor("yellow");
        fan1.SetRadius(10);
        fan1.Power(true);

        fan2.SetSpeed(Fan.MEDIUM);
        fan2.SetColor("blue");
        fan2.SetRadius(5);
        fan2.Power(false);

        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}