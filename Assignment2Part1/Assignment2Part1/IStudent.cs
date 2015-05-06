using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    //Creates an interface template for students at a university
    public interface IStudent
    {
        int StudentIdentifier(); //ID of student
        string FamilyName(); //family name
        string OtherNames(); //other names
    }
}
