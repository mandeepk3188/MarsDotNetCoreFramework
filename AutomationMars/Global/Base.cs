//using AutomationMars.Config;
using AutomationMars.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using static AutomationMars.Global.CommonMethods;

namespace AutomationMars.Global
{
    class Base
    {
        #region To access Path from resource file

        public static int Browser = Int32.Parse(GlobalDefinitions.ReadJson("Browser"));
        public static string ExcelPath = GlobalDefinitions.ReadJson("ExcelPath");
        public static string ScreenshotPath = GlobalDefinitions.ReadJson("Screenshot");
        #endregion

        #region reports
        // public static ExtentTest test;
        // public static ExtentReports extent;
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {
                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;

                case 2:
                    string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    GlobalDefinitions.driver = new ChromeDriver(driverPath);
                    break;

            }

           // extent = new ExtentReports(ReportPath, false, DisplayOrder.OldestFirst);
           // extent.LoadConfig(MarsResource.ReportXMLPath);


            if (GlobalDefinitions.ReadJson("IsLogin") == "true")
            {
                LoginPage loginobj = new LoginPage();
                loginobj.LoginSteps();
            }
            else
            {
                Register obj = new Register();
                obj.RegisterwithValidData();
            }

        }


        [TearDown]
        public void TearDown()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");
           // test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
           // extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
           // extent.Flush();
            // Close the driver            
            GlobalDefinitions.driver.Close();
        }
        #endregion
    }
}
