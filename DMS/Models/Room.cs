using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataManipulation
{
    public class Room
    {
        [Column("room_number")]
        internal int RoomNumber { get; private set; }
        
        [Column("capacity")]
        internal int Capacity { get; private set; }
        
        [Column("gender")]
        internal char Gender { get; private set; }
        
        [Column("floor_number")]
        internal int FloorNumber => (RoomNumber / 100);

        public Room(int roomNumber, int capacity, char gender)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Gender = gender;
        }
    }
}