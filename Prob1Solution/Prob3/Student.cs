using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Student
    {   //create a field for studentName
        #region 1 fields
        private string studentName;
        // make a public string for the get method have it return studentName
        public string GetName() { return studentName; }
        // make a public string for the set method input should be a string
        public void SetName(string name)
        {
            // studentname should equal user input
            studentName = name;
        }
        // create field for sid
        private int sid;
        // create field for gpa
        private decimal gpa;

        #endregion



        #region 2 properties
        // create public property to initialize set and get methods
        public int StudentID
        {
            get { return sid; }
            set
            {
                //use an if else statement to ensure id is within parameters
                //if not throw an exception otherwise set the student id to the
                //value input

                if (value < 100000 || value > 999999)
                {
                    throw new System.Exception("Input needs to be 6 digits");
                }
                else
                {
                    StudentID = value;
                }

            }
        }
        //create am automatic property for StudentGPA
        public decimal StudentGPA { set; get; }

        #endregion

        #region 3 constructors
        //master constructor
        public Student(string name, int id, decimal gpa)

        {
            //set variables to values 
            studentName = name;

            sid = id;

            StudentGPA = gpa;

        }
        //constructor that accepts student name and id
        public Student(string name, int id) : this  (name, id, 0.0M) { }
        
        //default constructor
        public Student() : this("No Name", 999999, 0.0M) { }

        #endregion

        #region 4 PrintState
        //create a PrintState method
        public void PrintState()

        {

            Console.WriteLine("Name:\t{0}", studentName);

            Console.WriteLine("ID:\t{0}", sid);

            Console.WriteLine("GPA:\t{0}", StudentGPA);


        }

        #endregion








    }
}

        
           
