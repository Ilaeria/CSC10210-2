//Author: Jennifer Doherty Student ID 22223407
//Title: CSC10210 S1 2015 Assignment 2 Part 1
//Date: 02/05/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating money amounts to test various operators
            
            Money cash1 = new Money(22, 75);
            Money cash2 = new Money(8);
            Money bill1 = new Money(22, 75);
            Money bill2 = new Money(22, 75);

            //Printing money
            Console.WriteLine("Your available cash: {0}", cash1);
            Console.WriteLine("Your friend's available cash: {0}", cash2);
            Console.WriteLine("Your first bill: {0}", bill1);
            Console.WriteLine("Your second bill: {0}", bill2);

            //Example of invalid money
            Money invalid = new Money(44, 123);
            Console.WriteLine();

            //Testing operator ==
            if (bill1 == bill2)
            {
                Console.WriteLine("These bills are for the same amount.");
            }
            else
            {
                Console.WriteLine("These bills are different amounts.");
            }

            //Testing operator !=
            if (cash1 != cash2)
            {
                Console.WriteLine("These cash amounts are different.");
            }
            else
            {
                Console.WriteLine("These cash amounts are the same.");
            }
            Console.WriteLine();

            //Testing operator <=
            if (bill1 <= cash1)
            {
                Console.WriteLine("You have enough cash for your bill.");
            }
            else
            {
                Console.WriteLine("You don't have enough cash for your bill!");
            }

            //Testing operator <
            if (bill2 < cash2)
            {
                Console.WriteLine("Your friend has enough cash for their bill.");
            }
            else
            {
                Console.WriteLine("You friend doesn't have enough cash for their bill!");
            }
            Console.WriteLine();

            //Testing operator +
            Money totalCash = cash1 + cash2;
            Console.WriteLine("Your total cash is: {0}", totalCash);

            Money totalBills = bill1 + bill2;
            Console.WriteLine("Your total bills are: {0}", totalBills);

            //Testing operator -
            Money balance = totalCash - totalBills;
            Money outOfCash = new Money(0, 0);

            if (balance == outOfCash)
            {
                Console.WriteLine("You're out of money!");
            }
            else
            {
                Console.WriteLine("Your combined balance after paying all the bills is: {0}", balance);
            }
            Console.WriteLine();

            //Testing operator *
            int multi = 4;
            Money testMulti = totalCash * multi;
            Money negativeMulti = new Money(0, 0);

            if (testMulti == negativeMulti)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("If you multiplied your total cash {0} by {1} you would have {2}",
                    totalCash, multi, testMulti);
            }

            Console.ReadLine();
        }
    }
}
