using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace DataManipulation
{
    internal static class ResidentDataController
    {
        private static readonly string
            ScriptStoringPath = "../../../SQLScripts";

        private static readonly string
            InsertCommandTemplate =
                "INSERT INTO Residents(last_name, first_name, patronymic, gender, birth_date, passport_information, tin) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})";

        internal static void ParseSourceFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Your code here
                }
            }
        }

        internal static void GenerateResidentInsertSqlScript(
            Resident[] residents)
        {
            using (FileStream stream =
                new(Path.Combine(ScriptStoringPath, "insertResidents.sql"),
                    FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new(stream))
            {
                foreach (var resident in residents)
                {
                    writer.WriteLine(GenerateResidentInsertLine(resident));
                }
            }
        }

        private static string GenerateResidentInsertLine(Resident resident)
        {
            var sb = new StringBuilder();
            sb.Append(
                "insert into residents(last_name, first_name, patronymic, gender," +
                "birth_date, passport_information, tin) values (");
            sb.Append($"'{resident.LastName}', ");
            sb.Append($"'{resident.FirstName}', ");
            var patronymic = resident.Patronymic == null
                ? "null"
                : $"'{resident.Patronymic}'";
            sb.Append($"{patronymic}, ");
            sb.Append($"'{resident.Gender}', ");
            sb.Append($"'{resident.DateOfBirth.ToString("d")}', ");
            var passportInfo = resident.PassportInfo == null
                ? "null"
                : $"'{resident.PassportInfo}'";
            sb.Append($"{passportInfo}, ");
            var tin = resident.TIN == null ? "null" : $"'{resident.TIN}'";
            sb.Append($"{tin});");

            return sb.ToString();
        }
    }
}