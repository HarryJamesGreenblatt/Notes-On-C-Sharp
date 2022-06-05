using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputRequired
{
    internal class Exercise10
    {
        /*10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions: 
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4). 
            - Prints on the console the number in reversed order: dcba (in our example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201). 
            - Exchanges the second and the third digits: acbd (in our example 2101).
         */
        static void Main(string[] args)
        {
            // Initialize variable to track the state input validation, along with arrays to store non-permissble characters

            bool satisfied = false;
            char[] lowercaseAlphabeticLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'z' };
            char[] uppercaseAlphabeticLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Z' };
            char[] punctOrSymbols = { '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_' , '-', '+', '=', ']', '}', '|', '}', ']', '\'', '"', ',', '.', '/','<','>','?' };
            

            // Initiate a loop which repeats until the user inputs a valid 4 digit number
           
            while ( !satisfied ) { 

                Console.Write("Gimme dat 4 digit number:  ");
                string getUserInput = Console.ReadLine();


                bool fourDigitsLong         =  (getUserInput.Length == 4),
                     noLetters              =  (getUserInput.IndexOfAny(lowercaseAlphabeticLetters) == -1 )
                                                &&
                                               (getUserInput.IndexOfAny(uppercaseAlphabeticLetters) == -1 ),
                     noPunctuationOrSymbols =  (getUserInput.IndexOfAny(punctOrSymbols) == -1 );

                bool allConditionsMet = (

                     fourDigitsLong
                     &&
                     noLetters
                     &&
                     noPunctuationOrSymbols

                );
                

                // Skip this iteration with an error message if input validity check fails

                if (!allConditionsMet)
                {
                    Console.WriteLine("You fucked up the input. Please enter a number with exactly 4 digits.\n");
                    continue;
                }


                // Build the answer string according to the exercise requirements
               
                string sumOfTheDigits = (
                           int.Parse(getUserInput[0].ToString()) + 
                           int.Parse(getUserInput[1].ToString()) + 
                           int.Parse(getUserInput[2].ToString()) + 
                           int.Parse(getUserInput[3].ToString())
                        ).ToString(),
                       reversedOrder = $"{getUserInput[3]}{getUserInput[2]}{getUserInput[1]}{getUserInput[0]}",
                       lastDigitInFirstPosition = $"{getUserInput[3]}{getUserInput[0]}{getUserInput[1]}{getUserInput[2]}",
                       exchangeSecondAndThirdDigit = $"{getUserInput[0]}{getUserInput[1]}{getUserInput[3]}{getUserInput[2]}";


                string answer = $"Sum of the Digits:  {sumOfTheDigits}\n" +
                                $"Reversed Order:  {reversedOrder}\n" +
                                $"Last digit in First position: {lastDigitInFirstPosition}\n" +
                                $"Exchange Second and Third Digit:  {exchangeSecondAndThirdDigit}";

               
               // print the answer string and exit the loop

               Console.WriteLine(answer);

               satisfied = true;
                 
            }

           
            Console.ReadKey();
        }
    }
}
