using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part3
{
    public class Money
    {
        //Properties
        public int Dollars { get; set; }
        public int Cents { get; set; }

        //Constructors
        public Money(int d, int c)
        {
            Dollars = d;
            try
            {
                if (c >= 0 && c <= 99)
                {
                    Cents = c;
                }
                else
                {
                    throw new MoneyException(0, "Cents must be between 0 and 99");
                }
            }
            catch (MoneyException centsException)
            {
                Console.WriteLine(centsException.Message);
                Console.ReadLine();
            }
        }

        public Money(int d)
        {
            Dollars = d;
        }

        public override string ToString()
        {
            if (Cents < 10)
            {
                return string.Format("${0}.0{1}", Dollars, Cents);
            }
            else
            {
                return string.Format("${0}.{1}", Dollars, Cents);
            }
        }
    }
}
