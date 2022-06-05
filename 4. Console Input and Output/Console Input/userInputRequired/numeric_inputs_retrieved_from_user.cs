using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{
    internal class numeric_inputs_retrieved_from_user
    {

        // a method that prompts the user for three numbers, parses the input and prints strings representing math operations performed on them
        public void retrieve_numeric_inputs_from_user()
        {

            // prompt the user for three numbers, store them in variables

            Console.Write("\na = ");

            int a = int.Parse(
                Console.ReadLine()
            );

            Console.Write("b = ");

            int b = int.Parse(
                Console.ReadLine()
            );

            Console.Write("f = ");

            double f = double.Parse(
                Console.ReadLine()
            );



            // Print operations performed on the numeric data as strings.

            Console.WriteLine(
                "{0} + {1} = {2}",
                 a, b, a + b
            );

            Console.WriteLine(
                "{0} * {1} = {2}",
                 a, b, a * b
            );

            Console.WriteLine(
                "{0} * {1} / {2} = {3}",
                a, b, f, a * b / f
            );
        }

    }
}
