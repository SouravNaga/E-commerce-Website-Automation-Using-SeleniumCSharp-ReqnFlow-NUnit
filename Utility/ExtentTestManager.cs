using AventStack.ExtentReports;
using Utility;
using System.Threading;

namespace ReqnFlowFramework.Reporting
{
    public class ExtentTestManager
    {
        // 🔐 Thread-safe test instance
        private static ThreadLocal<ExtentTest> _test = new ThreadLocal<ExtentTest>();

        public static void CreateTest(string testName)
        {
            var extent = ExtentReportManager.GetExtent();
            _test.Value = extent.CreateTest(testName);
        }

        public static ExtentTest GetTest()
        {
            return _test.Value;
        }
    }
}