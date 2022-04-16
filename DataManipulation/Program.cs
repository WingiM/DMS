using System;
using System.IO;

namespace DataManipulation
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ResidentDataController.GenerateResidentInsertSqlScript(
                new Resident[]
                {
                    new Resident(1, "Name", "name", null, 'm',
                        DateTime.Today)
                });
            // ResidentDataController.ParseSourceFile("text.txt");
        }
    }
}