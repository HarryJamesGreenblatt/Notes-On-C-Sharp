using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{

    // a method which prints a string invoked with Console.Read()
    internal class username_parsed_with_Read
    {
        public void parse_username_with_Read()
        {

            // prompt the user for their name

            Console.Write("\nWhat's your name?   ");



            // initialize the default unicode value

            int codeRead = 0;



            // initiate a loop which reads input from the user until the enter key is pressed

            do
            {

                // read in a unicode character from the user

                codeRead = Console.Read();


                // print the unicode value converted as a character 

                Console.Write(
                    (char)codeRead
                );

            } while (codeRead != 10);  // loop until the carriage return character (enter) is inputted.

        }
    }
}
