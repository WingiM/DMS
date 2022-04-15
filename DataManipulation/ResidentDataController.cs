using System;
using System.IO;

namespace DataManipulation
{
    internal static class ResidentDataController
    {
        internal static void ParseSourceFile(string filename)
        {
            try
            {
                var fileLines = File.ReadLines(filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        internal static void GenerateInsertSQLScript(Resident[] residents)
        {
            
        }
    }
}