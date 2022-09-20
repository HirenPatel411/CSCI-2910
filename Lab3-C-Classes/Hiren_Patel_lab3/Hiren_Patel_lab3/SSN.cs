using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 3
//	File Name:         SSN.cs
//	Description:       This class creates a random INVALID SSN
//	Course:            CSCI 2910	
//	Created:           Tuesday, May 25, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab3
{
    class SSN
    {
        public string ssnNumber { get; set; }

        //Social security cannot begin in the 900 group.
        //https://primepay.com/blog/how-determine-valid-social-security-number#:~:text=An%20invalid%20SSN%20is%20one,four%20digits%20as%20%E2%80%9C0000.%E2%80%9D
        public SSN()
        {
            ssnNumber = "";
        }

        public override string ToString()
        {

            this.ssnNumber = ssnNumber.Substring(0, 3) + "-" + ssnNumber.Substring(3, 2) + "-" + ssnNumber.Substring(5, 4);
            return this.ssnNumber;

        }
    }
}
