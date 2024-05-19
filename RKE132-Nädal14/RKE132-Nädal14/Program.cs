using System;

namespace RKE132_Nädal14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your pet's name:");
			string petName = Console.ReadLine();
			Pet myPet = new Pet(petName);

			Pet neighborDog = new Pet("Loona");

			Console.WriteLine($"My pet's name is {myPet.Name}.");
			Console.WriteLine($"My neighbor's pet's name is {neighborDog.Name}.");

			myPet.Rename("KOEER");

			while (myPet.Happiness != 5)
			{
				myPet.Bark();
			}

			myPet.WagTail();
		}

		class Pet
		{
			private string _name = "Pet";
			private int _happiness = 0;

			public Pet(string name)
			{
				_name = name;
				_happiness = 0;
			}

			public string Name
			{
				get { return _name; }
			}
			public int Happiness
			{
				get { return _happiness; }
			}

			public void Rename(string newName)
			{
				_name = newName;
				Console.WriteLine($"Your pet's new name is: {newName}");
			}

			public void Bark()
			{
				Console.WriteLine("Woof-Woof");
				_happiness++;
			}

			public void WagTail()
			{
				Console.WriteLine("wiggle-wiggle!");
			}
		}

	}
}
