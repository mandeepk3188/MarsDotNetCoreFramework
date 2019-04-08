using AutomationMars.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationMars.Pages
{
    class LoginPage
    {
        private IWebElement SignIntab => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(.,'Sign In')]"));
        private IWebElement Email => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='email']"));
        private IWebElement Password => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement LoginBtn => GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
        public void LoginSteps()
        {
            //Global.CommonMethods.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Login");
            ////Navigate to the URL
            //Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.CommonMethods.ExcelLib.ReadData(2, "InputValue"));

            ////Click Sign In button
            //Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(3, "Locator"), Global.CommonMethods.ExcelLib.ReadData(3, "LocatorValue"));

            ////Enter UserName
            //Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(4, "Locator"), Global.CommonMethods.ExcelLib.ReadData(4, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(4, "InputValue"));

            ////Enter Password
            //Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(5, "Locator"), Global.CommonMethods.ExcelLib.ReadData(5, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(5, "InputValue"));

            ////Click on Login Button
            //Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(6, "Locator"), Global.CommonMethods.ExcelLib.ReadData(6, "LocatorValue"));
            //Populate the Excel sheet
            CommonMethods.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            GlobalDefinitions.driver.Navigate().GoToUrl(Global.CommonMethods.ExcelLib.ReadData(2, "Url"));
            GlobalDefinitions.driver.Manage().Window.Maximize();

            //Click on Sign In tab
            SignIntab.Click();
            Thread.Sleep(500);

            //Enter the data in Username textbox
            Email.SendKeys(CommonMethods.ExcelLib.ReadData(2, "Username"));
            Thread.Sleep(500);

            //Enter the password 
            Password.SendKeys(CommonMethods.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            LoginBtn.Click();
            Thread.Sleep(1500);

            string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(.,'Mars Logo')]")).Text;

            if (text == "Mars Logo")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Unsuccessful");
            }


        }
    }
}
