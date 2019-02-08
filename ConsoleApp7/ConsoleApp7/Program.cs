using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {

        public static int ValidateUserInput(string triangleside)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {triangleside} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again. \n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Number cannot be less than 0, please try again. \n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {triangleside} of your rectangle is {number} \n");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                do
                {
                    Console.WriteLine("1 = Enter Triangle Dimensions");
                    Console.WriteLine("2 = Exit\n");

                    Console.WriteLine("Please select an option, by entering a number:\n");
                    userInput = Console.ReadLine();

                    if (userInput != "1" &&
                         userInput != "2")
                    {
                        Console.WriteLine("That's not a valid menu option, please try again:\n");
                    }
                    else if (userInput == "1")
                    {
                        validMenuSelect = true;

                        int side1;
                        int side2;
                        int side3;


                        side1 = ValidateUserInput(" side1");
                        side2 = ValidateUserInput(" side2");
                        side3 = ValidateUserInput(" side3");


                        Console.WriteLine($"Your triangle sides is {side1} {side2} {side3} \n");
                        Console.WriteLine("Your triangle is {0} \n", Trianglesolver.analyze(side1, side2, side3));
                        Console.ReadLine();
                    }

                    else if (userInput == "2")
                    {
                        break;
                    }
                } while (userInput != "2");
            }
        }
    }
}


















                