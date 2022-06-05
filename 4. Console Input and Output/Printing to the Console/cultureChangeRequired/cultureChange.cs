using System;

// System.Threading and System.Globalization are both required
using System.Threading;
using System.Globalization;


namespace cultureChangeRequired
{
    /*
        When using format strings, it is possible for the  same program to print different values, 
        depending on the localization settings for the operating system.  

        Localization in .NET is also called "culture", 
        and can be changed manually by the class `System.Globalization.CultureInfo`.
     */

    internal class cultureChange
    {

        public static void Main(string[] args)
        {

            // Assume we have some random Date and Time
            DateTime randomDateTime = GetRandomDateTime();

            

            // We can change the culture to France at the Thread-Level
            Thread.CurrentThread.CurrentCulture = 
                CultureInfo.GetCultureInfo("fr-FR");
            


            // We can print France-localized data to console
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", randomDateTime);



            // The method which generates the random DateTime value
            DateTime GetRandomDateTime()
            {
                Random random = new Random();

                int year    = random.Next(2015, 2022),
                    month   = random.Next(1, 12),
                    day     = random.Next(1, 28),
                    hour    = random.Next(00, 11),
                    minute  = random.Next(00, 59),
                    seconds = random.Next(00, 59);

                DateTime randomDateTime = new DateTime(
                    year,
                    month,
                    day,
                    hour,
                    minute,
                    seconds
                );

                return randomDateTime;
            }
        }
    }
}
