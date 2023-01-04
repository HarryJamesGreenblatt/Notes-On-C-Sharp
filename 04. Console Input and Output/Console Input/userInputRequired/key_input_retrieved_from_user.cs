using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{
    internal class key_input_retrieved_from_user
    {
        // a method that prompts the user to enter a key, storing it a multi-faceted object
        public void retrieve_key_input_from_user() {

            //Promt the user for a key, storing it as a ConsoleKeyInfo object

            Console.Write("\nEnter a key:  ");
            ConsoleKeyInfo key = Console.ReadKey(); 


            // print the character that the user entered, along with any applicable modifiers

            Console.WriteLine("\nCharacter entered: " + key.KeyChar); 
            Console.WriteLine("Special keys: " + key.Modifiers);
            
        }
    }
}
