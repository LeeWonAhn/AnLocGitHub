namespace Helloworld
{
    class Program
    {
        // const int g = 10; // const khong the thay doi
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
            // double[,] diem_cac_lop = {{1,3,2}, {3.3, 4.2, 4}};
            //  double diem = diem_cac_lop[0, 2];
            //  double diem4 = diem_cac_lop[1, 2];
            // for (int i = 0; i< diem_cac_lop.GetLength(0); i++){
            //     for (int j = 0; j < diem_cac_lop.GetLength(1); j++)
            // {
            //         Console.Write(diem_cac_lop[i, j] + " ");
            // }
            // Console.WriteLine();
            // }
            // string[,] map ={
            //     {"*","","","",""},
            //     {"","","","*",""},
            //     {"","","*","","*"},
            //     {"","","","",""},
            // };
            // for (int x = 0; x < map.GetLength(1); x++)
            // {
            //     for (int y = 0; y < map.GetLength(0); y++)
            //     {
            //         if (map[y, x] == "*")
            //         {

            //         }
            //         else
            //         {
            //             int dem_so_bom = 0;

            //             int[,] xung_quanh = {
            //                 {y-1,x-1},{y-1,x+0},{y-1,x+1},
            //                 {y+0,x-1}          ,{y+0,x+1},
            //                 {y+1,x-1},{y+1,x+0},{y+1,x+1}
            //             };
            //             for (int i = 0; i < xung_quanh.GetLength(0); i++)
            //             {
            //                 if (xung_quanh[i, 0] < 0 || xung_quanh[i, 1] < 0
            //                 || xung_quanh[i, 0] >= map.GetLength(0) || xung_quanh[i, 1] >= map.GetLength(1))
            //                 {

            //                 }
            //                 else
            //                 {
            //                     if (map[xung_quanh[i, 0], xung_quanh[i, 1]] == "*")
            //                     {
            //                         dem_so_bom++;
            //                     }
            //                 }
            //             }
            //             map[y, x] = dem_so_bom.ToString();
            //         }
            //     }
            // }
            // for (int y = 0; y < map.GetLength(0); y++)
            // {
            //     for (int x = 0; x < map.GetLength(1); x++)
            //     {
            //         Console.Write(map[y, x]);

            //     }
            //     Console.WriteLine();
            // }
        //      int[,] mang_hai_chieu = {
        //         { 3, 8, 2 },
        //         { 10, 4, 6 },
        //         { 1, 7, 9 }
        //     };
        //     Program pg = new Program();

        //     int total = pg.TinhTongCua1Mang(mang_hai_chieu);
        //     Console.WriteLine("Total: " + total);

        //     int[,] mang_hai_chieu2 = {
        //         { 3, 8, 5 },
        //         { 10, 4, 1 },
        //         { 1, 7, 3 }
        //     };

        //     Console.WriteLine("Total: " + pg.TinhTongCua1Mang(mang_hai_chieu2));
        //     Console.WriteLine("Cong 2 so " + pg.Cong2So(3, 5));
            
        // }
        // private void InRaManHinh(string chuoikitu)
        // {
        //     Console.WriteLine(chuoikitu);
        // }

        // private int Cong2So(int a, int b)
        // {
        //     return a + b;
        // }
        // //public 
        // private static int cong2 = 2;
        // private int TinhTongCua1Mang(int[,] mang_so)
        // {
        //     int total = 0;
        //     for (int i = 0; i < mang_so.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < mang_so.GetLength(1); j++)
        //         {
        //             total += mang_so[i, j];
        //         }
        //     }
        //     return total;
        // }
    //     Console.WriteLine("" + ChuyenDoiCSangF(37));
    // }
    // private static float ChuyenDoiCSangF(float doC){
    //     return doC * 1.8f +32;
    // }

    // private static float  ChuyenDoiFSangC(float doF){
    //     return (doF - 32) / 1.8f;
    // }
}
}
}
