using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 3
//	File Name:         Dependent.cs
//	Description:       This class inherits from the person class and gets birth date
//	Course:            CSCI 2910	
//	Created:           Tuesday, May 25, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab3
{
    class Dependent : Person
    {
        public Dependent(string firstName, string lastName, DateTime birthDate, SSN ssn, Phone phone) : base(firstName, lastName, birthDate, ssn, phone)
        {
            DateTime end = new DateTime(2031, 05, 27);
            var today = DateTime.Today;
            Age = today.Year + end.Year;
            base.BirthDate = base.BirthDate; //today to 10 years from now 
           //dependent must be 10 years old
        }
    }
}
