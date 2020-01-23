using System;

namespace Lab_4___PowerTable
{
    class Program
    {
        static void Main(string[] args)
        {

            string userContinue = "y";

            while (userContinue != "n")
            {
                //ask for an integer
                Console.WriteLine("Please enter an integer.");
                //store user input as a variable
                int userInput = Verify();

                //create table
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======  =======  ======");

                //for loop to cycle thru how many iterations based on input
                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine($"{i}\t{Square(i)}\t{Cube(i)}");
                }

                //ask user if they want to try again
                //Validation to make sure they enter y or n
                userContinue = "";
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine("Would you like to try again? y/n");
                    userContinue = Console.ReadLine().ToLower();
                }
            }
        }

        //method to cube user input
        public static int Cube(int num1)
        {
            return num1 * num1 * num1;
        }

        //method to square user input
        public static int Square(int num1)
        {
            return num1 * num1;
        }

        //validate the user input is an integer
        public static int Verify()
        {
            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid Entry. Please enter a number.");
            }
            return value;
        }
    }

}
