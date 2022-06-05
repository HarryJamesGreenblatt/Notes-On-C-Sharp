using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{

    // 10. Write a program that reads an integer number n from the console 
    // and prints all numbers in the range [1…n], each on a separate line.

    internal class Exercise10
    {

        // A method that prints all values in a range whose maximum
        // value element is specified by user input

        public void all_numbers_in_range_n( int n )
        {

            // Print a string representation of each element on a new line
            // using the IEnumerable prodced by the Range() function
          
            Console.WriteLine(

                string.Join( '\n', Enumerable.Range( 1, n ) )

            );

        }

    }
}
