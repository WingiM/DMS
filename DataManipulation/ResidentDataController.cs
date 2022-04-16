using System;
using System.IO;

namespace DataManipulation
{
    internal static class ResidentDataController
    {
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

        internal static void GenerateInsertSQLScript(Resident[] residents)
        {
        }
    }
}