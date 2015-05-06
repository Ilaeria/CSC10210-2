using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    //Creates a grade object for a student in a unit
    public class StudentGrade : IStudent
    {
        //Properties
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstNames { get; set; }
        public string UnitGrade { get; set;}

        //Constructor
        public StudentGrade(int ident, string last, string first, string grade)
        {
            StudentID = ident;
            LastName = last;
            FirstNames = first;
            UnitGrade = grade;
        }

        //Interface methods
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
        }
    }
}
