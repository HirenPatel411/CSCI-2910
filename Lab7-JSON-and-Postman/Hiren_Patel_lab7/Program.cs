using System;
using System.IO;
using System.Text.Json;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 7
//	File Name:         Program.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 28, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab7
{
    class Program
    {
        /// <summary>
        /// Deserializes and Serializes using system.json
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var book1 = DeserializeJSON(Environment.CurrentDirectory + "\\thug notes_response.json");
            var book2 = DeserializeJSON(Environment.CurrentDirectory + "\\harry potter goblet fire_response.json");
            var book3 = DeserializeJSON(Environment.CurrentDirectory + "\\flowers for algernon_response.json");
            var book4 = DeserializeJSON(Environment.CurrentDirectory + "\\divergent_response.json");
            var book5 = DeserializeJSON(Environment.CurrentDirectory + "\\art of war_response.json");
        }

        /// <summary>
        /// Deserializes and returns the json object
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static object DeserializeJSON(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var book = JsonSerializer.Deserialize<object>(json);
            return book;
        }
    }
}
