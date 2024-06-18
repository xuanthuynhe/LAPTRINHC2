using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập mã bảng mã cho console
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số thực x 4 byte
        float x = ReadFloat();

        // In ra màn hình giá trị được nhập
        Console.WriteLine($"Giá trị x đã nhập: {x}");
    }

    /// <summary>
    /// Đọc số thực 4 byte từ bàn phím
    /// </summary>
    /// <returns>Số thực 4 byte</returns>
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            Console.Write("Nhập số thực 4 byte: ");
            if (float.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
        }
    }
}