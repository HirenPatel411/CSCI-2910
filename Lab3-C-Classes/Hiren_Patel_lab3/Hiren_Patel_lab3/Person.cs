using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 3
//	File Name:         Person.cs
//	Description:       This class creates an array of first names and gets all the properties of a person
//	Course:            CSCI 2910	
//	Created:           Tuesday, May 25, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab3
{
    class Person
    {
        public string[] _arrayOfFirstNames = { "Dwight", "Jim", "Ron", "Ricky", "Bruce", "Steve", "Dirk", "Dak", "Kevin", "Dhara" };
        public Dependent[] _dependents = new Dependent[10];

        private int age;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; init; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                age = today.Year - BirthDate.Year;
                return age;
            }
            set
            {
                age = value;
            }

        }

        public SSN SSN { get; set; }

        public Phone Phone { get; set; }

        public Person()
        {
            SSN = new SSN();
            Phone = new Phone();
        }

        public Person(string firstName, string lastName, DateTime birthDate, int age, SSN ssn, Phone phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Age = age;
            this.SSN = ssn;
            this.Phone = phone;
        }

        public Person(string firstName, string lastName, DateTime birthDate, SSN ssn, Phone phone)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            SSN = ssn;
            Phone = phone;
        }

        public void AddDependent()
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}