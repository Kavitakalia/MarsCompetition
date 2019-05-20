using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    public class ManageListing
    {
        public ManageListing()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }

        #region Initialize WebElements on Manage Listings
        //Finding Manage Listings
        [FindsBy(How = How.XPath, Using = "//a[text()='Manage Listings']")]
        private IWebElement ManageListings { get; set; }

        //Finding Eye Icon(View)
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])")]
        private IWebElement View { get; set; }

        //Finding Edit
        [FindsBy(How = How.XPath, Using = "(//i[contains(@class,'write')])")]
        private IWebElement Edit { get; set; }

        //Finding Manage Listings
        [FindsBy(How = How.XPath, Using = "//table[@class='ui striped table']")]
        private IWebElement Delete { get; set; }

        //Finding Alert for Deleting the Listing
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement Alert { get; set; }


        #endregion

        #region Manage Listings

        internal void Listings()

        {
            Thread.Sleep(1000);
            ManageListings.Click();

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Manage Listings");
            Thread.Sleep(1000);

            ////View the Listings
            Actions action = new Actions(GlobalDefinitions.driver);
            //action.MoveToElement(View).Build().Perform();
            //View.Click();
            //Thread.Sleep(1000);

            ////Edit the Listings
            //GlobalDefinitions.driver.Navigate().Back();
            //Thread.Sleep(1000);
            //Edit.Click();
            //ShareSkills editSkillObj = new ShareSkills();
            //editSkillObj.EditSkill();
            //Thread.Sleep(1000);

            //Click on Delete the Listings
          
           //action.MoveToElement(Delete).Build().Perform();
            Thread.Sleep(2000);
            IList<IWebElement> deleteIcon = Delete.FindElements(By.XPath("(//i[contains(@class,'remove')])"));
            int listCount = deleteIcon.Count();
            Console.WriteLine("Count of the Listing  :" + listCount);
            for (int i = 0; i < listCount; i++)
            {
                var j = i + 1;
                var Title = GlobalDefinitions.driver.FindElement(By.XPath("//tr[" + j + "]/td[3]")).Text;
                if (Title.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Title"))) 
                {

                    deleteIcon.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Listing has been Deleted");
                    Thread.Sleep(1000);
                    break;
                }
            }

            //Alert for Deleting the Listing
            action.MoveToElement(Alert).Build().Perform();
            Thread.Sleep(3000);
            IList<IWebElement> AlertButton = Alert.FindElements(By.TagName("button"));
            //Indicating the number of buttons present
            int AlertCount = AlertButton.Count;
            Console.WriteLine("Number of Actions for Deleting : " + AlertCount);
            for (int i = 1; i <= AlertCount; i++)
            {
                if (AlertButton[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Action"))
                {
                    AlertButton[i].Click();
                    Base.test.Log(LogStatus.Info, "Listing has been deleted");
                    Thread.Sleep(500);
                    break;
                }
            }
        }
        #endregion
    }
}

