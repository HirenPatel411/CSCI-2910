using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         Author.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6.Models
{
    class Author : IClassModel
    {
        List<Author> listOfAuhor;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// Non-parameterized constructor
        /// </summary>
        public Author()
        {
                
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="FirstName"></param>
        /// <param name="Surname"></param>
        public Author(int Id, string FirstName, string Surname)
        {
            listOfAuhor = new List<Author>();
            this.Id = Id;
            this.FirstName = FirstName;
            this.Surname = Surname;
        }

    }
}
