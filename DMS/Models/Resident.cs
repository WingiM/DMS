using System;
using System.Data.SqlTypes;

namespace DMS.Models
{
    public class Resident
    {
        internal int resident_id { get; private set; }
        internal string last_name { get; private set; }
        internal string first_name { get; private set; }
        internal string? patronymic { get; private set; }
        internal char gender { get; private set; }
        internal DateTime birth_date { get; private set; }
        internal string? passport_information { get; private set; }
        internal string? tin { get; private set; }
        internal int room_number { get; private set; }

        public Resident(int residentId, string lastName, string firstName,
            string? patronymic, char gender, DateTime dateOfBirth, int roomNumber)
        {
            resident_id = residentId;
            last_name = lastName;
            first_name = firstName;
            this.patronymic = patronymic;
            this.gender = gender;
            room_number = roomNumber;
            birth_date = dateOfBirth.Date;
        }

        internal void FillDocuments(string? passportInfo, string? TIN)
        {
            passport_information = passportInfo;
            this.tin = TIN;
        }
    }
}