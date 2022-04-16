using System;
using System.IO;

namespace DataManipulation
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var residents = ResidentDataController.ParseSourceFile("TestData.txt");
            ResidentDataController.GenerateResidentInsertSqlScript(residents);
        }
    }
}