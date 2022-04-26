using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataManipulation
{
    internal static class ResidentDataController
    {
        private static readonly string
            ScriptStoringPath = "../../../SQLScripts";

        private static readonly string
            SourceFilesStoringPath = "../../../SourceFiles";

        internal static Resident[] ParseSourceFile(string filename)
        {
            List<Resident> residents = new();
            using (StreamReader reader =
                new(Path.Combine(SourceFilesStoringPath,
                    filename)))
            {
                string? line = filename;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] temp = line.Split('\t');
                    string[] date = temp[5].Split('.');

                    int day = Convert.ToInt32(date[0]);
                    int month = Convert.ToInt32(date[1]);
                    int year = Convert.ToInt32(date[2]);

                    Resident resident = new Resident(Convert.ToInt32(temp[0]),
                        temp[1], temp[2],
                        temp[3].Equals("null") ? null : temp[3], temp[4][0],
                        new DateTime(year, month, day));

                    resident.FillDocuments(
                        temp[6].Equals("null") ? null : temp[6],
                        temp[7].Equals("null") ? null : temp[7]);

                    residents.Add(resident);
                }
            }

            return residents.ToArray();
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
            sb.Append($"'{resident.DateOfBirth:MM/dd/yyyy}', ");
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