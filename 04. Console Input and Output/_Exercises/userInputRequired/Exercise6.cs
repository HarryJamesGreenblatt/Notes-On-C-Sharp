using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{

    // 6. Write a program that reads two numbers from the console
    //    and prints the greater of them. Solve the problem without conditionals.

    internal class Exercise6
    {

        // A method which takes a numeric input indicating the allocation size
        // of an int array to be used to store n user inputs,
        // printing the max value of these inputs to console

        public void greatest_of_n_user_numeric_inputs( int n )
        {

            // allocate an array on int of a size n

            int[] userInputs = new int[n];


            // counting the index up from 0 to the total number of user inputs, 
            // store each user input as an element in the userInputs array

            for (int i = 0; i < n; i++)
                userInputs[i] = getUserInput();


            // print the maximum element of the userInput array

            Console.WriteLine( 
                $"\nYou entered: {string.Join(", ", userInputs)}\n" + 
                $"{userInputs.Max()} is the greatest of those inputs\n" 
            ); 
      
        }



        // A method which runs a loop prompting the user for a valid numeric
        // input until one is entered and validated.

        internal int getUserInput()
        {

            // declare a variable to store the user's input string,
            // and initialize a boolean flag to be used as a loop exit condition

            string userInput;
            bool satisfied = false;


            // Begin loop, performing the first iteration regardless
            // of the state of the exit condition

            do
            {

                // prompt the user for a numeric input,
                // storing the result in a variable

                Console.Write($"Enter a Non-Decimal Number:  ");
                userInput = Console.ReadLine();


                // assess the integrity of the input passed in,
                // should the input be invalid, print error message
                // and repeat loop from beginning

                bool parseSuccess = int.TryParse(userInput, out int val);

                if (!parseSuccess)
                {
                    Console.WriteLine("{0} is not a valid input!\n", userInput);
                    continue;
                }


                // otherwise, allow the exit condition to terminate the loop

                satisfied = true;

            } while (!satisfied);  // loop until a valid user input is given


            // From here, we know the input is valid,
            // so we parse the user's input and return it's value

            return int.Parse(userInput);

        }
    }
}
