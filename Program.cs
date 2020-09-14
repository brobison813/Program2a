using System;
/* Programmer Brian Robison
 * ISM 4300
 * September 15 2020
 * Program 2a
 */
namespace Program2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //User intructions on what to do.
            Console.WriteLine("Enter an integer value between 1 and 25.");

            //try block in case the user inputs something other than an integer.
           try
            {
                // Varible assigned to hold inputted value
                string input = Console.ReadLine();
                // Varible to hold int vaule also parsing string to int.
                int value = int.Parse(input);
                // if statement for checking a proper value has been entered.
                if ((value > 0) && (value <= 25))
                {
                    // for loop if the users has entered a valid value. This for loop counts the number of times it goes based off of the value entered and displays a message for each time.
                    for (int i = 0; i <value; i++)
                        //to show the user the correct output 
                        Console.WriteLine("You have entered " + value.ToString() + ". This is the current integer value in the loop " + (i+1).ToString());
                }
                //else statment to ensure the value entered was within the range.
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try running the program again...");
                }
            }//try ends catch starts
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 25 and try running the program again...");
            }
            //end of catch
        }//end of main
    }//end of class
}//end of namespace
