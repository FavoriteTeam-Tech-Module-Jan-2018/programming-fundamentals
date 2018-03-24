using System;

class Program {
	static void Main() {

		// We read the character's name, as well as his statistics
		string name = Console.ReadLine();
		int currentHealth = int.Parse(Console.ReadLine()),
			maxHealth  = int.Parse(Console.ReadLine()),
			currEnergy = int.Parse(Console.ReadLine()),
			maxEnergy  = int.Parse(Console.ReadLine());

		// And we print them in the required format
		Console.WriteLine("Name: {0}\nHealth: |{1}{2}|\nEnergy: |{3}{4}|",
				name,
				new string('|', currentHealth),
				new string('.', maxHealth - currentHealth),
				new string('|', currEnergy),
				new string('.', maxEnergy - currEnergy));
	}
}
