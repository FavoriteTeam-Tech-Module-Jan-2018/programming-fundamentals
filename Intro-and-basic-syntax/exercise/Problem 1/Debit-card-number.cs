using System;

namespace Debit_card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
