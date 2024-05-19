using System;

namespace RKE132_Nädal7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Prompt the user to come or go (tulen/lähen)
			Console.WriteLine("Are you coming or going? (tulen/lähen)");

			// Read the user's choice
			string choice = Console.ReadLine();

			// Check if the choice is "tulen" (coming)
			if (choice == "tulen")
			{
				// Call the Greeting function if the choice is "tulen"
				Greeting();
			}
			else
			{
				// Call the Farewell function if the choice is not "tulen"
				Farewell();
			}

			// Function to greet
			static void Greeting()
			{
				// Print a greeting message
				Console.WriteLine("Hello, world!");
			}

			// Function to bid farewell
			static void Farewell()
			{
				// Print a farewell message
				Console.WriteLine("Goodbye!");
			}

		}
	}
}
