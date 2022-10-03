using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace VerifyPPSN1
{
    internal class Program
    {
        static void Main()
        {
            //declare variables
            string userInput;

            while (true)
            {
                Console.WriteLine("\nSelect an option");
                Console.WriteLine("1 - Verify a PPS number");
                Console.WriteLine("e - Exit");

                userInput = Console.ReadLine();

                if (userInput == "e") return; // EXIT
                else if (userInput == "1") PPSNValidator();
                else Console.WriteLine("\nWRONG INPUT!");
            }
        }


        static bool PPSNValidator()                 // VALIDATIOR METHOD
        {
            bool validPPS = true;
            Console.WriteLine("Loading.....");
            Thread.Sleep(1000);                         // using System.Threading TIMER!!!
            Console.WriteLine("Enter PPS number");

            string userInput = Console.ReadLine();


            if (userInput.Length < 8 || userInput.Length > 9)  // verify input length
            {
                Console.WriteLine("\nNumber too short or too long.\nIt must be 8 or 9 characters. Try again."); 
                return false;
            }
            
            string fixedUserInput = userInput.PadRight(9, 'A');  // topping input to length 9

            validPPS = NumbVerify(fixedUserInput, 0, 7) && LetterVerify(fixedUserInput, 7, 9);

            Console.WriteLine(validPPS ? "\nPPS IS VALID": "\nPPS IS INVALID");
            return validPPS;

        } //PPSNValidator



        //////////////////////////////// VERIFICATION METHODS ///////////////////////////////////

        static bool NumbVerify(string ppsNo, int start, int stop)              // // verify numbers in strig
        {
            for (int i = start; i < stop; i++)                  
            {
                if (!char.IsNumber(ppsNo[i]))
                {
                    Console.WriteLine("\nNumer of digits is not correct. Try again.");
                    return false;
                }
            }

            return true;

        } // NumbVerify



        static bool LetterVerify(string ppsNo, int start, int stop)              // verify letters in strig
        {
            for (int i = start; i < stop; i++)
            {
                if (!char.IsLetter(ppsNo[i]))
                {
                    Console.WriteLine("\nNumber of letters is not correct. Try again.");
                    return false;
                }
            }

            return true;

        } // LetterVerify
    }
}