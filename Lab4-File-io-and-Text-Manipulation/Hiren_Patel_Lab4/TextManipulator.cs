using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 4
//	File Name:         TextManipulator.cs
//	Course:            CSCI 2910	
//	Created:           Thursday, June 3, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//  Note:              All methods have specefic names and are named after exaclty what they are used for
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_Lab4
{
    public class TextManipulator : IDisposable
    {
        public List<string> Sentences { get; set; }
        Random rand = new Random();

        public string FilePath { get; set; }
        public string Text { get; set; }
        public string RandomSentence { get; set; }

        public TextManipulator(string text, bool isTextFilePath)
        {
            if (isTextFilePath)
            {
                this.FilePath = text;
                if (File.Exists(FilePath))
                {
                    this.Text = File.ReadAllText(FilePath);
                }
            }
            else
            {
                this.Text = text;
            }

            Sentences = GetSentencesFromText(Text);
            if (Sentences.Count < 2)
            {
                throw new Exception("Error. You need to have more than one sentence.");
            }

            SetRandomSentence();
        }

        private List<string> GetSentencesFromText(string text)
        {
            List<string> sentences = new List<string>();
            string currentSentence = "";
            foreach (var letter in text)
            {
                currentSentence += letter;
                if (IsEndOfSentence(letter))
                {
                    sentences.Add(currentSentence);
                    currentSentence = "";
                }
            }
            return sentences;
        }

        public bool IsEndOfSentence(char character)
        {
            return character == '!' || character == '?' || character == '.';
        }

        public void SetRandomSentence()
        {
            int index = rand.Next(Sentences.Count);
            RandomSentence = Sentences.ElementAt(index);
        }

        public string GetRandomWord()
        {
            var words = RandomSentence.Split(' ');
            int index = rand.Next(words.Length);

            string randomWord = words.ElementAt(index);
            return randomWord;
        }

        public int NumberOfWords()
        {
            var words = RandomSentence.Split(' ');
            return words.Length;
        }

        public string RemoveCharacters(char[] characters)
        {
            string newSentence = "";
            foreach (var letter in RandomSentence)
            {
                if (!characters.Contains(letter))
                {
                    newSentence += letter;
                }
            }
            return newSentence;
        }

        public Dictionary<char, int> GetCharacterCount()
        {
            Dictionary<char, int> charCount= new Dictionary<char, int>();

            foreach (var letter in RandomSentence)
            {
                if (charCount.ContainsKey(letter))
                {
                    charCount[letter] += 1;
                }
                else
                {
                    charCount.Add(letter, 1);
                }
            }
            return charCount;
        }

        public void Dispose()
        {
            Sentences.Clear();
        }
    }
}
