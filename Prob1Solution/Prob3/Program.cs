using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        //description:  Create a class that can be used to create a student 
        //              object. The class allows for the user to input a 
        //              students name id and gpa. The user can also use set 
        //              and get methods for the variables. Use try/catch to
        //              throw an error if the student id is less than or more
        //              than 6 numbers long. Create three constructors default
        //              , 2 argument and master(3 argument)
        //Input:        Student name, id and gpa in decimal form. Setting 
        //              s.StudentID to 10 and 1000000 in order to cause an 
        //              error
        //Output:       Region 1 shows that the try/catch statement works as 
        //              intended throwing the error defined in the class object
        //              Region 2 runs the default constructor and prints the 
        //              default values of student
        //              Region 3 uses the name and id constructor to print the 
        //              user input student name and student id as well as the 
        //              default gpa value
        //              Region 4 uses the master constructor to allow the user
        //              to enter all the values for the student class then 
        //              prints the values
        //              Region 5 Prints the value of GetName after SetName has
        //              been set to a new name.
        //              Region six uses a PrintState to show that the SetName 
        //              is now saved as the value of a.student
        //Behavior:     Class student is instantiated and immediately runs the 
        //              try/catch statements to ensure errors are caught.The 
        //              program then runs through multiple constructors 
        //              showcasing how the user can relegate their necessary 
        //              input if desired. The set and get methods are then 
        //              called in order to change the name of a student and 
        //              print it out. The program then prints the state of 
        //              a.Student.
        static void Main(string[] args)
           
        {
            #region 1 try catch

            // instantiate object

            Student s = new Student();
            Console.WriteLine("-----Catching errors-----\n");
            //  use a try/catch statement to throw an error if the id is out of
            //  parameter being less than 100000
            try

            {

                s.StudentID = 10;
                

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }
            //  use a try/catch statement to throw an error if the id is out of
            //  parameter being greater than 999999

            try

            {

                s.StudentID = 1000000;


            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }
            Console.WriteLine("--------------------------\n");

            #endregion

            #region 2 print default constructor

            // when no arguments are passed into Student(); we can use 
            //PrintState to see the default values!

            Student a = new Student();

            Console.WriteLine("Default values for Student");
            Console.WriteLine("--------------------------\n");
            a.PrintState();

            #endregion

            #region 3 use name and id constructor 
            // this particular can be used to set a students name and id using
            //arguments
            Console.WriteLine();
            Console.WriteLine("Name and ID constructor");
            Console.WriteLine("-----------------------\n");

            Student b = new Student("Kyle McDonald", 201023);

            b.PrintState();

            #endregion

            #region 4 Master constructor
            //finally we can use our master constructor to set all three values
            // using arguments

            Console.WriteLine();
            Console.WriteLine("Master Constructor Demo");
            Console.WriteLine("-----------------------\n");

            Student c = new Student("Kyle McDonald", 201023, 1.8M);
            

            c.PrintState();

            #endregion


            #region 5 mutators and accesors

            //mutators and accessors refer to the get and set methods, we can 
            // use these to set individual parameters for a Student class
            // using a.SetName allows us to pass any string into the student
            // Name field

            Console.WriteLine();
            Console.WriteLine("Get Student Name");
            Console.WriteLine("----------------\n");

            a.SetName("Roger Daltry");
            
            

            //using a console.writeline, we can call the value currently stored
            // in studentName field for student a. No need to use PrintState!
            Console.WriteLine(a.GetName());
            Console.WriteLine();
            Console.WriteLine("--------------\n");
            Console.WriteLine("A print state for good measure!\n");
            a.PrintState();



            

            #endregion



            




        }
    }
}
