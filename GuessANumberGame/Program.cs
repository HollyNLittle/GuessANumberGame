using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber;
            int guessedNumber = 0;
            string input;
            string answer = "Y";
            GetAppInfo();
            GreetUser();


            //Does the user want to play again?
            while (true)
            {


                //set correctNumber to a random number between 1 and 10
                Random randomNumber = new Random();
                correctNumber = randomNumber.Next(1, 10);

                //Ask user to guess a number
                Console.WriteLine("Guess a number between one and ten.");

                //If user's guess is wrong
                while (guessedNumber != correctNumber)
                {
                    input = Console.ReadLine();
                    
                    //validation: did the user enter a number?
                    if (!int.TryParse(input, out guessedNumber))
                    {
                        //Call method to change text color, write message, reset color
                        PrintColorMessage(ConsoleColor.Magenta, "Please enter a number.");
                    }


                    else if (guessedNumber != correctNumber)
                    {
                        guessedNumber = Int32.Parse(input);
                        //Change text color, write message, reset color
                        PrintColorMessage(ConsoleColor.Red, "Sorry, but that was the wrong number. Please try again.");
                    }
                }

                //If user's guess is right
                //Change text color, write message, reset color
                PrintColorMessage(ConsoleColor.Green, "Yes, you guessed right! {1} is the number.  Thank you for playing.");

                //Ask user if user wants another game
                Console.WriteLine("Play again? [Y or N]");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //get and display the app info
        static void GetAppInfo()
        {
            string appName = "Guess a Number Game";
            string appVersion = "1.0.0";
            string appAuthor = "Holly N. Little";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Display app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }
        //greet user
        static void GreetUser()
        {
            //Get users info
            Console.WriteLine("What is your name?");

            //Get user input
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a guessing game...", userName);

        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}