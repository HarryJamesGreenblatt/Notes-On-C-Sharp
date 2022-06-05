using System;

namespace userInputRequired
{
    internal class userInput
    {
        static void Main(string[] args)
        {

            // retrieve exercise solution data from associated subclasses

            var Exercise1  = new Exercise1();
            var Exercise2  = new Exercise2();
            var Exercise3  = new Exercise3();
            /*  Exercise4: See Exercises.ipynb */
            var Exercise5  = new Exercise5();
            var Exercise6  = new Exercise6();
            var Exercise10 = new Exercise10();
            /*  Exercise11: See Exercises.ipynb */



            // since exercises 7, 8, and 9 are variations on other exercises,
            // we may reuse code for similar use cases

            var Exercise7 = Exercise1;
            var Exercise8 = Exercise6;
            var Exercise9 = Exercise7;




            // 1. Write a program that reads from the console three 
            //    numbers of type int and prints their sum.

            Exercise1.sum_of_n_numeric_user_inputs( 3 );



            // 2.Write a program that reads from the console the radius "r"
            //   of a circle, and prints its circumference and area.

            Exercise2.circumference_and_area_of_circle();



            // 3. A given company has name, address, phone number,
            //    fax number, web site and manager. The manager has name,
            //    surname and phone number. Write a program that reads information
            //    about the company and its manager and then prints it on the console. 

            Exercise3.retrieve_and_print_company_and_management_data();
            
            
            
            // 5. Write a program that reads from the console two integer numbers (int) 
            //    and prints how many numbers between them exist, 
            //    such that the remainder of their division by 5 is 0.
            //      
            //    Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.

            Exercise5.user_provided_range_values_divisible_by_five();



            // 6. Write a program that reads two numbers from the console
            //    and prints the greater of them. Solve the problem without conditionals.

            Exercise6.greatest_of_n_user_numeric_inputs( 2 );



            // 7. Write a program that reads five integer 
            //    numbers and prints their sum. If an invalid number is 
            //    entered the program should prompt the user to enter another number.

            Exercise7.sum_of_n_numeric_user_inputs( 5 );



            // 8.Write a program that reads five integer numbers and prints their sum.
            //   If an invalid number is entered, prompt the user to enter another number.

            Exercise8.greatest_of_n_user_numeric_inputs( 5 );



            // 9. Write a program that reads an integer number n from the console. 
            // After that reads n numbers from the console and prints their sum.
            // Since Exercise 8 implements a useful user input method for this use case,
            // we'll reuse it's value as this solution's input parameter. 

            Exercise9.sum_of_n_numeric_user_inputs( Exercise8.getUserInput() );



            // 10. Write a program that reads an integer number n from the console 
            // and prints all numbers in the range [1…n], each on a separate line.
            // Since Exercise 8 implements a useful user input method for this use case,
            // we'll reuse it's value as this solution's input parameter. 

            Exercise10.all_numbers_in_range_n( Exercise8.getUserInput() );

        }
    }
}
