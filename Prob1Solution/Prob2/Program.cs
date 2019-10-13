using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        #region IPO
        // description of method: region 1 shows how parameters can be passed
        //          by value 
        //          Region 2 gives an example of how to pass parameters by
        //          reference
        //          Region 3 showcases the ability to overload methods
        // Inputs:  Region 1 I chose to use two variables, int number and int 
        //          number2 
        //          2 uses two defined arrays the first having the 
        //          values 1 2 3 4 5, the second referencing the first to glean
        //          its values
        //          Region 3 I use the strings firstname middle name and last
        //          name as well as the integers 1 3 5 6 8 12 18 19 and 32
        // Outputs: Region 1 returns the values of number and number2 before 
        //          number is declared as 15. After number is declared s 15 
        //          a writeline showcases how only the number variable is 
        //          changed, number2 does not change.
        //          Region 2 outputs index 0 of array and array 2 showing that 
        //          they are both equal to eachother. ModifyArray method called
        //          to increase value of array index 0 by 1. Afterward output 
        //          reveals that both array and array2 index 0 have been 
        //          increased by 1
        //          Region 3 three methods with the same name take different 
        //          amounts of string arguments and write them to the console 
        //          window. 3 methods ith the same name take different amounts
        //          of int arguments and print their sum to the console window.
        // Behavior: region 1 int number is set to 10 and int number2 is set to
        //          the value number. When referencing the method ModifyValue, 
        //          the program attempts to change the value of number to 15. 
        //          It is not capablae of doing this so thw numbers stay at 
        //          value 10. However, when the value of number is changed 
        //          within the main program, number is changed to 15 and 
        //          number2 stays at 10
        //          Region 2 initial print statement shows that both array and
        //          array2 index 0 are equal to eachother. After referencing 
        //          the ModifyArray method,to increase the value of array index
        //          0 by 1. After initializing another print statement, we see 
        //          that bot array and array2 index0 have been increased by 1.
        //          Region 3 the first three methods referenced all feature the
        //          same name yet they accept 3 different amounts of arguments.
        //          Method 1 prints a persons first and last names, the second 
        //          method prints someone's full name, the third method prints 
        //          a person's first name.
        //          Another series of method shows that you can do the same 
        //          overloding of methods using ints. The first method sums 
        //          up two numbers, the second sums up four numbers and the 
        //          third sums up 3 numbers. All methods feature the same exact
        //          name.

        #endregion
        static void Main(string[] args)
        {
            #region 1 pass by value
            int number = 10;

            int number2 = number;
            // ModifyValue method called to show how it is not possible to
            // pass value types by reference
            ModifyValue(number);
            Console.WriteLine("Number and number2 attempting to " +
                "pass by reference\n");
            Console.WriteLine(number);

            Console.WriteLine(number2);
            Console.WriteLine("----------------------------" +
                "-----------------------\n");
            
            // numbers value is changed to 15 to show pass by value
            number = 15;
            Console.WriteLine("Number and number2 after passing " +
                "by value\n");
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine();
            Console.WriteLine("number 2 does not change even though it " +
                "references number for its value\n");
            Console.WriteLine("------------------------------------" +
                "-----------------------------------\n");

            #endregion

            #region 2 pass by reference
            // create two arrays of equal value
            int[] array = { 1, 2, 3, 4, 5 };

            int[] array2 = array;
            // writeline shows that both arrays are equal before reference
            Console.WriteLine("Array and array2 index 0 before" +
                " passing by reference\n");
            Console.WriteLine(array[0]);

            Console.WriteLine(array2[0]);
            Console.WriteLine("---------------------------" +
                "-------------------------\n");
            // call method to increase arrayt index 0 by 1
            // writeline shows that both arrays are still equal after reference
            ModifyArray(array);
            Console.WriteLine("Array and array2 index 0 after" +
                " passing by reference");
            Console.WriteLine(array[0]);
            Console.WriteLine(array2[0]);
            Console.WriteLine("-------------------------" +
                "---------------------------\n");
            #endregion

            #region 3 overloading methods
            // the first PrintNames method I have defined onlytakes two string
            // inputs for the first and last name
            Console.WriteLine("PrintNames using 2 arguments");
            Console.WriteLine("----------------------------");
            PrintNames("Kyle", "McDonald");
            // when I make a second PrintNames method I can input three names 
            // to signify that I will be using the variation that calls for
            // three input strings
            Console.WriteLine("PrintNames using 3 arguments");
            Console.WriteLine("----------------------------");
            PrintNames("Kyle", "John", "McDonald");
            // I can make as many variations of PrintNames as I would like, as
            // long as each method calls for a different amount of inputs, like
            // this third one that only asks for one
            Console.WriteLine("PrintNames using 1 argument");
            Console.WriteLine("---------------------------");
            PrintNames("Kyle");
            // We can also overload int methods. For instance finding the sum
            // of two, three, four etc. values
            Console.WriteLine("Sum using 2 arguments");
            Console.WriteLine("---------------------");
            Console.WriteLine(Sum(5, 6));
            Console.WriteLine();

            Console.WriteLine("Sum using 4 arguments");
            Console.WriteLine("---------------------");
            Console.WriteLine(Sum(3, 12, 19, 1));
            Console.WriteLine();

            Console.WriteLine("Sum using 3 arguments");
            Console.WriteLine("---------------------");
            Console.WriteLine(Sum(8, 18, 32));
            Console.WriteLine();


            #endregion

        }
        //method that declares the value of number to 15
        // used to demonstrate pass by reference of a value type
        static void ModifyValue(int number)
        {
            number = 15;
        }            
        // method that increases the value of array index 0  by one
        // used to demonstrate pass by reference
        static void ModifyArray(int[] array)
        {
            array[0]++;
        }
        #region string method overloading
        // 3 methods to show overloading methods containing strings 

        static void PrintNames(string firstName, string lastName)
        {
            Console.WriteLine($"Hello my name is {firstName} {lastName}.\n");
        }

        static void PrintNames(string firstName, string middleName,
            string lastName)
        {
            Console.WriteLine($"My full name is {firstName} {middleName}" +
                $" {lastName}.\n");
        }

        static void PrintNames(string firstName)
        {
            Console.WriteLine($"My first name is {firstName}.\n");
               
        }
        #endregion
        #region int method overloading
        //3 methods to show overloading methods containing ints

        static int Sum(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber}" +
                $" is: ");
            return firstNumber + secondNumber;
            
        }
        static int Sum(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and" +
                $" {thirdNumber} is: ");
            return firstNumber + secondNumber + thirdNumber;
        }

        static int Sum(int firstNumber, int secondNumber, int thirdNumber, int
            fourthNumber)
        {
            Console.WriteLine($"The sum of {firstNumber}, {secondNumber}, " +
                $"{thirdNumber} and {fourthNumber} is: ");
            return firstNumber + secondNumber + thirdNumber + fourthNumber;
        }
        #endregion



    }
}
