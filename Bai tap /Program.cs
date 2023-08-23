public class Program
{
    static void Main(string[] args)
    {
        // float width;
        // float height; 
        // Console.Write("Enter width: ");
        // width = float.Parse(Console.ReadLine());
        // Console.Write("Enter height: ");
        // height = float.Parse(Console.ReadLine());
        // float area = width * height;
        // Console.WriteLine("Area is: " + area);
        // double a;
        // double b;
        // double c;
        // // a=bx+c
        // Console.WriteLine("Linear Equation Resolver a=bx+c");
        // Console.WriteLine("a: ");
        // a = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("b: ");
        // b = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("c: ");
        // c = Convert.ToDouble(Console.ReadLine());
        // if (b==0){
        //     if (a==c){
        //         Console.WriteLine("Phuong Trinh Vo So Nghiem");
        //     }else
        //     {
        //         Console.WriteLine("Phuong trinh vo nghiem");
        //     }
        // }else {
        //     double x = (a-c)/b;
        //     Console.WriteLine($"Result {a} = {b}.x + {c} la {x}");
        // }
        // double weight;
        // double height;
        // Console.WriteLine("Enter your Weight");
        // weight = float.Parse(Console.ReadLine());
        // Console.WriteLine("Enter your Height");
        // height = float.Parse(Console.ReadLine());
        // double bmi = weight / Math.Pow(height,2);
        // bmi = Math.Round(bmi, 1);
        // Console.Write("BMI: "+ bmi);
        //     if (bmi < 18)
        //         {Console.WriteLine(" Underweight");}
        //     else if (bmi < 25.0)
        //         {Console.WriteLine(" Normal");}
        //     else if (bmi < 30.0)
        //         {Console.WriteLine(" Overweight");}
        //     else
        //         {Console.WriteLine(" Obese");}
        Console.WriteLine("Giai phuong trinh bac 2: ax2 + bx + c = 0");
        Console.WriteLine("Enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c: ");
        float c = float.Parse(Console.ReadLine());

        double delta = Math.Pow(b,2) - 4*a*c;

        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }else if(delta == 0) {
            Console.WriteLine($"Phuong trinh co nghiem kep: {-b/(2*a)}");
        }else if(delta > 0) {
            Console.WriteLine($"Phuong trinh co 2 nghiem: {(-b - (float)(Math.Sqrt(delta)))/(2*a)}, {(-b - (float)(Math.Sqrt(delta)))/(2*a)} ");
        }

        // Bai tap Array
        //Bai tap 1
        int[] a ={3, 5, 7, 9};
            int total = 0;
            for (int i = 0; i < a.Length; i++) {
                total += a[i];
            }
            Console.WriteLine("Total: " + total);
        
        //Bai Tap 2

            string[] students = {"Christian", "Michael", 
                                "Camila", "Sienna", 
                                "Tanya", "Connor", 
                                "Zachariah", "Mallory", 
                                "Zoe", "Emily"};
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            for (int i = 0; i < students.Length; i++){
                if (name.ToUpper() == students[i].ToUpper()) {
                    Console.WriteLine($"Da tim thay hoc sinh. Hoc sinh la phan tu thu {i} ");
                    return;
                }
            }
            Console.WriteLine("Khong tim thay duoc hoc sinh");
    }
}
