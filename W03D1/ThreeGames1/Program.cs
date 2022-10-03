using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string userInput;
            Boolean doInput = true;


            while (doInput)
            {

                Console.WriteLine("\nPlease select option from list:\n"
                    + "\nOption (GuesNumberGame): \t1\nOption (OddEven): \t\t2"
                    + "\nOption (HangmanGame): \t\t3\nOption (ForHangmanGame): \t4\nExit: \t\t\t\te");

                userInput = Console.ReadLine();

                switch (userInput)
                {

                    case "1":
                        GuesNumberGame();
                        break;

                    case "2":
                        // Ask about number and tell of it is odd or even
                        OddEven();
                        break;

                    case "3":
                        // Hamgman game. Ask user about 5 letter world. Giv them 15 attempts
                        HangmanGame();
                        break;

                    case "4":
                        // Hamgman WITH FOR game. Ask user about 5 letter world. Giv them 15 attempts
                        ForHangmanGame();
                        break;

                    case "e":
                        doInput = false;
                        break;
                }
            }
        }

        static void GuesNumberGame()
        {
            int playerNumb;
            int attempts = 5;


            // object randGenerator can generate radom numbers
            Random randGenerator = new Random();
            int randNumb = randGenerator.Next(1, 11);
            Console.WriteLine(randNumb);


            while (attempts > 0)
            { /////////////////////////////// game loop
                Console.Write($"\nGues a number between 1 and 10.\nYou have {attempts} tries left: ");


                while (!int.TryParse(Console.ReadLine(), out playerNumb)) ///// input from player
                    Console.WriteLine("\nWrong input!\n\nGues a number between 1 and 10: " + playerNumb);

                if (randNumb == playerNumb)  // compare numbers
                {
                    Console.WriteLine("\n*********** You Win!! ***********");
                    break;
                }

                if (attempts-- == 0)
                    Console.WriteLine($"\n *** You lose! Secret number is {randNumb} ***");

            }

        }

        static void HangmanGame()
        {
            string[] wordArray = { "house", "water", "plate" };
            Random rand = new Random();
            string guessWord = wordArray[rand.Next(2)];

            //string guessWord = "house";
            string[] userWord = { ".", ".", ".", ".", "." };
            int attempts = 10;
            int counter = 0;

            Console.Write(guessWord);
            Console.WriteLine("\nGuess a 5 letter world");

            while (true)
            {
                Console.Write($"\nYou have {attempts} attempts: ");

                string playerLetter = Console.ReadLine();
                int playerIndex = guessWord.IndexOf(playerLetter);


                if (playerIndex > -1)
                {
                    userWord[playerIndex] = playerLetter;
                    counter++;
                }

                foreach (string s in userWord) Console.Write(s);

                attempts--;
                if (counter == 5 || attempts == 0) break;
            }

            Console.WriteLine(counter == 5 ? "\n***** YOU WIN !!! *****" : "\n***** YOU LOOSE !!! *****");
        }


        static void ForHangmanGame()
        {
            string secret = "house";
            string[] result = { "*", "*", "*", "*", "*" };
            int counter = 0;
            

            Console.WriteLine("\nGuess a 5 letter world");

            for (int i = 15; i > 0; i--)
            {
                Console.Write($"\nYou have {i} attempts: ");

                string playerInput = Console.ReadLine();
                int playerIndex = secret.IndexOf(playerInput);

                // Console.WriteLine(playerIndex); // debug

                if (playerIndex > -1)
                {
                    result[playerIndex] = playerInput;
                    counter++;
                }

                foreach (string s in result) Console.Write(s);
                if (counter == 5) break;
            }

            Console.WriteLine(counter == 5 ? "\n**** YOU WIN ****" : "\n**** YOU LOOSE ****");
        }


        static void OddEven()
        {
            Console.WriteLine("Enter the number:");
            string userInput = Console.ReadLine();
            int userInt;

            while (!int.TryParse(userInput, out userInt))
            {
                Console.WriteLine($"{userInput} is not correct. Enter integer number:");
                userInput = Console.ReadLine();
            }

            Console.WriteLine(userInt % 2 == 1 ? $"Number {userInt} is odd" : $"Number {userInt} is even");

        }
    }
}
