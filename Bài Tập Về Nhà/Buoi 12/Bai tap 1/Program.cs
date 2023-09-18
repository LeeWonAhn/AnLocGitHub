using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Đọc toàn bộ nội dung từ tệp tin CSV
            string[] lines = File.ReadAllLines("countries.csv");

            // Duyệt qua từng dòng và hiển thị thông tin quốc gia
            foreach (string line in lines)
            {
                // Tách dữ liệu bằng dấu phẩy
                string[] data = line.Split(',');

                // Kiểm tra xem có đủ phần tử (ví dụ: IP Start, IP End, Country Code, Country Name)
                if (data.Length >= 6)
                {
                    string ipAddressStart = data[0];
                    string ipAddressEnd = data[1];
                    string countryCode = data[4];
                    string countryName = data[5];

                    Console.WriteLine($"IP Start: {ipAddressStart}");
                    Console.WriteLine($"IP End: {ipAddressEnd}");
                    Console.WriteLine($"Country Code: {countryCode}");
                    Console.WriteLine($"Country Name: {countryName}");
                    Console.WriteLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
