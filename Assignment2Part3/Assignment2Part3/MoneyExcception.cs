using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part3
{
    //Handle various formatting exceptions with the Money class
    public class MoneyException : Exception
    {
        public int code = 0;
        public string error = "";

        //default constructor
        public MoneyException()
            : base("Your money is not in the correct format.")
        {

        }

        //constructor with error message
        public MoneyException(int errorCode, string errorMessage)
            : base(errorMessage)
        {
            this.code = errorCode;
            this.error = errorMessage;
        }
    }
}
