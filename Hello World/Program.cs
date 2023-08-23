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
            // Console.WriteLine("Nhap 1 so");
            // double a = Convert.ToDouble(Console.ReadLine());
            // while (a!=0)
            // {
            //     Console.WriteLine($"a: {a}");
            //     a--;
            // }
            // // do
            // // {
            // //     Console.WriteLine("Moi Nhap Lai");
            // //     a = Convert.ToDouble(Console.ReadLine());
            // // } while (a==0);
            // Console.WriteLine($"a: {a}");
            // for (int i = 0; i <10; i++) {
            //  Console.WriteLine(i);
            // }
            // int width = 10;
            // int width_temp = width;
            // // int height = 5;
            // // for (int i = 0; i < height; i++)
            // // {
            // //     for(int j = 0; j < width; j++){
            // //         Console.Write("o");
            // //     }
            // //     Console.WriteLine("");
            // // }
            // for (int i = 0; i < width; i++)
            // {
            //     for (int j = 0; j < width_temp; j++)
            //     {
            //     Console.Write("o");
            //     }
            //     width_temp--;
            //     Console.WriteLine("");
            // }
            // int a = 8;
            // Console.WriteLine("Enter your number: ");
            // a = Convert.ToInt32(Console.ReadLine());
            // bool isPrime = true;
            // for (int i = 2; i < a; i++)
            // {
            //     if (a % i == 0)
            //     {
            //         isPrime = false;
            //     }
            // }
            // Console.WriteLine(isPrime);
            // string[] player = new string[]{};
            // int[] mang_so = new int[3];
            // string[] mang_chu = new string[3];
            // Console.WriteLine(mang_so[0]);
            // Console.WriteLine(mang_chu[0]);
            // Console.WriteLine(player[1]);
            // player[0] = "An Loc";
            // int[] diem_cac_man = new int[] {22, 23, 63};
            // int total = 0;
            // for (int i = 0; i < diem_cac_man.Length; i++)
            // {
            //     total += diem_cac_man[i];
            // }
            // Console.WriteLine("Total: " + total);
            double[,] diem_cac_lop = {{1,3,2}, {3.3, 4.2, 4}};
            // double diem = diem_cac_lop[0, 2];
            // double diem4 = diem_cac_lop[1, 2];
            for (int i = 0; i< diem_cac_lop.GetLength(0); i++){
                for (int j = 0; j < diem_cac_lop.GetLength(1); j++)
            {
                    Console.Write(diem_cac_lop[i, j] + " ");
            }
            Console.WriteLine();
            }
    }
}
}
