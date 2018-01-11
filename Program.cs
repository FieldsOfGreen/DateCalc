using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalc
{
    class Program
    {
        //***Variable Declarations
        static bool runProgram = true, getFirstDate = true, getSecondDate = true;
        static DateTime firstDate, secondDate;
        static string firstDateString, secondDateString;
        

        static void Main(string[] args)
        {
            //***User input 2 dates of month/day/year
            Console.WriteLine("Please enter your first date in the format of MM/DD/YYY");
            Console.WriteLine("For example: January 1, 2010, should be entered as 01/01/2010.");
            while (runProgram)
            {
                while (getFirstDate)
                {                    
                    if (DateTime.TryParse(Console.ReadLine(), out firstDate))
                    {
                        Console.Clear();
                        Console.WriteLine("Your first date is: " + firstDate.ToShortDateString());         
                        getFirstDate = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Oops! You need to enter the date in the right format: MM/DD/YYYY");
                        
                    }
                }
                while (getSecondDate)
                {                   
                    Console.WriteLine("Please enter another date.");
                    if (DateTime.TryParse(Console.ReadLine(), out secondDate))
                    {
                        Console.WriteLine("Your second date is: " + secondDate.ToShortDateString());
                        getSecondDate = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Oops! You need to enter the date in the right format.");
                        Console.WriteLine("Your first date is: " + firstDate.ToShortDateString());
                    }
                }
                Console.Clear();
                Console.WriteLine("Your first date is: {0}", firstDate.ToShortDateString());
                Console.WriteLine("Your second date is: {0}", secondDate.ToShortDateString());
                Console.ReadKey();
            }
            


            //***Output difference between dates in days/hours/minutes
            
            //this creates a new instance of the datetime class AND initialized it to right now.
            /*
            DateTime myValue = DateTime.Now;
            */

            /*
            Console.WriteLine("month/day/year AND hours/minutes/seconds: " + myValue.ToString());
            Console.WriteLine("month/day/year: " + myValue.ToShortDateString());
            Console.WriteLine("long date string" + myValue.ToLongDateString());
            Console.WriteLine("long time: " + myValue.ToLongTimeString());

            Console.WriteLine("adding days: " + myValue.AddDays(3).ToLongDateString());
            Console.WriteLine("adding hours: " + myValue.AddHours(3).ToShortTimeString());
            */

            //***if you want to subtract time, days, etc. 
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            //***retrieving certain parts of the date or time...
            //Console.WriteLine(myValue.Month.ToString());
            //Console.WriteLine(myValue.);

            //***Creating and initializing date/time objects..


            //***ONE way to create a new date is to pass it a series of integers...
            /*
            DateTime myBirthday = new DateTime(2005, 5, 25);
            Console.WriteLine(myBirthday.ToShortDateString());
            */

            //comparing the difference between two datetime objects using the timespan object
            /*
            DateTime myBirthday = DateTime.Parse("12/7/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            */


            Console.ReadLine();
        }
    }
}
