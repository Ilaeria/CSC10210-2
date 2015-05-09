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
            }
        }

        public Money(int d)
        {
            Dollars = d;
        }

        //Formatting string override
        public override string ToString()
        {
            return string.Format("${0}.{1:D2}", Dollars, Cents);
        }

        //Overloading == and !=
        public static bool operator ==(Money m1, Money m2)
        {
            if (m1.Dollars == m2.Dollars && m1.Cents == m2.Cents)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Money m1, Money m2)
        {
            if (m1.Dollars != m2.Dollars && m1.Cents != m2.Cents)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        //Overloading < and <=
        public static bool operator <(Money m1, Money m2)
        {
            if (m1.Dollars < m2.Dollars)
            {
                return true;
            }
            else if (m1.Dollars > m2.Dollars)
            {
                return false;
            }
            else
            {
                return m1.Cents < m2.Cents;
            }
        }

        public static bool operator <=(Money m1, Money m2)
        {
            if (m1.Dollars <= m2.Dollars)
            {
                return true;
            }
            else if (m1.Dollars > m2.Dollars)
            {
                return false;
            }
            else
            {
                return m1.Cents <= m2.Cents;
            }
        }
        
        //Overloading > and >=
        public static bool operator >(Money m1, Money m2)
        {
            if (m1.Dollars > m2.Dollars)
            {
                return true;
            }
            else if (m1.Dollars < m2.Dollars)
            {
                return false;
            }
            else
            {
                return m1.Cents > m2.Cents;
            }
        }

        public static bool operator >=(Money m1, Money m2)
        {
            if (m1.Dollars >= m2.Dollars)
            {
                return true;
            }
            else if (m1.Dollars < m2.Dollars)
            {
                return false;
            }
            else
            {
                return m1.Cents >= m2.Cents;
            }
        }

        //Overloading +
        public static Money operator +(Money m1, Money m2)
        {
            int cent = m1.Cents + m2.Cents;
            int dollar = m1.Dollars + m2.Dollars;

            if (cent > 99)
            {
                return new Money(++dollar, cent - 100);
            }
            else
            {
                return new Money(dollar, cent);
            }
        }

        //Overloading -
        public static Money operator -(Money m1, Money m2)
        {   
            int cent = m1.Cents - m2.Cents;
            int dollar = m1.Dollars - m2.Dollars;

            try
            {
                if (dollar < 0)
                {
                    throw new MoneyException(1, "Your balance can't be negative!");
                }
                else if (cent < 0)
                {
                    --dollar;
                    cent = cent + 100;
                    if (dollar < 0)
                    {
                        throw new MoneyException(1, "Your balance can't be negative!");
                    }
                    else
                    {
                        return new Money(dollar, cent);
                    }
                }
                else
                {
                    return new Money(dollar, cent);
                }
            }
            catch (MoneyException centsException)
            {
                Console.WriteLine(centsException.Message);
                return new Money(0, 0);
            }
        }

        //Overloading *
        public static Money operator *(Money m, int multiplier)
        {
            try
            {
                if (multiplier < 0)
                {
                    throw new MoneyException(2, "You can't multiply by a negative number!");
                }
                else
                {
                    int cent = m.Cents * multiplier;
                    int dollar = m.Dollars * multiplier;

                    if (cent > 99)
                    {
                        dollar = dollar + (Convert.ToInt32(cent / 100));
                        cent = 0;
                        Console.WriteLine("This value may have been rounded down to the nearest dollar");
                    }
                    return new Money(dollar, cent);
                }
            }
            catch (MoneyException multiplierException)
            {
                Console.WriteLine(multiplierException.Message);
                return new Money(0, 0);
            }
        }
    }
}
