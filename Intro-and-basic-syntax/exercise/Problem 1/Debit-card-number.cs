using System;

namespace Debit_card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
			// We read the four numbers of the debit card
            int firstNum = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

			// And then print them with at least four digits
            Console.WriteLine($"{firstNum:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
