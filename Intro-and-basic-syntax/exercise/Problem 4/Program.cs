using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
			string name = Console.ReadLine();
			int volume = int.Parse(Console.ReadLine());
			int energy = int.Parse(Console.ReadLine());
			int sugar = int.Parse(Console.ReadLine());

			int kCalPer100ml  = (int) (volume/100.0 * energy);

			int sugarPer100ml = (int) (volume/100.0 * sugar);

			Console.WriteLine(
					"{0}ml {1}:\n{2}kcal, {3}g sugars",
					volume, name, kCalPer100ml, sugarPer100ml);
        }
    }
}
