// Importing the System namespace to access its classes and methods
using System;

// Defining the namespace ArgumentsAndParameters
namespace ArgumentsAndParameters
{
	// Defining the internal Program class
	internal class Program
	{
		// Defining the Main method
		static void Main(string[] args)
		{
			// Prompting the user to enter something and reading the input
			Console.WriteLine("Enter something");
			string userInput = Console.ReadLine();

			// Calling the RepeatInputFiveTimes method and passing the user input as an argument
			RepeatInputFiveTimes(userInput);

			// Defining the RepeatInputFiveTimes method, which takes a string parameter 's'
			static void RepeatInputFiveTimes(string s)
			{
				// Converting the input string to uppercase
				s = s.ToUpper();

				// Looping 5 times to print the uppercase input string
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine(s);
				}
			}
		}
	}
}
