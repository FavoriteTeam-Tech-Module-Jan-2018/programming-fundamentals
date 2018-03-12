using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve a product name from the Console
			string name = Console.ReadLine();

            //On the next three lines we recieve the product contents
			int volume = int.Parse(Console.ReadLine());
			int energy = int.Parse(Console.ReadLine());
			int sugar = int.Parse(Console.ReadLine());

            //Here we calculate the sugar and energy content for the given volume
			int kCalPer100ml  = (int) (volume/100.0 * energy);

			int sugarPer100ml = (int) (volume/100.0 * sugar);

            //TO DO
			Console.WriteLine(
					"{0}ml {1}:\n{2}kcal, {3}g sugars",
					volume, name, kCalPer100ml, sugarPer100ml);
        }
    }
}
