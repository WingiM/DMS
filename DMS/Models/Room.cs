using System;

namespace DataManipulation
{
    public class Room
    {
        internal int RoomNumber { get; private set; }
        internal int Capacity { get; private set; }
        internal char gender { get; private set; }
        internal int floor_number => (RoomNumber / 100);

        public Room(int roomNumber, int capacity, char gender)
        {
            RoomNumber = roomNumber;
            this.Capacity = capacity;
            this.gender = gender;
        }
    }
}