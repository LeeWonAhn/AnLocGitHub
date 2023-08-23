namespace Helloworld{
    class Program
    {
        const int g = 10; // const khong the thay doi
        static void Main(string[] args)
        {
            // // Console.WriteLine("Hello, world!");
            // // Console.WriteLine("Nguyen An Loc");
            // // int v1 = 1;
            // // char a = 'a';
            // // bool a1 = true;
            // // var a2 = 2; //var la bien dong.
            // int v2 = 13%10;
            // Console.WriteLine(v2);
            // int i = 0;
            // i++;
            // i++;
            // Console.WriteLine(i);
            // bool daHocQuaTatCaTinChi = true;
            // bool daCoBangDaiHoc = true;
            // Console.WriteLine(daHocQuaTatCaTinChi&&daCoBangDaiHoc);
            // // &&: Thoa man 2 dieu kien
            // // ||: Thoa man 1 trong 2 dieu kien
            // // !: Nguoc voi dieu kien

            // int a = 1;
            // a += 2;
            // a= a + 2;
            // Thuc Hanh
            // DateTime localDate = Datetime.Now;
            // Console.WriteLine("Date time now is: " + localDate);
            // int an_loc = 13;
            // if (an_loc >= 18)
            // {
            //     Console.WriteLine("Du Dieu Kien Uong Bia");
            // } else
            // {
            //      Console.WriteLine("Khong Du Dieu Kien Uong Bia");
            // }
            // int age = 7;
            // if (age>=6 && age <11)
            // {
            //     Console.WriteLine("Dang hoc tieu hoc");
            // }else if(age > 11 && age <=15)
            // {
            //     Console.WriteLine("Dang hoc cap 2");
            // }else if(age >= 15 && age<18)
            // {
            //     Console.WriteLine("Dang hoc cap 3");
            // }else
            // {
                
            // }
            // Console.WriteLine("Ket thuc chuong trinh");
            // int month = 1;
            // string month_string = "";
            // switch (month)
            // {
            // case 1: 
            //     month_string = "January";
            //     break;
            // case 2:
            //     month_string = "February";
            //     break;
            // case 3:
            //     month_string = "March";
            //     break;
            // default:
            //     month_string = "December";
            //     break;
            // }
            // Console.WriteLine(month_string);
            Console.WriteLine("Nhap 1 so");
            double a = Convert.ToDouble(Console.ReadLine());
            while (a!=0)
            {
                Console.WriteLine($"a: {a}");
                a--;
            }
            // do
            // {
            //     Console.WriteLine("Moi Nhap Lai");
            //     a = Convert.ToDouble(Console.ReadLine());
            // } while (a==0);
            Console.WriteLine($"a: {a}");
        }
    }
}
