using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace AutomationMars.Global
{
    class GlobalDefinitions
    {
        //Initialize the driver
        public static IWebDriver driver { get; set; }
        
        internal static string ReadJson(string resource)
        {
            string path="null";
            var WebClient = new WebClient();
            var json = WebClient.DownloadString(@"C:\Users\admin\Source\Repos\AutomationMars\AutomationMars\Config\MarsResourcee.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            switch (resource)
            {
                case "ExcelPath":
                path = result.Urls.ExcelPath;
                    break;
                case "Browser":
                    path = result.Urls.Browser;
                    break;
                case "IsLogin":
                    path = result.Urls.IsLogin;
                    break;
                case "Screenshot":
                    path = result.Urls.Screenshot;
                    break;
            }
            return path;
        }

    }
}
