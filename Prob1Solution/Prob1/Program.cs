using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        #region IPO
        // description of method: region 1 requires the build of an array of 
        // strings that can be run through a foreach loop in order to print 
        // out each array element on a separate line. Region 2 calls for an int
        // array with a size of ten then using a for loop to set the array 
        // index to the value of the iteration*10. Region 3 show how to build a 
        // 12x12 times table using a 2d array a for loop, nested for loops and
        // decision structures.
        // Inputs: Region 1 uses an array of string "one"-"ten" 
        //         Region 2 uses an array set to size 10 and  multiplication 
        //         by 10
        //         Region 3 uses a 2d array set to 13,13 and we knew we had to 
        //         use nested for loops through instructions
        // Outputs: Region 1 returns each string element on a separate line
        //          Region 2 assigns and returns the iterator value*10
        //          Region 3 Returns 12 rows and 12 columns (13 and 13 with 
        //          formatting) numbered chronologically and matched up 
        //          with their respective multiplied values.
        // Behavior: region 1 the for each loop slices into the array of 
        // strings to retrieve each element and print it out in the 
        // console
        //          Region 2 uses an array with a defined length of 10
        // with the use of a for loop, the array is filled with ints,
        // these ints are the product of the iterator * 10
        //          Region 3 the 2d array establishes an array that
        //          contains 12 rows and 12 columns. Using nested for 
        //          loops set to iterate throught the number 12. The 
        //          code multiplies the iterator of each loop togehter
        //          and appends it to the 2d array. At the end of each
        //          iteration, the 2d array is written to the console.
        //          using a for loop that iterates through 12, I was
        //          able to format the top of the table in order to show
        //          the various multipliers. Using a writeline in the 
        //          first nested loop I could write the numbers 1-12 along
        //          the side of the table to signify the various values.
        #endregion
        static void Main(string[] args)
        {
            #region 1
            // create an array of strings with values "one"-"ten"
            string[] strArray = new string[] { "one", "two", "three", "four"
                , "five", "six", "seven", "eight", "nine", "ten" };
            // run a foreach loop to index into the string and print each 
            // element
            foreach (string element in strArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region 2
            //create array length 10
            int[] intArray = new int[10];
            // run a for loop that multiplies the iterator by 10 and 
            // set that value to the index number of the iterator
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i] = i * 10);
            }
            Console.WriteLine();
            #endregion

            #region 3
            // create a 2d array 13x13
            int[,] myArray = new int[13, 13];
            //Console.WriteLine("        1       2       3       4       5       
            // 6       7       8       9       10      11      12");
            //dawned on me that I could just as easily use a for loop with 
            // a conditional statement for this formatting
            for (int i = 0; i <= 12; i++)
            {
                // use an if statement to set 0 to x just tomake it prettier
                if (i == 0)
                {
                    Console.Write("X\t");
                // otherwise write i with a tab for alignment
                } else

                    Console.Write(i + "\t");
            }
            // make it pretty with some "-"
            Console.WriteLine("------------------------------------------" +
                "--------------------------------------------------------");
            // use nested loops to get the values for the times table
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(i + ":\t");
                for (int j = 1; j <= 12; j++)
                {
                    //multiply i*j and assign it to the array
                    myArray[i, j] = (i * j);
                    // print out the times table one row at a time
                    Console.Write(myArray[i, j] + "\t");
                }
            }

            #endregion

        }
    }
}
