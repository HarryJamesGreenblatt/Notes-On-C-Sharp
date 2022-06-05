using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{

    // 5. Write a program that reads from the console two integer numbers (int) 
    //    and prints how many numbers between them exist, 
    //    such that the remainder of their division by 5 is 0.
    //      
    //    Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
    
    internal class Exercise5
    {

        // Allocate a dynamically resizeable List type instance variable 
        // to store each value in the user provided range that is found to be 
        // divisible by five  

        private List<int> divisibleByFive = new List<int>();
        


        // A method that retrieves a minimum and a maximum value from the user, 
        // printing the numbers ranging from that minimum to that maximum value which are divisible by 5
        // provided that it can be verified that the minimum does not exceed the maximum.  

        public void user_provided_range_values_divisible_by_five()
        {
            
            // Retrieve user 2 valid integer inputs representing the lower and upper boundaries 
            // associated with a range of intermediate integer values,
            // incrementing the upper boundary by 1 to compensate for 0th indexing conventions.

            int  lower  =  getUserInput("lower"),
                 upper  =  getUserInput("upper") + 1;


            // verify the lower boundary is in fact lower than that upper boundary

            if ( boundaries_make_sense( lower, upper ) )
            {

                // should the boundary values make sense, 
                // iterate through an Enumeranle type capturing each number in a range a values 
                // that begins with the lower boundary and increments a number of times 
                // equal to the difference between the upper and lower boundaries.

                foreach ( int number in Enumerable.Range(lower, (upper - lower)) )

                    // if any such number discovered thorugh this iteration is divisible by 5,
                    // add that number to the divisibleByFiive List

                    if (number % 5 == 0)
                        divisibleByFive.Add(number);


                // print the given range boundary inputs, readjusting the upper boundary for 0th indexing,
                // along with the numbers within the associated range found to be divisble by 5

                Console.WriteLine(
  
                    $"\nIn the range({lower}, {upper - 1}), there are " +
                    divisibleByFive.ToArray().Length +
                    $" such numbers: { string.Join(", " , divisibleByFive.ToArray()) }\n"

                );

            }

        }



        // A method which recursively calls itself until it's numeric inputs are assessesd to be
        // passed in a way such that the first input is lower in value or equal to the second,
        // returning a boolean value to indicate a successiful verification.  

        private bool boundaries_make_sense( int lower, int upper )
        {
            
            // if the lower boundary is in fact lower than the upper boundary,
            // return a bool indicating as much.

            if(lower <= upper)
                return true;


            // Otherwaise,

            else{

                // print an error message explaining the usage requiremetns,
                // recuresively calling back the function to restart the input validation process 

                Console.WriteLine("\nThe first value should be lower than the second value. Please try again");

                return boundaries_make_sense( 
                    getUserInput("lower"), 
                    getUserInput("upper") 
                );

            } 
            
        }



        // a method which runs a loop prompting the user for a valid numeric
        // input until one is entered and validated.

        private int getUserInput( string boundary )
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

                Console.Write($"Enter a {boundary} boundary:  ");
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
