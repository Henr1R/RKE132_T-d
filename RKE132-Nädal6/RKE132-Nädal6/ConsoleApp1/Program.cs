using System;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Declaring an array 'puuvili' to store 3 strings (fruits)
			string[] puuvili = new string[3];

			// Assigning values to each element of the 'puuvili' array
			puuvili[0] = "õunad";
			puuvili[1] = "banaanid";
			puuvili[2] = "apelsinid";

			// Printing the values of the 'puuvili' array
			Console.WriteLine($"{puuvili[0]}, {puuvili[1]}, {puuvili[2]}");

			// Storing the length of the 'puuvili' array in the variable 'puuviliArrayPikkus'
			int puuviliArrayPikkus = puuvili.Length;

			// Printing the number of fruits in the 'puuvili' array
			Console.WriteLine($"There are {puuviliArrayPikkus} fruits in your list.");

			// Looping through each element of the 'puuvili' array
			for (int i = 0; i < puuviliArrayPikkus; i++)
			{
				// Capitalizing the first letter of each fruit name
				puuvili[i] = puuvili[i].Replace(puuvili[i][0], char.ToUpper(puuvili[i][0]));
			}

			// Iterating through each element of the 'puuvili' array and printing them
			foreach (string element in puuvili)
			{
				Console.WriteLine(element);
			}
		}
	}
}
