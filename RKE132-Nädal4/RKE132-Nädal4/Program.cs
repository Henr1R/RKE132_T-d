using System;

namespace RKE132_Nädal4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Declaring and initializing a variable 'i' with value 0
			int i = 0;

			// Looping 5 times using a for loop
			for (i = 0; i < 5; i++)
			{
				// Printing the message "We don't need no education" each time the loop iterates
				Console.WriteLine("We don't need no education");
			}

			// Printing a closing message once the loop is finished
			Console.WriteLine("Have a nice day!");

			// Printing the final value of 'i' after the loop exits (which will be 5)
			Console.WriteLine(i);

		}
	}
}
