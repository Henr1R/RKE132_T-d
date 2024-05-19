using System;

class Program
{
	static void Main(string[] args)
	{
		// Prompt the user to enter their age
		Console.WriteLine("Please enter your age:");

		// Ask the user for their age and store it as a string
		string userAge = Console.ReadLine();

		// Declare a variable to hold the parsed age as an integer
		int userNumericAge = 0;

		// Try to parse the user input to an integer
		bool isAgeNumeric = Int32.TryParse(userAge, out userNumericAge);

		// Check if the input could be successfully parsed as an integer
		if (isAgeNumeric)
		{
			// If the input is numeric, check if the user's age is 13 or older
			if (userNumericAge >= 13)
			{
				// If the user is 13 or older, welcome them to Instagram
				Console.WriteLine("Welcome to Instagram!");
			}
			else
			{
				// If the user is younger than 13, inform them they are too young for Instagram
				Console.WriteLine("You are too young to use Instagram!");
			}
		}
		else
		{
			// If the input could not be parsed as an integer, inform the user
			Console.WriteLine("Could not detect age.");
		}
	}
}
