using System;

namespace C__Parser
{
    class Program
    {
        static void userChoice()
        {
            string userchoice;

            do
            {
                Console.WriteLine("Enter: 1 to access file. 2 to edit file. 3 to end program");
                userchoice = Console.ReadLine();
            } while (userchoice != "1" && userchoice != "2" && userchoice != "3");

        }
        static void Main(string[] args)
        {
            userChoice();


        }
    }
}
