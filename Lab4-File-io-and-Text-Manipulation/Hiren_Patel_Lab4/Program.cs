using System;
using System.IO;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 4
//	File Name:         Program.cs
//	Course:            CSCI 2910	
//	Created:           Thursday, June 3, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This will take a text input or a file path 
             */
            Console.WriteLine("Enter text or file path to process.");
            string userInput = Console.ReadLine();
            bool isFile = File.Exists(userInput);

            TextManipulator textManipulator = new TextManipulator(userInput, isFile);

            /*
             * This tests all of the actions required for lab
             */
            Console.WriteLine("\nRandom sentence: " + textManipulator.RandomSentence);
            Console.WriteLine("\nRandom word: " + textManipulator.GetRandomWord());
            Console.WriteLine("\nNumber of words: " + textManipulator.NumberOfWords());
            Console.WriteLine("\nCharacter count: " + textManipulator.GetCharacterCount());

            Console.WriteLine("Enter some characters to remove (spaces will be removed as well)");
            Console.WriteLine(textManipulator.RemoveCharacters(Console.ReadLine().ToCharArray()));
            
        }
    }
    
}
