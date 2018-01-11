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

        static void Main(string[] args)
        {
            //***User input 2 dates of month/day/year
           // Console.WriteLine("Please enter your first date in the format of MM/DD/YYY");
           // Console.WriteLine("For example: January 1, 2010, should be entered as 01/01/2010.");
            while (runProgram)
            {
                while (getFirstDate)
                {
                    Console.WriteLine("Please enter your first date in the format of MM/DD/YYY");
                    Console.WriteLine("For example: January 1, 2010, should be entered as 01/01/2010.");
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
                TimeSpan timeBetween = firstDate - secondDate;
                
                //***Output
                Console.WriteLine("The time between your two dates is {0} days, {1} hours, and {2} minutes.", timeBetween.Duration().Days, timeBetween.Duration().Hours, timeBetween.Duration().Minutes);               
                
                Console.WriteLine("\nIf you want to run this program again press the 'y' key.");
                bool continueProgram;
                continueProgram = Console.ReadLine().ToLower()[0].Equals('y');
                if (continueProgram)
                {
                    getFirstDate = true;
                    getSecondDate = true;
                    Console.Clear();
                }
                else
                {
                    runProgram = false;
                }          
            }            
        }
    }
}
