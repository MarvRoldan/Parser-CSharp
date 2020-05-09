using System;
using System.Linq;
using System.IO;

namespace C__Parser
{
    class Program
    {

        static void Main(string[] args)
        {
            string userchoice;
            string userFile = "userfile.txt";

            do
            {
                Console.WriteLine("Enter: 1 to access file. 2 to view file. 3 to end program.");
                userchoice = Console.ReadLine();
            } while (userchoice != "1" && userchoice != "2" && userchoice != "3");

            if (userchoice == "1")
            {   
                Console.WriteLine("Enter file name");
                Console.ReadLine();
            }
        }
    }
}
