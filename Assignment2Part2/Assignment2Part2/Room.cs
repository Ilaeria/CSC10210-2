//Class provided with assignment details

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part2
{
    // simple class to represent University room data - Part 2 of Assignment
    public class Room
    {
        private String ident; // e.g. "MG.31"
        private String usage; // e.g. "staff", "kitchen"
        private int size; // size in square metres
        private int occupants; // number of people usually accomodated.
        public Room(string id, string use, int s, int occ)
        {
            ident = id;
            usage = use;
            size = s;
            occupants = occ;
        }
        public string ID // identifier is immutable
        {
            get
            {
                return ident;
            }
        }
        public string Usage
        {
            get
            {
                return usage;
            }
            set
            {
                usage = value;
            }
        }
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public int Occupants
        {
            get
            {
                return occupants;
            }
            set
            {
                occupants = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}, {2}sq. Metres, seats {3}",
            ident, usage, size, occupants);
        }
    }
}
