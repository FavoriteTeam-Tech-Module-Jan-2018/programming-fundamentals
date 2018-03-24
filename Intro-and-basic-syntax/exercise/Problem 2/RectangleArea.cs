//CONFIRMED from <chizmyak>
using System;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
           // We take the variables from the console
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            // Calculate the rectangle area
            double rectangleArea = a * b;

          // Print the reslt
            Console.WriteLine($"{rectangleArea:F2}");
        }
    }
}
