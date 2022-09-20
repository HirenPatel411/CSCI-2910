using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 5
//	File Name:         Program.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 15, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab5
{
    class Program
    {
        /// <summary>
        /// Runs program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ReadDatabase();
        }

        /// <summary>
        /// This method gets the root of the project, opens the connections, and displays the database values
        /// </summary>
        public static void ReadDatabase()
        {
            //Getting the root directory 
            var rootOfProjectString = Directory.GetParent
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();

            rootOfProjectString += @"/Data/database.sqlite";

            using (var connection = new SqliteConnection
                ($@"Data Source = {rootOfProjectString};"))
            {
                connection.Open();

                //Formats User Table
                Console.WriteLine("****Users****");
                Console.WriteLine("\nID\t UserName\t UserAddress\t         OtherUserDetails    AmountOfFine\t Email\t\t PhoneNumber\n");
                var table1Values = GetDatabaseValues(connection, "Users");
                DisplayDatabaseValues(table1Values);

                //Formats BooksOutOnLoan Table
                Console.WriteLine("\n\n****BookOutOfLoan****");
                Console.WriteLine("\nID\t BookID\t DateIssued\t\t DueDate\t\t DateReturned\n");
                var table2Values = GetDatabaseValues(connection, "BooksOutOnLoan");
                DisplayDatabaseValues(table2Values);

                //Formats Categories Table
                Console.WriteLine("\n\n****Categories****");
                Console.WriteLine("\nID\t Genre\n");
                var table5Values = GetDatabaseValues(connection, "Categories");
                DisplayDatabaseValues(table5Values);

                //Formats Books Table
                Console.WriteLine("\n\n****Books****");
                Console.WriteLine("\nID\t Title\t\t\t ISBN\t\t\t DateOfPublication\n");
                var table3Values = GetDatabaseValues(connection, "Books");
                DisplayDatabaseValues(table3Values);

                //Formats Author Table
                Console.WriteLine("\n\n****Author****");
                Console.WriteLine("\nID\t FirstName\t Surname\n");
                var table4Values = GetDatabaseValues(connection, "Author");
                DisplayDatabaseValues(table4Values);


            }
        }

        /// <summary>
        /// This method displays the database values from the list of dictionaries
        /// </summary>
        /// <param name="table"></param>
        public static void DisplayDatabaseValues(List<Dictionary<int, string>> table)
        {
            foreach (var attribute in table)
            {
                foreach (var row in attribute.Values)
                {
                    Console.WriteLine(row);
                }
            }
        }

        /// <summary>
        /// This method gets the database values
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="tableName"></param>
        /// <returns>The list of dictionaries</returns>
        public static List<Dictionary<int, string>> GetDatabaseValues(SqliteConnection connection, string tableName)
        {
            var sql = "Select * from " + tableName;
            var cmd = new SqliteCommand(sql, connection);
            List<Dictionary<int, string>> dict = new List<Dictionary<int, string>>();

            using (var reader = cmd.ExecuteReader())
            {
                int i = 0;
                while (reader.Read())
                {
                    var attributeValues = new Dictionary<int, string>();

                    // create a list and give it default values. The number of default values needs to be the same as reader.FieldCount
                    List<object> rowValues = new List<object>();
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        rowValues.Add(default);
                    }

                    //Overrides default values in array
                    var array = rowValues.ToArray();
                    reader.GetValues(array);

                    // Format the entire row into a string
                    string wholeRow = "";
                    foreach (var value in array)
                    {
                        wholeRow += value + " \t| ";
                    }

                    //Adds dictionary values and returns it
                    attributeValues.Add(i, wholeRow);
                    dict.Add(attributeValues);
                    i++;
                }
            }
            return dict;
        }
    }
}
