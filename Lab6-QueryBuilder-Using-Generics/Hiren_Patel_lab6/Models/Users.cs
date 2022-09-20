using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         Users.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6.Models
{
    class Users : IClassModel
    {
        List<Users> listOfUsers;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string OtherUserDetails { get; set; }
        public int AmountOfFine { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Non-parameterized constructor
        /// </summary>
        public Users()
        {

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="UserName"></param>
        /// <param name="UserAddress"></param>
        /// <param name="OtherUserDetails"></param>
        /// <param name="AmountOfFine"></param>
        /// <param name="Email"></param>
        /// <param name="PhoneNumber"></param>
        public Users(int Id, string UserName, string UserAddress, string OtherUserDetails, int AmountOfFine, string Email, string PhoneNumber)
        {
            listOfUsers = new List<Users>();
            this.Id = Id;
            this.UserName = UserName;
            this.UserAddress = UserAddress;
            this.OtherUserDetails = OtherUserDetails;
            this.AmountOfFine = AmountOfFine;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;

        }
    }
}
