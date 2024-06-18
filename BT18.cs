using System;

class Program
{
    static double ReadDouble()
    {
        double value;
        while (true)
        {
            Console.Write("Nhap so thuc 8 byte: ");
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Nhap sai, vui long nhap lai.");
        }
    }

    static void Main(string[] args)
    {
        double x = ReadDouble();
        Console.WriteLine($"Can bac 2 cua {x} la {Math.Sqrt(x)}");
    }
}