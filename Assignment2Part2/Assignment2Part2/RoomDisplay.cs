using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part2
{
    //Various methods for displaying rooms
    public class RoomDisplay
    {
        //constructor
        public RoomDisplay()
        {
        }

        //Display details of all rooms in the dictionary
        public static void DisplayAllRooms(Dictionary<string, Room> displayRooms)
        {
            Console.WriteLine("All Rooms:");
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
            Console.WriteLine();
        }

        //Print rooms in ascending identifier order
        public static void RoomsByIdentifier(Dictionary<string, Room> roomsByID)
        {

            List<string> roomIDs = new List<string>(roomsByID.Keys);
            roomIDs.Sort();

            Console.WriteLine("Rooms by ID:");
            foreach (string n in roomIDs)
                Console.WriteLine(roomsByID[n]);
            Console.WriteLine();
        }

        //Print rooms in ascending size order
        public static void RoomsBySize(Dictionary<string, Room> roomsBySize)
        {
            var roomSizes =
                from r in roomsBySize.Values
                orderby r.Size
                select r;

            Console.WriteLine("Rooms by size:");
            DisplayLINQ(roomSizes);
        }

        //Print all rooms that seat between 10 and 20 people
        public static void LargeRooms(Dictionary<string, Room> largeRooms)
        {
            var roomsLarge =
                from r in largeRooms.Values
                where r.Occupants >= 10 && r.Occupants <= 20
                select r;

            Console.WriteLine("Rooms that seat between 10 and 20 people (inclusive):");
            DisplayLINQ(roomsLarge);
        }

        //List room IDs and Sizes in order of descending seating numbers
        public static void RoomsByOccupants(Dictionary<string, Room> roomsByOccupants)
        {
            var roomsSeating =
                from r in roomsByOccupants.Values
                orderby r.Occupants descending
                select new { r.ID, r.Size };

            Console.WriteLine("Room Ids and sizes in descending seating capacity:");
            foreach (var r in roomsSeating)
                Console.WriteLine("Room ID: {0}, Room Size: {1}", r.ID, r.Size);
            Console.WriteLine();
        }

        //Display LINQ queries
        public static void DisplayLINQ<T>(IEnumerable<T> list)
        {
            foreach (T elt in list)
                Console.WriteLine(elt);
            Console.WriteLine();
        }
    }
}
