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
            Money cost = new Money(23, 17);
            Money bill = new Money(100);

            Console.WriteLine(cost);
            Console.WriteLine(bill);

            Money invalid = new Money(44, 123);

            Console.ReadLine();
        }
    }
}
