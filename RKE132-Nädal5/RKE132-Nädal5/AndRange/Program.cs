// Importing the System namespace to access its classes and methods
using System;

// Defining the namespace AndRange
namespace AndRange
{
	// Defining the internal Program class
	internal class Program
	{
		// Defining the Main method
		static void Main(string[] args)
		{
			// Prompting the user to enter the temperature and reading the input
			Console.WriteLine("Enter the temperature: ");
			int temp = Int32.Parse(Console.ReadLine());

			// Checking the temperature range and printing the corresponding message
			if (temp >= 30)
			{
				Console.WriteLine("Boiling hot");
			}
			else if (temp < 30 && temp >= 20)
			{
				Console.WriteLine("Hot.");
			}
			else if (temp < 20 && temp >= 15)
			{
				Console.WriteLine("Warm.");
			}
			else if (temp < 15 && temp >= 10)
			{
				Console.WriteLine("Chilly.");
			}
			else if (temp < 10 && temp > 0)
			{
				Console.WriteLine("Cold.");
			}
			else
			{
				Console.WriteLine("Freezing cold.");
			}
		}
	}
}

