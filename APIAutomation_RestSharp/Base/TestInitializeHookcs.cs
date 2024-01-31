using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomation_RestSharp.Base
{
    public class TestInitializeHookcs
    {
        public static Dictionary<string, string> customchromeoptions;
        private readonly ParallelConfig parallelConfig;
        public TestInitializeHookcs(ParallelConfig parallelConfig)
        {
            this.parallelConfig = parallelConfig;
        }
        public static ExtentHtmlReporter CreateExtentReportInstance(String featureName)
        {
            ParallelConfig parallelConfig = new ParallelConfig();
            string text = DateTime.Now.ToString("dd-MM-yyyy-HHmmss");
            string currentProjectDictory = parallelConfig.GetCurrentProjectDirectory();
            string text2 = Path.Combine(currentProjectDictory, "TestResults", "ExtentReports_" + text, featureName);
            if (!Directory.Exists(text2))
            {
                Directory.CreateDirectory(text2);
            }
            ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter(text2);
            extentHtmlReporter.Config.Theme = Theme.Dark;
            extentHtmlReporter.Config.DocumentTitle = "Test Automation Report";
            extentHtmlReporter.Config.ReportName = "test Automationn Report";
            extentHtmlReporter.Config.EnableTimeline = true;
            return extentHtmlReporter;

        }
    }
}
