using System;
using System.Collections.Generic;
using System.IO;

namespace RKE132_Nädal9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Define the folder location and file name
			string folderLocation = @"C:\Users\Henri\Desktop\Progemine\RKE132- Nädal8";
			string fileName = "shoppinglist.txt";
			string filePath = Path.Combine(folderLocation, fileName);

			// Create a new list to store the shopping list items
			List<string> shoppingList = new List<string>();

			// Check if the file exists
			if (File.Exists(filePath))
			{
				// If the file exists, get user input for the shopping list and write it to the file
				shoppingList = GetUserInput();
				File.WriteAllLines(filePath, shoppingList);
			}
			else
			{
				// If the file doesn't exist, create it and notify the user
				File.Create(filePath).Close();
				Console.WriteLine($"File {fileName} has been created.");
				// Get user input for the shopping list and write it to the file
				shoppingList = GetUserInput();
				File.WriteAllLines(filePath, shoppingList);
			}

			// Function to get user input for the shopping list
			static List<string> GetUserInput()
			{
				List<string> userInputList = new List<string>();

				while (true)
				{
					Console.WriteLine("Add item (add) / Close (close):");
					string userChoice = Console.ReadLine();

					if (userChoice == "add")
					{
						Console.WriteLine("Enter item:");
						string userItem = Console.ReadLine();
						userInputList.Add(userItem);
					}
					else
					{
						Console.WriteLine("Goodbye!");
						break;
					}
				}
				return userInputList;
			}

			// Function to display the shopping list
			static void DisplayList(List<string> list)
			{
				Console.Clear();

				int listLength = list.Count;
				Console.WriteLine($"You have added {listLength} items to your list.");

				int i = 1;
				foreach (string item in list)
				{
					Console.WriteLine($"{i}. {item}");
					i++;
				}
			}

		}
	}
}
