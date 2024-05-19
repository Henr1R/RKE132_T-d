using System;

namespace OddOrEven
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Prompt the user to enter a number
			Console.WriteLine("Enter a number:");

			// Read the user's input and convert it to an integer
			int userNum = Convert.ToInt32(Console.ReadLine());

			// Calculate the remainder when dividing the user's number by 2
			int result = userNum % 2;

			// Check if the remainder is not equal to 0, indicating an odd number
			if (result != 0)
			{
				// If the remainder is not 0, the number is odd
				Console.WriteLine("Number is odd");
			}
			else
			{
				// If the remainder is 0, the number is even
				Console.WriteLine("Number is even.");
			}

		}
	}
}
