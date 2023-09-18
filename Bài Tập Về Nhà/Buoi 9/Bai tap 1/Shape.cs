public class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public override string ToString()
    {
        return "Shape[color=" + color + "]";
    }
}