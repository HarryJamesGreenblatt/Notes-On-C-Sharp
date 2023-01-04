using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputRequired
{

    // 3. A given company has name, address, phone number,
    //    fax number, web site and manager. The manager has name,
    //    surname and phone number. Write a program that reads information
    //    about the company and its manager and then prints it on the console. 

    internal class Exercise3
    {

        // a nested Manager subclass whose attributes are initialized by the user,

        private class Manager 
        {

            // Instance variables representing a manager's name, address, and phone number,
            // each to be provided by user input

            internal string name,
                            surname,
                            phone_number;


            // A method which initializes all instance variables with inputs
            // prompted to and received from the user
            internal void initialize_manager_attributes()
            {
                name         =  get_attribute_from_user( "Name", "Manager" );
                surname      =  get_attribute_from_user( "Surname", "Manager" );
                phone_number =  get_attribute_from_user( "Phone Number", "Manager");
            }

        }



        // Instance variables which store the company and manager's attributes,
        // each to be provided by user input 

        private string  name,
                        address,
                        phone_number,
                        fax_number,
                        web_site;
        
        private Manager manager  =  new Manager();



        // A method which collects and summarizes the company and management data
        // by storing user-provided inputs within the class's instance variables,
        // then printing them to console as a summary list.

        public void retrieve_and_print_company_and_management_data() 
        {

            // prompt the user's inputs, 
            // storing it as attribute data within the class's instance variables

            initialize_company_attributes();
            manager.initialize_manager_attributes();
      

            // print the company name, address, phone number, fax number, web site,
            // along with it's manager's name , surname, and phone number

            Console.WriteLine(
                $"\nCompany Name:  {name}\n" + 
                $"Company Address:  {address}\n" + 
                $"Company Phone Number:  {phone_number}\n" + 
                $"Company Fax Number:  {fax_number}\n" + 
                $"Company Web Site:  {web_site}\n\n" + 
                $"\nCompany Manager Name:  {manager.name}\n" + 
                $"Company Manager Address:  {manager.surname}\n" + 
                $"Company Manager Phone Number:  {manager.phone_number}\n"     
            );

        }



        // A method which initializes all instance variables with inputs
        // prompted to and received from the user

        private void initialize_company_attributes()
        {
            name         =  get_attribute_from_user( "Name" );
            address      =  get_attribute_from_user( "Address" );
            phone_number =  get_attribute_from_user( "Phone Number" );
            fax_number   =  get_attribute_from_user( "Fax Number" );
            web_site     =  get_attribute_from_user( "Web Site" );    
        }



        // A method which prompts the user for a given 'atttribute' 
        // describing an optionally given 'subject' (which is, by default, the company itself).
        // the user input is then returned as output

        static private string get_attribute_from_user( string attribute, string subject = "Company" )
        {
            Console.Write($"Enter the {subject}'s {attribute}:  ");
            return Console.ReadLine();
        }

    }
}
