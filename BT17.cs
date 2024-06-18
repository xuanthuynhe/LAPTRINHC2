using System;
using System.Text;

class Program
{
    static int CountWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        string[] words = s.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập chuỗi: ");
        string st = Console.ReadLine();

        if (st == "#")
        {
            Console.Beep();
        }
        else
        {
            int wordCount = CountWords(st);
            Console.WriteLine($"Số từ trong chuỗi: {wordCount}");
        }
    }
}