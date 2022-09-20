using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         Books.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6.Models
{
    class Books : IClassModel
    {
        List<Books> listOfBooks;
        public int Id { get; set; }
        public string Title { get; set; }
        public int Isbn { get; set; }
        public string DateOfPublication { get; set; }

        /// <summary>
        /// Non-parameterized constructor
        /// </summary>
        public Books()
        {

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Title"></param>
        /// <param name="Isbn"></param>
        /// <param name="DateOfPublication"></param>
        public Books(int Id, string Title, int Isbn, string DateOfPublication)
        {
            listOfBooks = new List<Books>();
            this.Id = Id;
            this.Title = Title;
            this.Isbn = Isbn;
            this.DateOfPublication = DateOfPublication;
        }
    }
}
