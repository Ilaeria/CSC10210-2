using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    //Various methods for returning different student attributes
    
    //Kai: Student Displkay is independent and not implementing the interface, removed and removed its properties
    public class StudentDisplay
    {
        //Properties
        //Kai: public int StudentID { get; set; }
        //Kai: public string LastName { get; set; }
        //Kai: public string FirstNames { get; set; }
        
        //constructor
        // Kai: emptied constructor
        public StudentDisplay()
        {
        }

        //Interface methods
        /* Kai:
        public int StudentIdentifier()
        {
            return StudentID;
        }

        public string FamilyName()
        {
            return LastName;
        }

        public string OtherNames()
        {
            return FirstNames;
        }*/

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

        public string ReturnStudent(IStudent student)
        {
            string output = ("Student ID: " + student.StudentIdentifier() + ", Student Family Name: "
                + student.FamilyName() + ", Student Other Names: " + student.OtherNames());
            return output;
        }

        public bool CheckID(IStudent student1, IStudent student2)
        {
            if (student1.StudentIdentifier() == student2.StudentIdentifier())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* Kai: public void PrintStudentIdentifier()
        {
            Console.WriteLine("Student ID: {0}", StudentID);
        }

        public void PrintFamilyName()
        {
            Console.WriteLine("Student Family Name: {0}", LastName);
        }

        public void PrintOtherNames()
        {
            Console.WriteLine("Student Other Names: {0}", FirstNames);
        }

        public string ReturnStudent()
        {
            string student = ("Student ID: " + StudentID + ", Student Family Name: " 
                + LastName + ", Student Other Names: " + FirstNames);
            return student;
        }

        public bool CheckID(int studentIdent, int checkInt)
        {
            if (studentIdent == checkInt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
