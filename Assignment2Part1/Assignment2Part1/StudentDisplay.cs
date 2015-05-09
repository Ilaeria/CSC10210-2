using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    //Various methods for returning different student attributes
    public class StudentDisplay
    {        
        //constructor
        public StudentDisplay()
        {
        }

        //Methods for printing different student attributes
        public void PrintStudentIdentifier(IStudent student)
        {
            Console.WriteLine("Student ID: {0}", student.StudentIdentifier());
        }

        public void PrintFamilyName(IStudent student)
        {
            Console.WriteLine("Student Family Name: {0}", student.FamilyName());
        }

        public void PrintOtherNames(IStudent student)
        {
            Console.WriteLine("Student Other Names: {0}", student.OtherNames());
        }
        
        //Returns a formatted string of student attributes
        public string ReturnStudent(IStudent student)
        {
            string output = ("Student ID: " + student.StudentIdentifier() + ", Student Family Name: "
                + student.FamilyName() + ", Student Other Names: " + student.OtherNames());
            return output;
        }

        //Checks an ID matches another ID
        public bool CheckID(IStudent student1, int checkInt)
        {
            if (student1.StudentIdentifier() == checkInt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
