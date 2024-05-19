// Importing the System namespace to access its classes and methods
using System;

// Defining the namespace SwitchDayOfTheWeek
namespace SwitchDayOfTheWeek
{
	// Defining the internal Program class
	internal class Program
	{
		// Defining the Main method
		static void Main(string[] args)
		{
			// Getting the current day of the week as an integer (0 for Sunday, 1 for Monday, ..., 6 for Saturday)
			int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

			// Using a switch statement to determine the day of the week based on the weekDay value
			switch (weekDay)
			{
				case 0:
					Console.WriteLine("It's Sunday!");
					break;
				case 1:
					Console.WriteLine("It's Monday!");
					break;
				case 2:
					Console.WriteLine("It's Tuesday!");
					break;
				case 3:
					Console.WriteLine("It's Wednesday!");
					break;
				case 4:
					Console.WriteLine("It's Thursday!");
					break;
				case 5:
					Console.WriteLine("It's Friday!");
					break;
				case 6:
					Console.WriteLine("It's Saturday!");
					break;
				default:
					Console.WriteLine("Oops. Your calendar must be broken!");
					break;
			}

			// Printing a message wishing the user a nice day
			Console.WriteLine("Have a nice day!");
		}
	}
}
