using System;
using System.IO;

namespace RKE132_Nädal8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Define the file paths for the heroes and villains files
			string location = @"C:\Users\Henri\Desktop\Progemine\RKE132- Nädal8";
			string heroFile = "heroes.txt";
			string villainFile = "villains.txt";

			// Read the lines from the heroes and villains files
			string[] heroes = File.ReadAllLines(Path.Combine(location, heroFile));
			string[] villains = File.ReadAllLines(Path.Combine(location, villainFile));

			// Define an array of weapons
			string[] weapons = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };

			// Get a random hero from the heroes arraysd
			string hero = GetRandomValueFromArray(heroes);
			// Get a random weapon from the weapons array
			string heroWeapon = GetRandomValueFromArray(weapons);
			// Get the HP of the hero
			int heroHP = GetCharacterHp(hero);
			// Set the hero's strike strength to its HP
			int heroStrikeStrength = heroHP;
			// Print the hero's information
			Console.WriteLine($"Today {hero} ({heroHP}HP) with {heroWeapon} saves the day!");

			// Get a random villain from the villains array
			string villain = GetRandomValueFromArray(villains);
			// Get a random weapon from the weapons array
			string villainWeapon = GetRandomValueFromArray(weapons);
			// Get the HP of the villain
			int villainHP = GetCharacterHp(villain);
			// Set the villain's strike strength to its HP
			int villainStrikeStrength = villainHP;
			// Print the villain's information
			Console.WriteLine($"Today {villain} ({villainHP}HP) with {villainWeapon} tries to take over the world!");

			// Loop until either the hero or the villain's HP reaches 0
			while (heroHP > 0 && villainHP > 0)
			{
				// Reduce the hero's HP by the villain's strike strength
				heroHP -= Hit(villain, villainStrikeStrength);
				// Reduce the villain's HP by the hero's strike strength
				villainHP -= Hit(hero, heroStrikeStrength);
			}

			// Print the final HP of the hero and the villain
			Console.WriteLine($"Hero {hero} HP: {heroHP}");
			Console.WriteLine($"Villain {villain} HP: {villainHP}");

			// Determine the winner based on the final HP values
			if (heroHP > 0)
			{
				Console.WriteLine($"{hero} saves the day!");
			}
			else if (villainHP > 0)
			{
				Console.WriteLine($"Dark side wins!");
			}
			else
			{
				Console.WriteLine("Draw!");
			}

			// Function to get a random value from an array
			static string GetRandomValueFromArray(string[] array)
			{
				Random rnd = new Random();
				int randomIndex = rnd.Next(0, array.Length);
				return array[randomIndex];
			}

			// Function to calculate the HP of a character
			static int GetCharacterHp(string characterName)
			{
				return characterName.Length < 10 ? 10 : characterName.Length;
			}

			// Function to calculate the hit damage
			static int Hit(string characterName, int characterHP)
			{
				Random rnd = new Random();
				int strike = rnd.Next(0, characterHP);

				if (strike == 0)
				{
					Console.WriteLine($"{characterName} missed the target!");
					return strike;
				}
				else if (strike == characterHP - 1)
				{
					Console.WriteLine($"{characterName} made a critical hit!");
				}
				else
				{
					Console.WriteLine($"{characterName} hit {strike}!");
				}

				return strike;
			}

		}
	}
}