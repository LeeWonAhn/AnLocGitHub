public class Program
{
        static void Main(string[] args)
        {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Red; // đặt màu cho mồi
                Console.Write("0");
                Console.SetCursorPosition(4, 4); // đặt vị trí của rắn hoặc mồi tại tọa độ (x, y)
                Console.ForegroundColor = ConsoleColor.Green; // đặt màu cho rắn
                Console.Write("OOOOOOOOOOO"); // vẽ rắn hoặc mồi bằng ký tự O
        }
}