using System;
using System.Collections.Generic;
using System.IO;

namespace RKE132_Nädal15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list to store Film objects
			List<Film> myMovies = new List<Film>();

			// Retrieve data from a file
			string[] data = GetDataFromFile();
			// Alternatively, you can call a method to read data from file: ReadData(data);

			// Loop through each line of data
			foreach (string line in data)
			{
				// Split each line by semicolon to separate movie title and release year
				string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

				// Create a new Film object with title and year
				Film newFilm = new Film(tempArray[0], tempArray[1]);

				// Add the Film object to the list
				myMovies.Add(newFilm);
			}

			// Display information about each film in the list
			foreach (Film film in myMovies)
			{
				Console.WriteLine($"My favorite film {film.Title} was released in {film.Year}.");
			}

			// Define a method to retrieve data from a file
			static string[] GetDataFromFile()
			{
				// Specify the location of the file
				string location = @"C:\Users\Henri\source\repos\RKE132-Nädal15\movies.txt";

				// Read all lines from the file and store them in an array
				string[] data = File.ReadAllLines(location);

				return data; // Return the array of lines
			}

			// Define a method to read and display data
			static void ReadData(string[] array)
			{
				// Loop through each element in the array and display it
				foreach (string line in array)
				{
					Console.WriteLine(line);
				}
			}
		}

// Define a Film class to represent movie information
class Film
		{
			string title; // Field to store movie title
			string year; // Field to store release year

			// Property to get movie title
			public string Title
			{
				get { return title; }
			}

			// Property to get release year
			public string Year
			{
				get { return year; }
			}

			// Constructor to initialize movie title and release year
			public Film(string _title, string _year)
			{
				title = _title;
				year = _year;
			}
		}

	}
}

