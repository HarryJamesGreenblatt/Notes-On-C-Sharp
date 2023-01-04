using System;

namespace userInputRequired
{
    internal class userInput
    {
        static void Main(string[] args)
        {
             
            // instantiate the associated sub-classes

            var username_retrieved_with_ReadLine    =  new username_retrieved_with_ReadLine();

            var username_parsed_with_Read           =  new username_parsed_with_Read();

            var numeric_inputs_retrieved_from_user  =  new numeric_inputs_retrieved_from_user();

            var key_input_retrieved_from_user       =  new key_input_retrieved_from_user();


         

            // prompt a user for their name, printing the full line of input up to a linefeed / carriage return character

            username_retrieved_with_ReadLine.retrieve_username_with_ReadLine();



            // prompt the user for their name, parsing the input and printing it one character at a time via a buffer

            username_parsed_with_Read.parse_username_with_Read();



            // prompt the user for three numbers, parsing the input and printing strings of math operations performed on them

            numeric_inputs_retrieved_from_user.retrieve_numeric_inputs_from_user();



            // a method that prompts the user to enter a key, storing it a multi-faceted object

            key_input_retrieved_from_user.retrieve_key_input_from_user();

        }
    }
}
