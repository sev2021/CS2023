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

            Console.WriteLine("Please select option from list:"
                + "\nOption: 1\nOption: 2\nOption: 3\nExit: e");

            //do userInput = Console.ReadLine();
            //while (!"1234".Contains(userInput));

            while (doInput) { 

                userInput = Console.ReadLine();

                switch (userInput)
                {

                    case "1":
                        GuesNumberGame();
                        break;

                    case "2":
                        break;

                    case "3":
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

            while (attempts > 0) { /////////////////////////////// game loop
                Console.Write($"\nGues a number between 1 and 10.\nYou have {attempts} tries left: ");


                while (!int.TryParse(Console.ReadLine(), out playerNumb)) ///// input from player
                    Console.WriteLine("\nWrong input!\n\nGues a number between 1 and 10: " + playerNumb);

                if (randNumb == playerNumb)  // compare numbers
                {
                    Console.WriteLine("\n*********** You Win!! ***********");
                    break;
                }
               
                if(attempts-- == 0)
                    Console.WriteLine($"\n *** You lose! Secret number is {randNumb} ***");

            }
            
        }
    }
}
