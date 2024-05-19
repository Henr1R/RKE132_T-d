// Importing the System namespace to access its classes and methods
using System;

// Defining the RandomGuess class
class While
{
	static void Main(string[] args)
	{
		// Creating a new instance of the Random class
		Random rnd = new Random();

		// Declaring a variable to hold the randomly generated CPU number
		int cpuRandom;

		// Variable to control the loop
		bool loopActive = true;

		// Loop continues until loopActive is false
		while (loopActive)
		{
			// Generating a random number between 1 and 3
			cpuRandom = rnd.Next(1, 4);

			// Printing the CPU-generated random number
			Console.WriteLine($"CPU has generated {cpuRandom}.");
			Console.WriteLine("Make a guess. Enter a number between 1-3");

			// Reading user's input for the guess
			int userNumber = Int32.Parse(Console.ReadLine());

			// Checking if the user's guess matches the CPU's random number
			if (userNumber == cpuRandom)
			{
				// If the guess is correct, print a congratulatory message and exit the loop
				Console.WriteLine("Congratulations, you won!");
				break;
			}
			else
			{
				// If the guess is incorrect, prompt the user to try again
				Console.WriteLine("Oops. Try again.");
			}
		}

		// Once the loop exits, print a closing message
		Console.WriteLine("Have a nice day!");
	}
}
