using System;

namespace IfdayOfTheWeekk
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Get the current day of the week as an integer (0 for Sunday, 1 for Monday, ..., 6 for Saturday)
			int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

			// Check the value of weekDay and print the corresponding day of the week
			if (weekDay == 0)
			{
				Console.WriteLine("It's Sunday!");
			}
			else if (weekDay == 1)
			{
				Console.WriteLine("It's Monday!");
			}
			else if (weekDay == 2)
			{
				Console.WriteLine("It's Tuesday!");
			}
			else if (weekDay == 3)
			{
				Console.WriteLine("It's Wednesday!");
			}
			else if (weekDay == 4)
			{
				Console.WriteLine("It's Thursday!");
			}
			else if (weekDay == 5)
			{
				Console.WriteLine("It's Friday!");
			}
			else
			{
				Console.WriteLine("It's Saturday!");
			}
		}
	}
}
