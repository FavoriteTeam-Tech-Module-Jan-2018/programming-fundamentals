using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the variable from the Console
            double miles = double.Parse(Console.ReadLine());

            //Calculate the kilometres
            double kilometers = miles * 1.60934;

            //Print the result
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
