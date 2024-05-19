using System;

class Program
{
	static void Main(string[] args)
	{
		// Prompt the user to enter their gender
		Console.WriteLine("Enter your gender (m/f):");

		// Read the user's input for gender and store it as a character
		char gender = Char.Parse(Console.ReadLine());

		// Prompt the user to enter their last name
		Console.WriteLine("Enter your last name:");

		// Read the user's input for last name and store it as a string
		string lastName = Console.ReadLine();

		// Check the gender provided by the user and greet them accordingly
		if (gender == 'm')
		{
			// If the gender is 'm' (male), greet the user as "Mr."
			Console.WriteLine("Hello, Mr. " + lastName);
		}
		else if (gender == 'f')
		{
			// If the gender is 'f' (female), greet the user as "Mrs."
			Console.WriteLine("Hello, Mrs. " + lastName);
		}
	}
}
