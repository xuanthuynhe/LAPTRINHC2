using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập mã bảng mã cho console
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 1 byte không dấu
        byte n = ReadByte();

        // In ra màn hình giá trị được nhập
        Console.WriteLine($"Giá trị n đã nhập: {n}");
    }

    /// <summary>
    /// Đọc số nguyên 1 byte không dấu từ 2 đến 10 từ bàn phím
    /// </summary>
    /// <returns>Số nguyên 1 byte không dấu</returns>
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            Console.Write("Nhập số nguyên 1 byte không dấu trong khoảng 2 đến 10: ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
            {
                return value;
            }
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
        }
    }
}