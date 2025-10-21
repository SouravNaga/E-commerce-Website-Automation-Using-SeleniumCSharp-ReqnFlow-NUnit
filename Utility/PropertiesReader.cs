using AventStack.ExtentReports;
using Utility;

namespace ReqnFlowFramework.Reporting
{
    public class PropertiesReader
    {
        public static Dictionary<string, string> LoadProperties(string filePath)
        {
            var properties = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                {
                    var parts = line.Split('=', 2);
                    if (parts.Length == 2)
                    {
                        properties[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }
            return properties;
        }


    }
}