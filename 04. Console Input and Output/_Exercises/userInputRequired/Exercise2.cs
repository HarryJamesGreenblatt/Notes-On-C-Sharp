using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{
    
    // 2.Write a program that reads from the console the radius "r"
    //   of a circle, and prints its circumference and area.

    internal class Exercise2
    {

        // a method which prints the calculated circumference and area
        // of a circle, as defined by a user-provided radius

        public void circumference_and_area_of_circle()
        {

            // retrieve the radius from the user and initialize
            // a variable representing the value of pi

            double r   =  getUserInput(),
                   pi  =  Math.PI;


            // Print the radius, along with the calculated
            // Area and Circumference of the circle

            Console.WriteLine(
                $"\nThe radius pf the circle is:  {r}\n" +
                $"The Area is A = pi * r * r = {pi * r * r}\n" +
                $"The Circumference is C = 2 * pi * r = {2 * pi * r}\n"
            );

        } 



        // a method which runs a loop prompting the user for a valid numeric
        // input until one is entered and verified.

        private double getUserInput() 
        {

            // declare a variable to store the user's input string,
            // and initialize a boolean flag to be used as a loop exit condition

            string userInput;
            bool   satisfied  =  false;


            // Begin loop, performing the first iteration regardless
            // of the state of the exit condition

            do 
            { 

                // prompt the user for a numeric input,
                // storing the result in a variable

                Console.Write("Enter the circle's radius:  ");
                userInput = Console.ReadLine();


                // assess the integrity of the input passed in,
                // should the input be invalid, print error message
                // and repeat loop from beginning
               
                bool parseSuccess = double.TryParse(userInput, out double val);

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

            return double.Parse(userInput);

        }

    }
}
