﻿using System;
using System.Linq;
using System.IO;

namespace C__Parser
{
    class Program
    {

        static void Main(string[] args)
        {
            string userChoice;
            string userFileChoice;
            string userFile = "userfile.txt";

            do
            {
                Console.WriteLine("Enter: 1 to access file. 2 to view file. 3 to end program.");
                userChoice = Console.ReadLine();


                if (userChoice == "1")
                {
                    Console.WriteLine("Enter file name");
                    userFileChoice = Console.ReadLine();

                    if (userFileChoice == "userfile")
                    {
                        Console.WriteLine("Select Option 2 to view file.");
                    }
                    else
                    {
                        Console.WriteLine("No file found.");
                    }
                }
                else if (userChoice == "2" && File.Exists(userFile))
                {
                    string userInput = Console.ReadLine();

                    File.WriteAllText("userfile.txt", userInput);


                }

            } while (userChoice != "1" && userChoice != "2" && userChoice != "3");

        }
    }
}
