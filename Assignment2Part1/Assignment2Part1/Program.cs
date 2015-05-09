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
            StudentGrade student2Grade = new StudentGrade(87654321, "Jonson", "Jon", "HD");

            //Create empty placeholder studentDisplay object
            StudentDisplay studentDisplay = new StudentDisplay();

            //Create formatted strings of both student objects
            string student1string = studentDisplay.ReturnStudent(student1Unit);
            string student2string = studentDisplay.ReturnStudent(student2Grade);

            //Print student 1 details
            Console.WriteLine("Student 1's details:");
            studentDisplay.PrintStudentIdentifier(student1Unit);
            studentDisplay.PrintFamilyName(student1Unit);
            studentDisplay.PrintOtherNames(student1Unit);
            Console.WriteLine("Student Unit: " + student1Unit.UnitTitle());
            Console.WriteLine();
            Console.WriteLine(student1string + ", Student Unit: " + student1Unit.UnitTitle());
            Console.WriteLine();

            //Print student 2 details
            Console.WriteLine("Student 2's details:");
            studentDisplay.PrintStudentIdentifier(student2Grade);
            studentDisplay.PrintFamilyName(student2Grade);
            studentDisplay.PrintOtherNames(student2Grade);
            Console.WriteLine("Student Grade: " + student2Grade.UnitResult());
            Console.WriteLine();
            Console.WriteLine(student2string + ", Student Grade: " + student2Grade.UnitResult());
            Console.WriteLine();

            //Check if the student IDs match a given integer
            const int CHECKINT = 12345678;
            Console.WriteLine("Check if student IDs match integer {0}",CHECKINT);
            Console.WriteLine("Student 1's ID matches argument: {0}", studentDisplay.CheckID(student1Unit,CHECKINT));
            Console.WriteLine("Student 2's ID matches argument: {0}", studentDisplay.CheckID(student2Grade,CHECKINT));

            Console.ReadLine();
        }
    }
}
