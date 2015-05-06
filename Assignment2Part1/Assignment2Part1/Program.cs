//Author: Jennifer Doherty Student ID 22223407
//Title: CSC10210 S1 2015 Assignment 2 Part 1
//Date: 02/05/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and initialise student objects
            StudentUnit student1Unit = new StudentUnit(12345678, "Bobson", "Bob", "CSC10210");
            StudentGrade student1Grade = new StudentGrade(student1Unit.StudentID, 
                student1Unit.LastName, student1Unit.FirstNames,"A");

            StudentDisplay studentDisplay = new StudentDisplay();

            //Print student details
            studentDisplay.PrintStudentIdentifier(student1Unit);
            studentDisplay.PrintFamilyName(student1Unit);
            studentDisplay.PrintOtherNames(student1Unit);

            studentDisplay.PrintStudentIdentifier(student1Grade);
            studentDisplay.PrintFamilyName(student1Grade);
            studentDisplay.PrintOtherNames(student1Grade);

            string student1string = studentDisplay.ReturnStudent(student1Unit);
            Console.WriteLine(student1string);

            //Check if student ID matches given int
            Console.WriteLine("Student's ID matches argument: {0}", studentDisplay.CheckID(student1Unit,student1Grade));

            Console.ReadLine();
        }
    }
}
