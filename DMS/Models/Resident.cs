using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace DMS.Models
{
    public class Resident
    {
        [Column("resident_id")]
        internal int ResidentId { get; private set; }
        
        [Column("last_name")]
        internal string LastName { get; private set; }
        
        [Column("first_name")]
        internal string FirstName { get; private set; }
        
        [Column("patronymic")]
        internal string? Patronymic { get; private set; }
        
        [Column("gender")]
        internal char Gender { get; private set; }
        
        [Column("birth_date")]
        internal DateTime BirthDate { get; private set; }
        
        [Column("passport_information")]
        internal string? PassportInformation { get; private set; }
        
        [Column("tin")]
        internal string? Tin { get; private set; }
        
        [Column("room_number")]
        internal int RoomNumber { get; private set; }

        public Resident(int residentId, string lastName, string firstName,
            string? patronymic, char gender, DateTime dateOfBirth, int roomNumber)
        {
            ResidentId = residentId;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Gender = gender;
            RoomNumber = roomNumber;
            BirthDate = dateOfBirth.Date;
        }

        internal void FillDocuments(string? passportInfo, string? TIN)
        {
            PassportInformation = passportInfo;
            this.Tin = TIN;
        }
    }
}