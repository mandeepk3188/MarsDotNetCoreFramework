using AutoItX3Lib;
using AutomationMars.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static AutomationMars.Global.CommonMethods;


namespace AutomationMars.Pages
{
    class ShareSkillPage
    {
        #region Initialze Web Elements
        IWebElement btnShareSkill => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(.,'Share Skill')]"));
        IWebElement txtTitle => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@name,'title')]"));
        IWebElement txtDescription => GlobalDefinitions.driver.FindElement(By.XPath("//textarea[@name='description']"));
        IWebElement ddbCategory => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select"));
        IWebElement ddbSubCategory => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
        IWebElement txtTags => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        IWebElement txtT => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        IWebElement serviceType => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]"));
        IWebElement locationType => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div"));
        IWebElement txtStartDate => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='startDate']"));
        IWebElement txtEndDate => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='endDate']"));
        IWebElement chbAvailableDay => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div"));
        IWebElement txtStartTime => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input"));
        IWebElement txtEndTime => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input"));
        IWebElement rdSkillTrade => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div"));
        IWebElement txtCredit => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Amount']"));
        IWebElement iconWorkSample => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
        IWebElement rdActive => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div"));
        IWebElement btnSave => GlobalDefinitions.driver.FindElement(By.XPath("//input[@value='Save']"));
        IWebElement listingsBody => GlobalDefinitions.driver.FindElement(By.XPath("//table[@class='ui striped table']"));
        IWebElement myList => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]"));
        IWebElement titleMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[1]/div"));
        IWebElement descriptionMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[1]/div"));
        IWebElement categoryMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[1]/div"));
        IWebElement tagMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[1]/div"));
        IWebElement sTypeMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[1]/div"));
        IWebElement lTypeMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[1]/div"));
        IWebElement aDayMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[1]/div"));
        IWebElement sTradeMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[1]/div"));
        IWebElement sExchangeMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[3]/div"));
        IWebElement wSampleMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[1]/div"));
        IWebElement activeMessage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[1]/div"));
        IWebElement wSampleInput => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id=\"selectFile\"]"));
        #endregion
        public void bbtnShareSkill()
        {
            btnShareSkill.Click();
        }

        public void enterShareskill()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string title = ExcelLib.ReadData(2, "InputValue");
            string description = ExcelLib.ReadData(3, "InputValue");
            string category = ExcelLib.ReadData(4, "InputValue");
            string tag = ExcelLib.ReadData(6, "InputValue");
            string sDate = ExcelLib.ReadData(9, "InputValue");
            string eDate = ExcelLib.ReadData(10, "InputValue");
            string sTime = ExcelLib.ReadData(12, "InputValue");
            string eTime = ExcelLib.ReadData(13, "InputValue");
            string credit = ExcelLib.ReadData(15, "InputValue");

            txtTitle.SendKeys(title);
            txtDescription.SendKeys(description);
            Category();
            txtTags.SendKeys(tag);
            txtTags.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);
            rdServiceType();
            rdLocationType();

            txtStartDate.SendKeys(OpenQA.Selenium.Keys.Backspace);
            Thread.Sleep(500);
            string format = "dd/MM/yyyy";
            string newsDate = DateTime.Parse(sDate).ToString(format);
            string neweDate = DateTime.Parse(eDate).ToString(format);
            txtStartDate.SendKeys(newsDate);
            Thread.Sleep(500);
            txtEndDate.SendKeys(OpenQA.Selenium.Keys.Backspace);
            Thread.Sleep(500);
            txtEndDate.SendKeys(neweDate);
            Thread.Sleep(500);
            cchbAvailableDay();
            Thread.Sleep(500);
            txtStartTime.SendKeys(sTime);
            Thread.Sleep(100);
            txtEndTime.SendKeys(eTime);
            Thread.Sleep(500);
            rrdSkillTrade();
            Thread.Sleep(500);
            txtCredit.SendKeys(credit);
            Thread.Sleep(500);
            wSampleInput.SendKeys(@ExcelLib.ReadData(16, "InputValue"));
            //GlobalDefinitions.driver.SwitchTo().ActiveElement().SendKeys(@"C:\Users\admin\Desktop\IndustryConnect\Task\api.png");
            //iconWorkSample.SendKeys;
           // SendKeys.SendWait(@"C:\Users\admin\Desktop\IndustryConnect\Task\api.png" + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);
            //SendKeys.SendWait(@"{Enter}");
            //addWorkSample();
           // Thread.Sleep(1000);
            btnSave.Click();
            Thread.Sleep(1000);

        }

        public void Category()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string category = CommonMethods.ExcelLib.ReadData(4, "InputValue");
            var listCategory = ddbCategory.FindElements(By.TagName("option"));
            foreach (var pickCategory in listCategory)
            {
                if (pickCategory.Text.Equals("" + category))
                {
                    pickCategory.Click();
                    Thread.Sleep(1000);
                    subCategory();
                    break;
                }
            }
        }
        public void subCategory()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string subcate = CommonMethods.ExcelLib.ReadData(5, "InputValue");

            List<IWebElement> listSubCate = new List<IWebElement>(ddbSubCategory.FindElements(By.TagName("option")));
            for (int i = 1; i <= listSubCate.Count; i++)
            {
                if (listSubCate.ElementAt(i).Text.Equals(subcate))
                {
                    listSubCate.ElementAt(i).Click();
                    break;
                }
            }
        }
        public void rdServiceType()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string locType = CommonMethods.ExcelLib.ReadData(7, "InputValue");
            List<IWebElement> listrd = new List<IWebElement>(serviceType.FindElements(By.TagName("input")));
            List<IWebElement> listtxt = new List<IWebElement>(serviceType.FindElements(By.TagName("label")));
            int i = 0;
            do
            {
                if (listtxt.ElementAt(i).Text.Equals(locType))
                {
                    listrd.ElementAt(i).Click();
                }
                i = i + 1;
            } while (i < listtxt.Count());

        }
        public void rdLocationType()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string lType = ExcelLib.ReadData(8, "InputValue");
            List<IWebElement> listrd = new List<IWebElement>(locationType.FindElements(By.TagName("input")));
            List<IWebElement> listtxt = new List<IWebElement>(locationType.FindElements(By.TagName("label")));

            for (int i = 0; i <= listtxt.Count; i++)
            {
                if (listtxt.ElementAt(i).Text.Equals(lType))
                {
                    listrd.ElementAt(i).Click();
                    break;
                }
            }
        }
        public void cchbAvailableDay()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string aDay = CommonMethods.ExcelLib.ReadData(11, "InputValue");
            List<IWebElement> listchb = new List<IWebElement>(chbAvailableDay.FindElements(By.Name("Available")));
            List<IWebElement> listtxt = new List<IWebElement>(chbAvailableDay.FindElements(By.TagName("label")));

            for (int i = 0; i <= listchb.Count; i++)
            {
                string ttest = listtxt.ElementAt(i + 2).Text;
                if (listtxt.ElementAt(i + 2).Text.Equals(aDay))
                {
                    listchb.ElementAt(i).Click();
                    break;
                }
            }
        }
        public void rrdSkillTrade()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string lSkillTrade = CommonMethods.ExcelLib.ReadData(14, "InputValue");
            List<IWebElement> listrd = new List<IWebElement>(rdSkillTrade.FindElements(By.TagName("input")));
            List<IWebElement> listtxt = new List<IWebElement>(rdSkillTrade.FindElements(By.TagName("label")));
            for (int i = 0; i <= listtxt.Count; i++)
            {
                if (listtxt.ElementAt(i).Text.Equals(lSkillTrade))
                {
                    listrd.ElementAt(i).Click();
                    break;
                }
            }
        }
        public void addWorkSample()
        {
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            AutoItX3 autoIt = new AutoItX3();

            //Wait for the file upload box
            autoIt.WinActivate("File Upload");
            Thread.Sleep(500);

            //Enter the path for the file
            autoIt.Send(@ExcelLib.ReadData(16, "InputValue"));
            Thread.Sleep(2000);
            //It's the function to press the enter key on the keyboard
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);
        }
        public void rrdActive()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string lActive = ExcelLib.ReadData(17, "InputValue");
            List<IWebElement> listrd = new List<IWebElement>(rdActive.FindElements(By.TagName("input")));
            List<IWebElement> listtxt = new List<IWebElement>(rdActive.FindElements(By.TagName("label")));
            int i = 0;
            do
            {
                if (listtxt.ElementAt(i).Text.Equals(lActive))
                {
                    listrd.ElementAt(i).Click();
                }
                i = i + 1;
            } while (i < listtxt.Count());
        }
        public void validationShareSkill()
        {
            try
            {
                string expectedWorkSample = ExcelLib.ReadData(16, "ExpectedValue");
                string expectedSubCategory = ExcelLib.ReadData(4, "InputValue");
                string expectedTitle = ExcelLib.ReadData(2, "InputValue");
                string expectedDescription = ExcelLib.ReadData(3, "InputValue");
                string expectedServiceType = ExcelLib.ReadData(7, "ExpectedValue");
                string expectedSkillTrade = ExcelLib.ReadData(14, "ExpectedValue");
                Thread.Sleep(2000);
                WebDriverWait wait = new WebDriverWait(GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
                List<IWebElement> listShareSkill = new List<IWebElement>((wait.Until(ExpectedConditions.ElementToBeClickable(listingsBody))).FindElements(By.TagName("tr")));
                if (listShareSkill.Count > 1)
                {
                    Thread.Sleep(2000);
                    List<IWebElement> actualList = new List<IWebElement>(myList.FindElements(By.TagName("td")));
                    var actualWorkSample = myList.FindElement(By.TagName("img"));
                    string imgSrc = actualWorkSample.GetAttribute("src");
                    Thread.Sleep(500);
                    string actualSubCategory = actualList.ElementAt(1).Text;
                    string actualTitle = actualList.ElementAt(2).Text;
                    string actualDescription = actualList.ElementAt(3).Text;
                    string actualServiceType = actualList.ElementAt(4).Text;
                    string actualSkillTrade = actualList.ElementAt(5).Text;

                    if (imgSrc.Contains(expectedWorkSample) && actualSubCategory.Equals(expectedSubCategory)
                        && actualTitle.Equals(expectedTitle) && actualDescription.Equals(expectedDescription)
                        && actualServiceType.Equals(expectedServiceType) && actualSkillTrade.Equals(expectedSkillTrade))
                    {
                        Console.WriteLine("Test passed, ShareSkill is added successfull");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Test failed, Add Share Skill is Unsuccessful", e.Message);
            }
        }

        public void displayingMessages()
        {
            try
            {
                btnShareSkill.Click();
                Thread.Sleep(1000);
                var array = new IWebElement[10];
                array[0] = txtTitle;
                array[1] = txtDescription;
                array[2] = ddbCategory;
                array[3] = txtTags;
                array[4] = serviceType;
                array[5] = locationType;
                array[6] = chbAvailableDay;
                array[7] = rdSkillTrade;
                array[8] = iconWorkSample;
                array[9] = rdActive;
                var msgsArray = new IWebElement[10];
                msgsArray[0] = titleMessage;
                msgsArray[1] = descriptionMessage;
                msgsArray[2] = categoryMessage;
                msgsArray[3] = tagMessage;
                msgsArray[4] = sTypeMessage;
                msgsArray[5] = lTypeMessage;
                msgsArray[6] = aDayMessage;
                msgsArray[7] = sTradeMessage;
                msgsArray[8] = wSampleMessage;
                msgsArray[9] = activeMessage;
                int index = 0; ;
                IDictionary<string, string> openWith = new Dictionary<string, string>();
                openWith.Add("expectedTitleM", "Write a title to describe the service you provide.");
                openWith.Add("expectedDescriptionM", "Write a description to describe the service you provide.");
                openWith.Add("expectedCategoryM", "Choose a category that fits your services.");
                openWith.Add("expectedTagM", "Choose tags that fit your services. Press Enter key to add each tag.");
                openWith.Add("excpectedSTypeM", "Please select between an hourly basis service or a One-off service");
                openWith.Add("expectedLTypeM", "Choose to offer your services either On-site or Online");
                openWith.Add("expectedADayM", "Please select your available start and end dates. Please also specify start and end times.");
                openWith.Add("expectedSTradeM", "Choose between skill-exchange or credits");
                openWith.Add("expectedWorkSampleM", "Upload samples of your work here");
                openWith.Add("expectedActiveM", "Enable or disable your services.");

                foreach (KeyValuePair<string, string> item in openWith)
                {

                    Actions ac = new Actions(GlobalDefinitions.driver);
                    ac.MoveToElement(array[index]).Perform();
                    string actualTitleM = msgsArray[index].Text;
                    if (item.Value.Equals(actualTitleM))
                    {
                        Console.WriteLine("The message is displayed succefully: " + actualTitleM);
                    }
                    index++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Test failed, Checking messages for each fields is Unsuccessful", e.Message);
            }
        }
    }
}
