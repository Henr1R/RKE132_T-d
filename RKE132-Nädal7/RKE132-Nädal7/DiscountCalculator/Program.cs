using System;

namespace DiscountCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Prompt the user to enter a price
			Console.WriteLine("Enter the price: ");
			// Read the input integer representing the price
			int userInput = Int32.Parse(Console.ReadLine());

			// Calculate the discount percentage based on the price entered by the user
			double discount = CalculateDiscount(userInput);

			// Print the calculated discount percentage
			Console.WriteLine($"Your discount is: {discount}%");

			// Calculate the new price after applying the discount
			double newPrice = CalculateNewPrice(userInput, discount);
			// Print the new price and the applied discount percentage
			Console.WriteLine($"Your new price is: {newPrice} and the discount is {discount}%");

			// Function to calculate the discount percentage based on the total price
			static double CalculateDiscount(int total)
			{
				// Check if the total price is less than 10
				if (total < 10)
				{
					// If the total price is less than 10, return a discount of 1%
					return 1;
				}
				// Check if the total price is between 10 (inclusive) and 20 (exclusive)
				else if (total >= 10 && total < 20)
				{
					// If the total price is between 10 and 20, return a discount of 5%
					return 5;
				}
				// If the total price is 20 or more
				else
				{
					// Return a discount of 10%
					return 10;
				}
			}

			// Function to calculate the new price after applying the discount
			static double CalculateNewPrice(double total, double discount)
			{
				// Calculate the new price by subtracting the discount from the total price
				double result = total - (total * discount) / 100;
				// Return the calculated new price
				return result;
			}

		}
	}
}
