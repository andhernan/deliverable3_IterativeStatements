/*Name: Andrea Hernandez-Sabanilla
 * Assignment 3: Iterative Statements
 */
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace deliverable3_Iterative_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **This is a CASE SENSITIVE program**");
            /*
             * PROGRAM (2): Based on what you have learned from the Iterative Statements example, 
             * write a C# Program Console Program (with Iterative Statements) that does the following: 
             * 1. Choose to write your program with only one of the three choices of Iterative Statements: 
             * While, For, or Do While (Choose at least 1).
             * 2. Ask the user to enter an integer value between 1 and 100.
             * 3. Ask the user to specify a series of integer numbers. 
             * There are two options: even numbers and odd numbers.
             * 4. Then, have the program display the following message: 
             * "You have selected the *series name* series. 
             * The numbers between 0 and *user’s input* are:”
             * 5. Finally, have the program display all the numbers from the series 
             * between 0 and the user’s input. 
             * 
             * NOTE: Use a try/catch block to validate the user's entry.
             */
            
            int chosenNumber = 0;
            //initiate variable
            bool con1 = false;
            //make sure it is a number
            while (con1 == false)
            {
                Console.WriteLine("Enter an integer value between 1 and 100: ");
                string chosenNumberAsString = Console.ReadLine();

                bool parseSuccess = int.TryParse(chosenNumberAsString, out chosenNumber);
                //check if it is within valid parameters
                if (parseSuccess)
                {
                    if (chosenNumber >= 0 && chosenNumber <= 100)
                    {
                        con1 = true;
                     }
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            
            

            //make sure they give us an actual series
            //initiate looper
            bool con2 = false;
            while (con2 == false)
            {
                //ask for series
                Console.WriteLine("Specify  the series type: Even or Odd");
                string chosenSeries = Console.ReadLine();

                if (chosenSeries == "Odd" || chosenSeries == "Even")
                {
                    Console.WriteLine("\n You have selected " + chosenSeries + " series. \n " +
                        "The numbers between 0 and " + chosenNumber + " are: ");
                    //CHOSE SERIES
                    if (chosenSeries == "Odd")
                    {
                        for (int i = 1; i <= chosenNumber; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= chosenNumber; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    con2 = true;
                }
                else
                {
                    Console.WriteLine("Please enter an appropriate series.");

                }
            }
        }
    }
}