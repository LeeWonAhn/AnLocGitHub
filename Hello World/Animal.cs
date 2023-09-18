public class Animal
{
    public int FeetCount;
    public int AgeSpan;
    public string Color;

    public virtual MakeSound(){
        Console.WriteLine("Make Sound");
    }

}

public class Dog : Animal {
    public override void MakeSound(){
        Console.WriteLine("Gau Gau");
    }
}

public class Pig : Animal {
    public override void MakeSound(){
        Console.WriteLine("Ec sec");
    }
}