using System;
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
                Console.WriteLine("Enter: 1 to access file. 2 to edit file. 3 to end program.");
                userChoice = Console.ReadLine();


                if (userChoice == "1" && File.Exists(userFile))
                {
                    Console.WriteLine("Enter file name");
                    userFileChoice = Console.ReadLine();

                    if (userFileChoice == "userfile")
                    {
                        Console.WriteLine("Select Option 2 to view and edit file.");
                    }
                    else
                    {
                        Console.WriteLine("No file found.");
                    }
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Enter new text:");
                    string userInput = Console.ReadLine();

                    File.WriteAllText("userfile.txt", userInput);
                }

            } while (userChoice != "3");
        }
    }
}
