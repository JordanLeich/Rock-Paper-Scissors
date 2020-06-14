using System;
using System.Threading;

namespace Rock_Paper_Scissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            int randomInt;
            Console.WriteLine("Choose your weapon (Rock, Paper, Scissors): ");
            string User_Input = Console.ReadLine();
            Console.WriteLine();

            Random Computer = new Random();
            randomInt = Computer.Next(1, 4);

            if (User_Input == "Rock" || User_Input == "r" && randomInt == 1)
            {
                Console.WriteLine("Computer choice: Rock");
                Console.WriteLine();
                Console.WriteLine("Tie!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Paper" || User_Input == "p" && randomInt == 2)
            {
                Console.WriteLine("Computer choice: Paper");
                Console.WriteLine();
                Console.WriteLine("Tie!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Scissors" || User_Input == "s" && randomInt == 3)
            {
                Console.WriteLine("Computer choice: Scissors");
                Console.WriteLine();
                Console.WriteLine("Tie!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Rock" || User_Input == "r" && randomInt == 2)
            {
                Console.WriteLine("Computer choice: Paper");
                Console.WriteLine();
                Console.WriteLine("Paper beats rock! You lose!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Rock" || User_Input == "r" && randomInt == 3)
            {
                Console.WriteLine("Computer choice: Scissors");
                Console.WriteLine();
                Console.WriteLine("Rock beats scissors! You win!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Paper" || User_Input == "p" && randomInt == 1)
            {
                Console.WriteLine("Computer choice: Rock");
                Console.WriteLine();
                Console.WriteLine("Paper beats rock! You win!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Paper" || User_Input == "p" && randomInt == 3)
            {
                Console.WriteLine("Computer choice: Scissors");
                Console.WriteLine();
                Console.WriteLine("Scissors beats Paper! You lose!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Scissors" || User_Input == "s" && randomInt == 1)
            {
                Console.WriteLine("Computer choice: Rock");
                Console.WriteLine();
                Console.WriteLine("Rock beats Scissors! You lose!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else if (User_Input == "Scissors" || User_Input == "s" && randomInt == 2)
            {
                Console.WriteLine("Computer choice: Paper");
                Console.WriteLine();
                Console.WriteLine("Scissors beats Paper! You win!");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else
            {
                Console.WriteLine("Error Caught! Ending Game...");
                Thread.Sleep(3000);
            }
        }
    }
}
