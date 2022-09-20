using System;
using System.Collections.Generic;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 3
//	File Name:         Program.cs
//	Description:       This class runs the entire lab and displays menu
//	Course:            CSCI 2910	
//	Created:           Tuesday, May 25, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            Random rand = new Random();

            string userOption = "";
            int inputNum;

            while(true)     
            {
                Console.WriteLine("\n\nHello! Press <Enter> after typing in option");
                Console.WriteLine(" ");
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("\n1. Create a person");
                Console.WriteLine("\n2. View all persons");
                Console.WriteLine("\n3. Remove a person");
                Console.WriteLine("\n4. Show random last name");
                Console.WriteLine("\n5. Show random SSN");
                Console.WriteLine("\n6. Show random phone number");
                Console.WriteLine("\n7. End Lab 3");
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("\r\nEnter Option: ");
                userOption = Console.ReadLine();

                switch(userOption)
                {
                    case "1": 
                    {
                    person.Add(new Person());

                    //Random first name
                    int firstNameIndex = rand.Next(0, 10);
                    string randomFirstName = person[person.Count - 1]._arrayOfFirstNames[firstNameIndex];

                    // This code adapted from Stack Overflow. Source: (https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration)
                    Array values = Enum.GetValues(typeof(LastName));
                    LastName randomLastNameEnum = (LastName)values.GetValue(rand.Next(values.Length));
                    //Random last name
                    string randomLastName = randomLastNameEnum.ToString();
                    person[person.Count - 1].LastName = randomLastNameEnum.ToString();

                    //Random SSN
                    double ssnNumber = rand.NextDouble() * (9090909090 - 9000000000) + 900000000;
                            SSN ssn = new SSN();
                    ssn.ssnNumber = ssnNumber.ToString();

                    // Random Phone
                    // Source for random number: https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
                    double phoneNumber = rand.NextDouble() * (9999999999 - 2000000000) + 2000000000;
                    Phone phone = new Phone();
                    string phoneStr = phoneNumber.ToString();
                    phone.phoneNumber = phone.Format(phoneStr);

                    person[person.Count - 1].FirstName = randomFirstName;
                    person[person.Count - 1].LastName = randomLastName;
                    person[person.Count - 1].SSN.ssnNumber = ssn.ssnNumber;
                    person[person.Count - 1].Phone.phoneNumber = phone.phoneNumber;

                    break;
                }
                    case "2":
                    { 
                    Console.WriteLine("\n\n****LIST****");
                    for (int i = 0; i < person.Count; i++)
                    {
                        Console.WriteLine("\n\n" + person[i].FirstName + " " + person[i].LastName);
                        Console.WriteLine("\n" + person[i].BirthDate);
                        Console.WriteLine("\n" + person[i].Age);
                        Console.WriteLine("\n" + person[i].SSN);
                        Console.WriteLine("\n" + person[i].Phone);
                    }
                    Console.WriteLine("\n\n****LIST****");
                    break;
                }
                    case "3":
                    {
                        person.RemoveAt(person.Count - 1);
                        break;
                    }
                    case "4":
                    {
                         rand = new Random();
                         int lastNameIndex = rand.Next(0, person.Count);

                         Console.WriteLine("Your random last name is: " + person[lastNameIndex].LastName);
                         break;
                    }
                    case "5":
                    {
                         rand = new Random();
                         int ssnIndex = rand.Next(0, person.Count);

                         Console.WriteLine("Your random SSN is: " + person[ssnIndex].SSN.ToString());
                         break;
                    }
                    case "6":
                        {
                            rand = new Random();
                            int phoneIndex = rand.Next(0, person.Count);

                            Console.WriteLine("Your random phone number is: " + person[phoneIndex].Phone);
                            break;
                        }
                    case "7":
                        Console.Clear();
                        Console.WriteLine("\nThank you for exploring my lab 3 and have a wondeful day!");

                        Console.Write("\n\nPress Enter to stop program.");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {
                        }
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                }
            }
            
        }

    }
}