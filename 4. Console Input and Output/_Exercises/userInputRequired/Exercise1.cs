using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{

    // 1. Write a program that reads from the console three 
    //    numbers of type int and prints their sum.

    internal class Exercise1
    {

        // a method which sums n numeric inputs provided by the user. 
        
        public void sum_of_n_numeric_user_inputs( int n )
        {

            // an array of float allocated to support n elements  

            float[] userInputs = new float[n];


            // declaration of variables to store
            // user inputs, sum value, and array index

            float val    =  0,
                  sum    =  0;

            int   index  =  0;
            

            // Enter a loop, performing it's first iteration
            // no matter the state of it's exit condition.

            do
            { 

                // Prompt the user for a number, then store it in a variable

                Console.Write("Enter a number:  ");
                string userInput = Console.ReadLine();


                // Assess the validity of the given input as a float type.
                // Should the input be invalid, print an error message,
                // then skip back to the beginning of the loop

                bool parseSuccessful = float.TryParse(userInput, out val);
                if (!parseSuccessful)
                {
                    Console.WriteLine("{0} is an invalid input!\n", userInput);
                    continue;
                }


                // add the current input value to the total sum,
                // then store it at this iteration's index value in the userInput array,
                // incrementing the index as we go
                
                sum += val;
                userInputs[ index++ ] = val;
                 
            }   while( index < n  );  // reapeat this loop until 3 valid inputs are entered


            // print which n inputs were observed to be valid float types,
            // then print their sum

            Console.WriteLine(
                $"\nYou entered the following valid numbers:  { string.Join(", ", userInputs ) }\n" +
                $"Taking the sum of these inputs, we have:  { string.Join(" + ", userInputs ) } = { sum }\n"
            );

        }

    }
}
