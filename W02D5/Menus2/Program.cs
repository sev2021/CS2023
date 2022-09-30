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
            Console.WriteLine("\nGuess a Numer Game!");

            Random randGenerator = new Random();         // object randGenerator can generate radom numbers
            int randNumb = randGenerator.Next(1, 11);
            //Console.WriteLine(randNumb);
            Console.WriteLine(randGenerator.Next(1, 11));

        }
    }
}
