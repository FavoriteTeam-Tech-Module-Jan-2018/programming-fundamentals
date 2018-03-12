using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve a product name from the Console
            string name1 = Console.ReadLine();

            //On the next three lines we recieve the product contents
            int volume1 = int.Parse(Console.ReadLine());
            int energy1 = int.Parse(Console.ReadLine());
            int sugar1 = int.Parse(Console.ReadLine());

            //Here we calculate the sugar and energy content for the given volume
            int kCalloriesPer100ml = (int)(volume1 / 100.0 * energy1);

            int sugar100ml = (int)(volume1 / 100.0 * sugar1);

            //TO DO
            Console.WriteLine(
                    "{0}ml {1}:\n{2}kcal, {3}g sugars",
                    volume1, name1, kCalloriesPer100ml, sugar100ml);
        }
    }
}
