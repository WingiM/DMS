using System;

namespace DataManipulation
{
    internal class Resident
    {
        internal int ID { get; private set; }
        internal string LastName { get; private set; }
        internal string FirstName { get; private set; }
        internal string Patronymic { get; private set; }
        internal char Gender { get; private set; }
        internal DateTime DateOfBirth { get; private set; }
        internal string PassportInfo { get; private set; }
        internal string TIN { get; private set; }
        internal string RoomNumber { get; private set; }

        internal Resident(int id, string lastName, string firstName, 
            string Patronymic, char gender, DateTime dateOfBirth)
        {
            // Continue by yourself
        }

        internal void FillDocuments(string passportInfo, string TIN)
        {
            
        }

        internal void SettleInRoom(string roomNumber)
        {
            
        }
    }
}