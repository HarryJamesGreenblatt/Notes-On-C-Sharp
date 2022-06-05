using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{
    internal class username_retrieved_with_ReadLine
    {

        // a method which returns a string invoked from user input with Console.ReadLine()
        public void retrieve_username_with_ReadLine()
        {


            // prompt the user for their name

            Console.Write("What's your name?   ");


            // store the full line entered by the user
            // up until the enter key is pressed

            string userInput = Console.ReadLine();


            // greet the user with the stored name
            Console.WriteLine(
                "Hello {0}.",
                userInput
             );


        }  
    }
}