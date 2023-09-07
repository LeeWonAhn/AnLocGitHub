public class Rectangle
{
    double width;
    double height;

    public Rectangle(){

    }

    public Rectangle(double width, double height){
        this.width = width;
        this.height = height;
    }

    public double GetArea(){
       return height * width;
    }

    public double GetPerimeter(){
       return (height + width) * 2;
    }

    public string Display() {
       return  "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }
}