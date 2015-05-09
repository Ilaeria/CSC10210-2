//Author: Jennifer Doherty Student ID 22223407
//Title: CSC10210 S1 2015 Assignment 2 Part 1
//Date: 02/05/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the rooms
            Room r01 = new Room("M123", "management", 9, 2);
            Room r02 = new Room("M456", "management", 12, 3);
            Room r03 = new Room("M789", "management", 15, 4);
            Room r04 = new Room("F123", "faculty", 8, 2);
            Room r05 = new Room("F456", "faculty", 10, 3);
            Room r06 = new Room("F789", "faculty", 12, 4);
            Room r07 = new Room("S123", "students", 20, 5);
            Room r08 = new Room("S456", "students", 22, 6);
            Room r09 = new Room("S789", "students", 24, 7);
            Room r10 = new Room("K999", "kitchen", 20, 4);

            //Create the rooms dictionary
            Dictionary<string, Room> rooms = new Dictionary<string, Room>();
            rooms.Add(r01.ID, r01);
            rooms.Add(r02.ID, r02);
            rooms.Add(r03.ID, r03);
            rooms.Add(r04.ID, r04);
            rooms.Add(r05.ID, r05);
            rooms.Add(r06.ID, r06);
            rooms.Add(r07.ID, r07);
            rooms.Add(r08.ID, r08);
            rooms.Add(r09.ID, r09);
            rooms.Add(r10.ID, r10);

            //Run required methods
            DisplayDictionary(rooms);

            DeleteRoom(rooms);

            DisplayRoom(rooms);

            Console.ReadLine();
        }

        //Display details of all rooms in the dictionary
        public static void DisplayDictionary(Dictionary<string, Room> displayRooms)
        {
            foreach (KeyValuePair<string, Room> p in displayRooms)
                Console.WriteLine("Room {0}'s details: {1}", p.Key, p.Value);
            Console.WriteLine();
        }

        //Delete a given room identifier from the dictionary
        public static void DeleteRoom(Dictionary<string, Room> deleteRoom)
        {
            Console.WriteLine("Which room would you like to delete?");
            string key = Console.ReadLine();
            if (deleteRoom.ContainsKey(key))
            { 
                deleteRoom.Remove(key);
                Console.WriteLine("Room {0} removed!", key);
            }
            else
            {
                Console.WriteLine("Room {0} does not exist!", key);
            }
            Console.WriteLine();
        }

        //Display a specific room
        public static void DisplayRoom(Dictionary<string, Room> displayRoom)
        {
            Console.WriteLine("Which room would you like to display?");
            string key = Console.ReadLine();
            Room r;
            if (displayRoom.TryGetValue(key, out r))
            {
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Room {0} does not exist!", key);
            }
        }


    }
}
