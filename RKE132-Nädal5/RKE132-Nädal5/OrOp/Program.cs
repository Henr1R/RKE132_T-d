// Importing the System namespace to access its classes and methods
using System;

// Defining the namespace OrOp
namespace OrOp
{
	// Defining the internal Program class
	internal class Program
	{
		// Defining the Main method
		static void Main(string[] args)
		{
			// Declaring variables to store the results of math, biology, and chemistry exams
			int math, biology, chemistry;

			// Prompting the user to enter their Math result and reading the input
			Console.WriteLine("Enter your Math result:");
			math = Int32.Parse(Console.ReadLine());

			// Prompting the user to enter their Biology result and reading the input
			Console.WriteLine("Enter your Biology result:");
			biology = Int32.Parse(Console.ReadLine());

			// Prompting the user to enter their Chemistry result and reading the input
			Console.WriteLine("Enter your Chemistry result:");
			chemistry = Int32.Parse(Console.ReadLine());

			// Checking if any two exam results are 90 or above, using logical OR operator (||)
			if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
			{
				// If any two exam results are 90 or above, print a congratulatory message
				Console.WriteLine("Congratulations! You got accepted!");
			}
			else
			{
				// If no combination of two exam results is 90 or above, print a message indicating that the application cannot be approved
				Console.WriteLine("Your application cannot be approved.");
			}
		}
	}
}
