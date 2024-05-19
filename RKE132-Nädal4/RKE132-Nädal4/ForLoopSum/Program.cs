using System;

namespace ForLoopSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;

			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine($"i = {i}");
				Console.WriteLine($"Current total: {sum}");
				sum = sum + i;
			}

			Console.WriteLine($"Final total {sum}");
		}
	}
}
