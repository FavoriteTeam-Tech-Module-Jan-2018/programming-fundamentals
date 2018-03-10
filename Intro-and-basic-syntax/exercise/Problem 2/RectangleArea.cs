using System;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double rect_area = a * b;
            Console.WriteLine($"{rect_area:F2}");
        }
    }
}