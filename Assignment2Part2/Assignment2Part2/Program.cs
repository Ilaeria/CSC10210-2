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
            Room r01 = new Room("M123", "management", 56, 5);
            Room r02 = new Room("M456", "management", 62, 6);
            Room r03 = new Room("M789", "management", 68, 10);
            Room r04 = new Room("F123", "faculty", 55, 9);
            Room r05 = new Room("F456", "faculty", 60, 11);
            Room r06 = new Room("F789", "faculty", 65, 12);
            Room r07 = new Room("S123", "students", 70, 20);
            Room r08 = new Room("S456", "students", 75, 21);
            Room r09 = new Room("S789", "students", 80, 22);
            Room r10 = new Room("K999", "kitchen", 35, 4);

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
            RoomDisplay.DisplayAllRooms(rooms);
            Console.ReadLine();

            RoomDisplay.DeleteRoom(rooms);
            Console.ReadLine();

            RoomDisplay.DisplayRoom(rooms);
            Console.ReadLine();

            RoomDisplay.RoomsByIdentifier(rooms);
            Console.ReadLine();

            RoomDisplay.RoomsBySize(rooms);
            Console.ReadLine();

            RoomDisplay.LargeRooms(rooms);
            Console.ReadLine();

            RoomDisplay.RoomsByOccupants(rooms);
            Console.ReadLine();
        }  
    }
}
