using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         BooksOutOnLoan.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6.Models
{
    class BooksOutOnLoan : IClassModel
    {
        List<BooksOutOnLoan> listOfBooksOutOnLoan;
        public int Id { get; set; }
        public int BookId  { get; set; }
        public string DateIssued { get; set; }
        public string DueDate { get; set; }
        public string DateReturned { get; set; }

        /// <summary>
        /// Non-parameterized constructor
        /// </summary>
        public BooksOutOnLoan()
        {

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="BookId"></param>
        /// <param name="DateIssued"></param>
        /// <param name="DueDate"></param>
        /// <param name="DateReturned"></param>
        public BooksOutOnLoan(int Id, int BookId, string DateIssued, string DueDate, string DateReturned)
        {
            listOfBooksOutOnLoan = new List<BooksOutOnLoan>();
            this.Id = Id;
            this.BookId = BookId;
            this.DateIssued = DateIssued;
            this.DueDate = DueDate;
            this.DateReturned = DateReturned;
        }
    }
}
