using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    //Creates a unit object inheriting from interface IStudent
    public class StudentUnit : IStudent
    {
        //Properties
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstNames { get; set; }
        public string UnitName { get; set; }

        //Constructor
        public StudentUnit(int ident, string last, string first, string unit)
        {
            StudentID = ident;
            LastName = last;
            FirstNames = first;
            UnitName = unit;
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
