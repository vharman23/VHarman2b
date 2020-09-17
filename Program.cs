using System;

namespace VHarman2b
{
/* Assignement #2b by Victoria Harman
    Conditional Statements */

    class Program
    {
        static void Main(string[] args)
        {
            //Ask used to input expected final grade
            Console.WriteLine("Enter an integer value (0-100) for the grade you expect to receive in ISM4300 ...");

            try
            {
                //Variable to gather user input
                string input = Console.ReadLine();

                //Converting input to int
                int percentage = int.Parse(input);
                //return final letter grades based on inputed integer 
                if ((percentage <= 59) && (percentage >= 0))
                {
                    Console.WriteLine("Your final grade will be an 'F'");
                }
                else if ((percentage >= 60) && (percentage <= 69))
                {
                    Console.WriteLine("Your final grade will be a 'D'");
                }
                else if ((percentage >= 70) && (percentage <= 79))
                {
                    Console.WriteLine("Your final grade will be a 'C'");
                }
                else if ((percentage >= 80) && (percentage <= 89))
                {
                    Console.WriteLine("Your final grade will be a 'B'");
                }
                else if (percentage >= 90)
                {
                    Console.WriteLine("Your final grade will be an 'A'");
                }

            }//end of try
            catch
            {
                Console.WriteLine("Please input an integer ...");
                Console.WriteLine("Press any key to exit and try again ...");
            } //end of catch
        }//end of main
    }//end of class
}//end of namespace
