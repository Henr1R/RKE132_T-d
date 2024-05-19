// Importing the System namespace to access its classes and methods
using System;

// Defining the namespace NumberArray
namespace NumberArray
{
	// Defining the internal Program class
	internal class Program
	{
		// Defining the Main method
		static void Main(string[] args)
		{
			// Declaring an array 'numbrid' to store 10 integers
			int[] numbrid = new int[10];

			// Creating a new instance of the Random class to generate random numbers
			Random rnd = new Random();

			// Declaring a variable 'sum' to store the sum of all numbers in the array
			int sum = 0;

			// Looping through each element of the array 'numbrid'
			for (int i = 0; i < numbrid.Length; i++)
			{
				// Generating a random number between 1 and the length of the array 'numbrid' + 1
				numbrid[i] = rnd.Next(1, numbrid.Length + 1);

				// Adding the current number to the sum
				sum = sum + numbrid[i];
			}

			// Iterating through each number in the array 'numbrid' and printing them
			foreach (int number in numbrid)
			{
				Console.WriteLine(number);
			}

			// Printing the total sum of all numbers in the array
			Console.WriteLine($"Total: {sum}");
		}
	}
}
