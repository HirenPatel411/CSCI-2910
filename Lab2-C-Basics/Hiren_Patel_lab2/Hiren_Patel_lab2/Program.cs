using System;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 2
//	File Name:         Program.cs
//	Description:       This class executes 4 problems
//	Course:            CSCI 2910	
//	Created:           Wednesday, May 26, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//  
//  Notes: If user presses <enter> without putting any values into the question numbers the program will stop.
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab2
{
    class Program
    {
        /// <summary>
        /// Executes through lab 2
        /// </summary>
        /// <value></value>
        static void Main(string[] args)
        {
            Lab2();
        }

        /// <summary>
        /// This method dsiaplays a welcome message at the beginning
        /// </summary>
        /// <value></value>
        public static void Welcome()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hiren M. Patel");
            Console.WriteLine("CSCI-2910");
            Console.Write(DateTime.Now);
            Console.WriteLine("\n\nPlease enjoy my program!");
        }

        /// <summary>
        /// This method runs the whole lab 2 and runs questions 1-4
        /// </summary>
        /// <value></value>
        public static void Lab2()
        {
            Welcome();

            //Console.ReadKey Method used from microsoft docs
            //https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
            Console.Write("\n\nPress <Enter> to continue... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }

            string userOption;  //variable for users question option

            while(true)
            {
                Console.Clear();    //clears the window
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("\n1. Question 1: Sum of Two");
                Console.WriteLine("\n2. Question 2: Multiplication Table");
                Console.WriteLine("\n3. Question 3: Number Types Table");
                Console.WriteLine("\n4. Question 4: Five Function Calculator");
                Console.WriteLine("\n5. End Lab 2");
                Console.WriteLine("\n----------------------------");
                Console.Write("\r\nQuestion Number: ");

              
                    userOption = Console.ReadLine();    //This takes the users input and puts it in a readline

                switch (userOption)
                {
                    case "1":
                        /*
                         * 1. Print the output of adding two numbers from user input
                         */
                        int input1;     //First number user inputted
                        int input2;     //Second number user inputted

                        Console.Clear();
                        Console.WriteLine("Please enter the first number and press <Enter>.");
                        input1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nPlease enter the second number and press <Enter>.");
                        input2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nThe sum of both numbers are\n{input1 + input2}");

                        //Console.ReadKey Method used from microsoft docs
                        //https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
                        Console.Write("\n\nPress <Enter> to continue... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {
                        }
                        break;

                    case "2":
                        /*
                         * 2. Take a user’s input number and input its multiplication table. The user can choose how high to multiply by.
                         */
                        int num;            //Number user chose to see multiplication taable 
                        int maxNumber;      //The maximum range of multiplication table

                        Console.Clear();
                        Console.WriteLine("Please enter a number and press <Enter>.");
                        num = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nPlease enter a number to choose how high to multiply and press <Enter>.");
                        maxNumber = int.Parse(Console.ReadLine());

                        //This for loop takes the first number and continuously multiply the seconnd number inputted 
                        for (int i = 1; i <= maxNumber; ++i)
                        {
                            Console.WriteLine($"\n{num} * {i} = {num * i} \n");
                        }

                        //Console.ReadKey Method used from microsoft docs
                        //https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
                        Console.Write("\n\nPress <Enter> to continue... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {
                        }
                        break;

                    case "3":
                        /*
                         * 3. Output the number of bytes in memory that each of the following number types uses, and the
                              minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float,
                              double, and decimal.
                         */
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Type\tBytes of Memory\t\tMin\t\t\t\t\tMax");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"sbyte\t{sizeof(sbyte)}\t\t\t{sbyte.MinValue}\t\t\t\t\t{sbyte.MaxValue}");
                        Console.WriteLine($"byte\t{sizeof(byte)}\t\t\t{byte.MinValue}\t\t\t\t\t{byte.MaxValue}");
                        Console.WriteLine($"short\t{sizeof(short)}\t\t\t{short.MinValue}\t\t\t\t\t{short.MaxValue}");
                        Console.WriteLine($"ushort\t{sizeof(ushort)}\t\t\t{ushort.MinValue}\t\t\t\t\t{ushort.MaxValue}");
                        Console.WriteLine($"int\t{sizeof(int)}\t\t\t{int.MinValue}\t\t\t\t{int.MaxValue}");
                        Console.WriteLine($"uint\t{sizeof(uint)}\t\t\t{uint.MinValue}\t\t\t\t\t{uint.MaxValue}");
                        Console.WriteLine($"long\t{sizeof(long)}\t\t\t{long.MinValue}\t\t\t{long.MaxValue}");
                        Console.WriteLine($"ulong\t{sizeof(ulong)}\t\t\t{ulong.MinValue}\t\t\t\t\t{ulong.MaxValue}");
                        Console.WriteLine($"float\t{sizeof(float)}\t\t\t{float.MinValue}\t\t\t\t{float.MaxValue}");
                        Console.WriteLine($"double\t{sizeof(double)}\t\t\t{double.MinValue}\t\t{double.MaxValue}");
                        Console.WriteLine($"decimal\t{sizeof(decimal)}\t\t\t{decimal.MinValue}\t\t{decimal.MaxValue}");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");

                        //Console.ReadKey Method used from microsoft docs
                        //https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
                        Console.Write("\n\nPress <Enter> to continue... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {
                        }
                        break;

                    case "4":
                        /*
                         * 4. Create a 5 function (+, -, *, /, and modulus) calculator. This calculator should loop until ‘esc’ is typed.
                              Example, I should be asked for num 1, then some operation (+, -, *, /, and modulus) to another num 2.
                              Provide the results, and then provide a way to esc the program or do another operation (+, -, *, /, and
                              modulus) to the result
                         */
                        double num1;    //Users input for first number
                        double num2;    //Users input for second number
                        bool backToMenu = false; 

                            Console.Clear();
                            Console.WriteLine("\nPlease enter the first number and press <Enter>.");
                            num1 = double.Parse(Console.ReadLine());

                            Console.WriteLine("\nPlease enter the second number and press <Enter>.");
                            num2 = double.Parse(Console.ReadLine());

                        while (!backToMenu)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("Welcome to number 4!");
                            Console.WriteLine("\nREMEMBER TO PRESS <ESC> TO CLEAR AND RETURN TO CALCULATOR\n");
                            Console.WriteLine("\nIF ANY OTHER KEY IS PRESSED THE SAME ANSWER WILL BE DISPLAYED");
                            Console.WriteLine("\nIf you press <Enter> before typing in the operation of your choice, you will be sent back to the main menu.");
                            Console.WriteLine("\n----------------------------");
                            Console.WriteLine("\n1. Addition");
                            Console.WriteLine("\n2. Subtraction");
                            Console.WriteLine("\n3. Multiplication");
                            Console.WriteLine("\n4. Division");
                            Console.WriteLine("\n5. Modulus");
                            Console.WriteLine("\n6. Back to Menu");
                            Console.WriteLine("\n----------------------------");
                            Console.Write("\r\nOperation: ");


                            string userOperation = Console.ReadLine();

                            switch (userOperation)
                            {
                                case "1":
                                    while (true)
                                    {
                                        Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}\n");
                                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                        {
                                            break;
                                        }

                                    }
                                    break;


                                case "2":
                                    while (true)
                                    {
                                        Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}\n");
                                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                        {
                                            break;
                                        }

                                    }
                                    break;

                                case "3":
                                    while (true)
                                    {
                                        Console.WriteLine($"\n{num1} * {num2} = {num1 * num2}\n");
                                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                        {
                                            break;
                                        }

                                    }
                                    break;

                                case "4":
                                    while (true)
                                    {
                                        Console.WriteLine($"\n{num1} / {num2} = {num1 / num2}\n");
                                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                        {
                                            break;
                                        }

                                    }
                                    break;

                                case "5":
                                    while (true)
                                    {
                                        Console.WriteLine($"\n{num1} % {num2} = {num1 % num2}\n");
                                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                        {
                                            break;
                                        }

                                    }
                                    break;

                                case "6":
                                default:
                                    backToMenu = true;
                                    break;
                            }
                            
                        }       

                        //Console.ReadKey Method used from microsoft docs
                        //https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
                        Console.Write("\n\nPress <Enter> to go to the menu... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {
                        }
                        break;

                    /*
                     * Prints out a goodbye screen
                     */
                    case "5":
                        Console.Clear();
                        Console.WriteLine("\nThank you for exploring my lab 2 and have a wondeful day!");

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
