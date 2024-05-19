// Importing the System namespace to access its classes and methods
using System;

// Defining the namespace AndOp
namespace AndOp
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

			// Checking if the user's results meet the acceptance criteria
			if (math >= 90 && biology >= 90 && chemistry >= 90)
			{
				// If all three exam results are 90 or above, print a congratulatory message
				Console.WriteLine("Congratulations! You got accepted!");
			}
			else
			{
				// If any of the exam results are below 90, print a message indicating that the application cannot be approved
				Console.WriteLine("Your application cannot be approved.");
			}
		}
	}
}
