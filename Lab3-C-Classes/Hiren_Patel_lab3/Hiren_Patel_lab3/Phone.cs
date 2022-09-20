using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 3
//	File Name:         Phone.cs
//	Description:       This class formats a phone number and creates a random 10 digit phone number
//	Course:            CSCI 2910	
//	Created:           Tuesday, May 25, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab3
{
    class Phone
    {

        public string phoneNumber { get; set; }

        public Phone()
        {
            phoneNumber = "";
        }

        public string Format(string phoneNumber)
        {
            this.phoneNumber = phoneNumber.Substring(0, 3) + "-" + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6, 4);

            return this.phoneNumber;
        }

        public override string ToString()
        {

            return this.phoneNumber;

        }
    }
}
