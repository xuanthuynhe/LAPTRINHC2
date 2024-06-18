using System;
using System.Text;

class Program
{
    static byte ReadByteInRange(int min, int max)
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            else
                Console.WriteLine($"Giá trị không hợp lệ. Vui lòng nhập một giá trị từ {min} đến {max}.");
        }
    }

    static int ReadInt()
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static void ReadMatrix(int[,] matrix, int m, int n)
    {
        Console.WriteLine($"Nhập {m * n} phần tử của ma trận {m}x{n}:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = ReadInt();
            }
        }
    }

    static int SumDivisibleByP(int[,] matrix, int m, int n, int p)
    {
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] % p == 0)
                    sum += matrix[i, j];
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        byte m = ReadByteInRange(1, 10);
        byte n = ReadByteInRange(1, 10);
        Console.WriteLine($"Giá trị của m: {m}, giá trị của n: {n}");

        int[,] a = new int[m, n];
        ReadMatrix(a, m, n);
        Console.WriteLine("Giá trị của mảng a:");
        PrintMatrix(a, m, n);

        int sum = SumDivisibleByP(a, m, n, 2024);
        Console.WriteLine($"Tổng các phần tử của mảng a chia hết cho 2024: {sum}");
    }

    static void PrintMatrix(int[,] matrix, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}