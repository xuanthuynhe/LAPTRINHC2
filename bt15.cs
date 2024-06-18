using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập mã bảng mã cho console
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 1 byte không dấu
        byte n = ReadUnsignedByte(2, 10);

        // In ra màn hình giá trị n được nhập
        Console.WriteLine($"Giá trị n đã nhập: {n}");

        // Khai báo mảng 1 chiều các số thực 4 byte a, và cấp phát để a gồm n phần tử
        float[] a = new float[n];

        // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
        ReadFloatArray(a);

        // In ra màn hình giá trị của mảng a
        Console.WriteLine("Giá trị mảng a:");
        foreach (float value in a)
        {
            Console.WriteLine(value);
        }
    }

    /// <summary>
    /// Đọc số nguyên 1 byte không dấu từ bàn phím, trong khoảng min và max
    /// </summary>
    /// <param name="min">Giá trị nhỏ nhất</param>
    /// <param name="max">Giá trị lớn nhất</param>
    /// <returns>Số nguyên 1 byte không dấu</returns>
    static byte ReadUnsignedByte(byte min, byte max)
    {
        byte value;
        while (true)
        {
            Console.Write($"Nhập số nguyên 1 byte không dấu trong khoảng [{min}, {max}]: ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
        }
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

    /// <summary>
    /// Đọc n phần tử số thực 4 byte từ bàn phím
    /// </summary>
    /// <param name="array">Mảng số thực 4 byte</param>
    static void ReadFloatArray(float[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadFloat();
        }
    }
}