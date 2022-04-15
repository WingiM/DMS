using System;

namespace DataManipulation
{
    public class Resident
    {
        internal int ID { get; private set; }
        internal string LastName { get; private set; }
        internal string FirstName { get; private set; }
        internal string Patronymic { get; private set; }
        internal char Gender { get; private set; }
        internal DateTime DateOfBirth { get; private set; }
        internal string PassportInfo { get; private set; }
        internal string TIN { get; private set; }
        internal bool IsEvicted { get; private set; }
        
        public Resident(int id, string lastName, string firstName, string patronymic, char gender, DateTime dateOfBirth)
        {
            ID = id;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        internal void FillDocuments(string passportInfo, string TIN)
        {
            PassportInfo = passportInfo;
            this.TIN = TIN;
        }
    }
}