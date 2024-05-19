using System;
using System.Data.SQLite;
using System.Runtime.Versioning;

namespace RKE132_Nädal13
{
	internal class Program
	{
		static void Main(string[] args)
		{


			ReadData(CreateConnection());
			InsertCustomer(CreateConnection());
			RemoveCustomer(CreateConnection());
			FindCustomer(CreateConnection());

			static SQLiteConnection CreateConnection()
			{
				// Create a connection to the SQLite database
				SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Henri\\source\\repos\\RKE132-Nädal13\\mydb.db; Version=3; New=True; Compress=True;");

				try
				{
					// Try to open the connection
					connection.Open();
					Console.WriteLine("DB found.");
				}
				catch
				{
					// Handle if the connection cannot be opened
					Console.WriteLine("DB not found.");
				}

				return connection;
			}

			static void ReadData(SQLiteConnection myConnection)
			{
				// Clear the console before displaying data
				Console.Clear();

				// Initialize SQLiteDataReader and SQLiteCommand
				SQLiteDataReader reader;
				SQLiteCommand cmd;

				// Create a command to select data from the "customer" table
				cmd = myConnection.CreateCommand();
				cmd.CommandText = "SELECT rowid, * FROM customer";

				// Execute the command and get the reader
				reader = cmd.ExecuteReader();

				// Iterate through the reader and display the data
				while (reader.Read())
				{
					string readerRowId = reader["rowid"].ToString();
					string readerStringFirstName = reader.GetString(1);
					string readerStringLastName = reader.GetString(2);
					string readerStringStatus = reader.GetString(3);

					Console.WriteLine($"{readerRowId}. Full name: {readerStringFirstName} {readerStringLastName}; Birthdate: {readerStringStatus}");
				}

				// Close the connection
				myConnection.Close();
			}

			static void InsertCustomer(SQLiteConnection myConnection)
			{
				// Initialize SQLiteCommand
				SQLiteCommand cmd;
				string fName, lName, dob;

				// Get user input for customer details
				Console.WriteLine("Enter your first name:");
				fName = Console.ReadLine();
				Console.WriteLine("Enter your last name:");
				lName = Console.ReadLine();
				Console.WriteLine("Enter your birthdate (mm-dd-yyyy):");
				dob = Console.ReadLine();

				// Create a command to insert data into the "customer" table
				cmd = myConnection.CreateCommand();
				cmd.CommandText = $"INSERT INTO customer(firstName, lastName, dateOfBirth) " +
					$"VALUES ('{fName}', '{lName}', '{dob}')";

				// Execute the command and get the number of rows affected
				int rowsInserted = cmd.ExecuteNonQuery();
				Console.WriteLine($"Rows inserted: {rowsInserted}");

				// Display the updated data
				ReadData(myConnection);
			}

			static void RemoveCustomer(SQLiteConnection myConnection)
			{
				// Initialize SQLiteCommand
				SQLiteCommand cmd;

				// Get the row id to delete from the user
				Console.WriteLine("Enter the row id to delete:");
				string idToDelete = Console.ReadLine();

				// Create a command to delete data from the "customer" table
				cmd = myConnection.CreateCommand();
				cmd.CommandText = $"DELETE FROM customer WHERE rowid = {idToDelete}";

				// Execute the command and get the number of rows affected
				int rowsRemoved = cmd.ExecuteNonQuery();
				Console.WriteLine($"{rowsRemoved} removed from the list.");

				// Display the updated data
				ReadData(myConnection);
			}

			static void FindCustomer(SQLiteConnection myConnection)
			{
				// Initialize SQLiteDataReader and SQLiteCommand
				SQLiteDataReader reader;
				SQLiteCommand cmd;
				string searchName;

				// Get the first name of the person to search for from the user
				Console.WriteLine("Enter the first name of the person you are searching for:");
				searchName = Console.ReadLine();

				// Create a command to search for the customer in the database
				cmd = myConnection.CreateCommand();
				cmd.CommandText = $"SELECT customer.rowid, customer.firstName, customer.lastName, status.statusType " +
					$"FROM customerStatus " +
					$"JOIN customer ON customer.rowid = customerStatus.customerId " +
					$"WHERE firstname LIKE '{searchName}'";

				// Execute the command and get the reader
				reader = cmd.ExecuteReader();

				// Iterate through the reader and display the search result
				while (reader.Read())
				{
					string readerRowId = reader["rowid"].ToString();
					string readerStringName = reader.GetString(1);
					string readerStringLastName = reader.GetString(2);
					string readerStringStatus = reader.GetString(3);
					Console.WriteLine($"Search result: ID: {readerRowId}. {readerStringName}. {readerStringLastName}. Status: {readerStringStatus}");
				}

				// Close the connection
				myConnection.Close();
			}

		}
	}
}
