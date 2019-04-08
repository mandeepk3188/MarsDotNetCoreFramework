using AutomationMars.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationMars.Pages
{
    class Profile
    {
        #region
        //Find  profile tab
        private IWebElement profiletab => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
        //*************
        //Find profile picture
        private IWebElement image => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[1]/img"));
        //*************
        //PROFILE NAME SECTION
        //Find Name Dropdown
        private IWebElement namedropdown => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
        //Find first name 
        private IWebElement FirstName => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
        //Find Last name
        private IWebElement lastname => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
        //Find Name save button
        private IWebElement Namaesave => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
        //********************
        //Find Availability Edit button
        private IWebElement AvailEdit => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        //find Avaialability subdropdown
        private IWebElement Availdropdown => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
        // FInd availablity option
        private IWebElement Availoption => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
        //*********************

        //Find Hours edit button
        private IWebElement hoursedit => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        //Find hours dropdown
        private IWebElement hoursdropdown => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
        //Find hours option
        private IWebElement hoursoption => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
        //*******************

        //find Earn Target edit button
        private IWebElement earnedit => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        //find Earn Target dropdown
        private IWebElement earndropdown => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
        //Find Earn Target option
        private IWebElement earnoption => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
        //******************

        //Find Description Edit icon
        private IWebElement descedit => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        //Find Description textbox
        private IWebElement descbox => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        //Find Description save button
        private IWebElement descsave => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        //**************************

        //Find xpath for language tab
        private IWebElement Languagetab => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        //Find xpath for Ad New Language
        private IWebElement Newlanguage => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        //Find Xpath for Add language textbox
        private IWebElement AddLanguage => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        //Find xpath for choose language dropdown
        private IWebElement Languagedropdown => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        //find xpath for  any option from dropdown
        private IWebElement SelectLanguage => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
        // find xpath for save language
        private IWebElement SaveLanguage => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        //********************

        //verification
        private IWebElement Test => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
        #endregion
        public void ProfileSteps()
        {
            try
            {
                CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                //Click on profile tab
                profiletab.Click();

                //Enter FirstName and LastName
                namedropdown.Click(); //Click on Profile Name drop Down
                Thread.Sleep(1500);

                FirstName.Clear(); //Clear text from First name textbox
                Thread.Sleep(1500);

                FirstName.SendKeys(CommonMethods.ExcelLib.ReadData(2, "FirstName"));//Enter first name in textbox1
                Thread.Sleep(1500);

                lastname.Clear();//Clear last name textbox
                Thread.Sleep(1500);

                lastname.SendKeys(CommonMethods.ExcelLib.ReadData(2, "LastName"));//Enter last name in textbox 2
                Namaesave.Click();//Click on save button to save Profile Name
                Thread.Sleep(1500);

                //Click on Edit Availability Icon
                AvailEdit.Click();//Click on avaliability icon button
                Thread.Sleep(1500);
                Availdropdown.Click(); //Click on availability dropdown
                Thread.Sleep(1500);
                Availoption.Click();//Select availability option from dropdown
                Thread.Sleep(1500);

                //Click on Hours edit icon button
                hoursedit.Click();
                Thread.Sleep(1500);
                hoursdropdown.Click();
                Thread.Sleep(1500);
                hoursoption.Click();
                Thread.Sleep(1500);

                //Click on earn target icon button
                earnedit.Click();
                Thread.Sleep(1500);
                earndropdown.Click();
                Thread.Sleep(1500);
                earnoption.Click();
                Thread.Sleep(1500);

                //Enter Description
                descedit.Click();
                Thread.Sleep(1500);
                descbox.Clear();
                Thread.Sleep(1500);
                descbox.SendKeys(CommonMethods.ExcelLib.ReadData(2, "Description"));
                Thread.Sleep(1500);
                descsave.Click();
                Thread.Sleep(1500);

                //Add Language
                Languagetab.Click();
                Thread.Sleep(1500);

                Newlanguage.Click();
                Thread.Sleep(1500);

                AddLanguage.SendKeys(CommonMethods.ExcelLib.ReadData(2, "Language"));
                Thread.Sleep(1500);

                Languagedropdown.Click();
                Thread.Sleep(1500);

                SelectLanguage.Click();
                Thread.Sleep(2500);

                SaveLanguage.Click();
                Thread.Sleep(1000);

                //Verification
                Thread.Sleep(1000);
                string msg = CommonMethods.ExcelLib.ReadData(2, "DATA");
                string Actualmsg = Test.Text;
                Console.WriteLine(Actualmsg);
                Console.WriteLine(msg);
                Thread.Sleep(500);
                if (msg == Actualmsg)
                {
                    Console.WriteLine("Profile Updated Successfully");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Fail, Profile is Not Updated Successfully",e.Message);
            }
               

        }

    }
}
