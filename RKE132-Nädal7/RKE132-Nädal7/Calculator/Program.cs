using System;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Prompt the user to enter an operation symbol (+/-)
			Console.WriteLine("Enter an operation symbol (+/-):");
			// Read the input character representing the operation symbol
			char operationSymbol = Char.Parse(Console.ReadLine());

			// Prompt the user to enter the first number
			Console.WriteLine("Enter the first number:");
			// Read the input integer representing the first number
			int firstNum = Int32.Parse(Console.ReadLine());
			// Prompt the user to enter the second number
			Console.WriteLine("Enter the second number:");
			// Read the input integer representing the second number
			int secondNum = Int32.Parse(Console.ReadLine());

			// Switch statement to determine the operation based on the operation symbol entered by the user
			switch (operationSymbol)
			{
				// If the operation symbol is '+', call the Addition function
				case '+':
					Addition(firstNum, secondNum);
					break;
				// If the operation symbol is '-', call the Subtraction function
				case '-':
					Subtraction(firstNum, secondNum);
					break;
				// If the operation symbol is neither '+' nor '-', print an error message
				default:
					Console.WriteLine("Invalid operation symbol");
					break;
			}

			// Function to perform addition
			static void Addition(int a, int b)
			{
				// Print the addition operation result
				Console.WriteLine($"{a} + {b} = {a + b}");
			}

			// Function to perform subtraction
			static void Subtraction(int a, int b)
			{
				// Print the subtraction operation result
				Console.WriteLine($"{a} - {b} = {a - b}");
			}
		}
	}
}
