using System;
using System.IO;
using Hiren_Patel_lab6.Models;
using Microsoft.Data.Sqlite;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         Program.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootOfProjectString = Directory.GetParent
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();

            using (var connection = new SqliteConnection
                ($@"Data Source = {rootOfProjectString}/Data/database.sqlite"))
            {
                connection.Open();

                QueryBuilder query = new QueryBuilder(connection);

                Author author;

                ///**Read Method test**/
                //var test = query.Read<Author>(2);
                //Console.WriteLine(test.FirstName + " " + test.Surname);

                ///**ReadAll method test**/
                //var test = query.ReadAll<Author>();
                //Console.WriteLine(test.Count);

                ///**Create method test**/
                //query.Create(author = new Author(4, "J.K.", "Rowling"));
                //query.Create(author = new Author(5, "Wilson", "Rawls"));
                //query.Create(author = new Author(6, "Hiren", "Patel"));

                ///**Update method test**/
                //query.Update(author = new Author(5, "John", "Boyne"));

                ///**Delete method test***/
                //query.Delete(author = new Author(6, "Hiren", "Patel"));
                //query.Delete(author = new Author(5, "John", "Boyne"));
                //query.Delete(author = new Author(4, "J.K.", "Rowling"));

                connection.Close();
            }
        }
    }
}