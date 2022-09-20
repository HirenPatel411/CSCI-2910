using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         Categories.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6.Models
{
    class Categories : IClassModel
    {
        List<Categories> listOfCategories;
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Non-parameterized constructor
        /// </summary>
        public Categories()
        {

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        public Categories(int Id, string Name)
        {
            listOfCategories = new List<Categories>();
            this.Id = Id;
            this.Name = Name;
        }
    }
}
