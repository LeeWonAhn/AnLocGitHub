public class Fan
{
    //Const
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    int speed = SLOW;
    bool isOn = false;
    double radius = 5;
    string color = "blue";

    //Getter
    public int Speed => speed;
    public bool IsOn => isOn;
    public double Radius => radius;
    public string Color => color;


    public Fan(){
    }

    public override string ToString(){
        if (isOn)
        {
            return $"speed: {speed}, color: {color}, radius: {radius}, Fan Is On";
        }else
        {
            return $"color: {color}, radius: {radius}, Fan Is Off";
        }
        
    }
    //Setter
    public void SetSpeed(int speed){
        this.speed = speed;
    }

    public void SetRadius(int radius){
        this.radius = radius;
    }

    public void SetColor(string color){
        this.color = color;
    }

    public void Power(bool isOn){
        this.isOn = isOn;
    }
}