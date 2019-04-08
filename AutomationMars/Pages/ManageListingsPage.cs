using AutomationMars.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static AutomationMars.Global.CommonMethods;

namespace AutomationMars.Pages
{
    class ManageListingsPage
    {
        #region
        IWebElement ListingsTable => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]"));
        IWebElement btnManagingListing => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(.,'Manage Listings')]"));
        IWebElement txtSearch => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Search skills']"));
        IWebElement iconSearch => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='search link icon']"));
        IWebElement labelNotFound => GlobalDefinitions.driver.FindElement(By.XPath("//h3[contains(.,'No results found, please select a new category!')]"));
        #endregion
        public void chkSlider()
        {
            btnManagingListing.Click();
            //Populate the Excel Sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(1000);
            string title = ExcelLib.ReadData(2, "InputValue");
            List<IWebElement> listTd = new List<IWebElement>(ListingsTable.FindElements(By.TagName("td")));
            for (int i = 0; i < listTd.Count; i++)
            {
                if (listTd.ElementAt(i).Text.Equals(title))
                {
                    listTd.ElementAt(i + 4).Click();
                    break;
                }
            }
        }
        public void verifyDeactivated()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
                Thread.Sleep(500);
                string title = ExcelLib.ReadData(2, "InputValue");
                txtSearch.SendKeys(title);
                Thread.Sleep(1000);
                iconSearch.Click();
                Thread.Sleep(1000);
                string expectedValue = "No results found, please select a new category!";

                string actualValue = labelNotFound.Text;
                if (expectedValue.Equals(actualValue))
                {
                    
                    btnManagingListing.Click();
                    List<IWebElement> listTd = new List<IWebElement>(ListingsTable.FindElements(By.TagName("td")));
                    for (int i = 0; i < listTd.Count; i++)
                    {
                        if (listTd.ElementAt(i).Text.Equals(title))
                        {
                            listTd.ElementAt(i + 4).Click();
                            break;
                        }
                    }
                    Console.WriteLine("The list is Deactivated Successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The list is Not Deactivated", e.Message);
            }

        }
    }
}
