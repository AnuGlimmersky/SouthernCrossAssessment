using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SouthernCrossAssessment.Support
{
    public class DataReader
    {
        public static List<UserData> ReadUserDataFromJsonFile(string filePath)
        {
            var jsonContent = File.ReadAllText(filePath);
            var userData = JsonSerializer.Deserialize<List<UserData>>(jsonContent);
            return userData;
        }
    }
}
