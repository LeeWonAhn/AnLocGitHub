public class Square : Rectangle, IColorable
    {
        public Square() : base()
        {
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides.");
        }
    }
