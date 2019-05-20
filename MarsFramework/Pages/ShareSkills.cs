
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MarsFramework.Pages
{
    internal class ShareSkills
    {
        public ShareSkills()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialise the WebElements Of Profile Page

        //********Profile Page**********
        //Click Description
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement ProfileDescription { get; set; }

        //Finding the textarea of Description
        [FindsBy(How = How.XPath,Using ="//textarea[@name='value']")]
        private IWebElement DescriptionData { get; set; }

        [FindsBy(How = How.XPath, Using ="(//button[text()='Save'])[2]")]
        private IWebElement SaveDescription { get; set; }


        //Click Title
        [FindsBy(How = How.XPath, Using = "(//i[@class='dropdown icon'])[2]")]
        private IWebElement ProfileTitle { get; set; }

        //Find First Name
        [FindsBy(How = How.XPath, Using = "//input[@name='firstName']")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='lastName']")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement ProfileSave { get; set; }

        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[1]")]
        private IWebElement Availabilty { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")]
        private IWebElement AvailabiltyType { get; set; }

        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[2]")]
        private IWebElement Hours { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")]
        private IWebElement AvailabilityHour { get; set; }

        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[3]")]
        private IWebElement EarnTarget { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement AvailabiltyTarget { get; set; }
        #endregion

        #region Initialize the Web Elements of Share Skill Page
        //*******SHARE SKILL PAGE***********
        //Click Share Skill
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement Skill { get; set; }

        //Finding Title
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }

        //Finding Description
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }

        //Clicking Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category { get; set; }

        //Clicking Category Option
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']/option[@value]")]
        private IList<IWebElement> CategoryOpt { get; set; }

        //Clicking SubCategory
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategory { get; set; }

        //Finding Tags
        [FindsBy(How = How.XPath, Using = "(//input[@class='ReactTags__tagInputField'])[1]")]
        private IWebElement Tags { get; set; }

        //Finding Service Type
        //[FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        [FindsBy(How = How.XPath, Using = "(//div[@class='twelve wide column'])[4]")]
        private IWebElement ServiceType { get; set; }

        //Finding Location
        [FindsBy(How = How.XPath, Using = "(//div[@class='inline fields'])[2]")]
        private IWebElement Location { get; set; }

        //Finding Availability Start date
        [FindsBy(How = How.XPath, Using = "//input[@name='startDate']")]
        private IWebElement StartDate { get; set; }

        //Finding Availability End date
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")]
        private IWebElement EndDate { get; set; }

        //Finding Available Day
        [FindsBy(How = How.XPath, Using = "(//div[@class='form-wrapper'])[1]")]
        private IWebElement AvailableDay { get; set; }

        //Finding Skill Trade
        [FindsBy(How = How.XPath, Using = "(//div[@class='inline fields'])[3]")]
        private IWebElement SkillTrade { get; set; }

        //Finding Skill- Exchange(Skill Trade)
        [FindsBy(How = How.XPath, Using = "(//input[@class='ReactTags__tagInputField'])[2]")]
        private IWebElement SkillExchangeTag { get; set; }

        //Finding Credit(Skill Trade)
        [FindsBy(How = How.XPath,Using = "//div/input[@name='charge']")]
        private IWebElement Credit { get; set; }

        //Finding Work Sample
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorkSample { get; set; }
        
        //Finding Active
        [FindsBy(How = How.XPath, Using = "(//div[@class='inline fields'])[4]")]
        private IWebElement Active { get; set; }

        //Finding Save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }


      
        #region Editing ShareSkill Page

        internal void EditSkill()

        {
            #region Profile Page

            // //Click on the title
            // Thread.Sleep(1000);
            // ProfileDescription.Click();
            // //Thread.Sleep(500);
            // DescriptionData.Click();
            // GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            // DescriptionData.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            // SaveDescription.Click();


            // //Edit Profile Name
            // ProfileTitle.Click();

            // //Entering First Name
            // //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            // //First Name
            // FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "First Name"));
            // //Last Name
            // LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Last Name"));
            // //Save
            // ProfileSave.Click();

            // //Availability 
            // Actions action = new Actions(GlobalDefinitions.driver);
            // //action.MoveToElement(Availabilty).Build().Perform();
            // Thread.Sleep(500);
            // Availabilty.Click();

            // Thread.Sleep(500);
            //// action.MoveToElement(AvailabiltyType).Build().Perform();
            // AvailabiltyType.Click();  
            #endregion

            #region Share Skill Page

            //// ******Share Skill Page******
            //Click on Edit button
            Thread.Sleep(1000);
            Skill.Click();

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");
            Thread.Sleep(1000);

            //Enter Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Base.test.Log(LogStatus.Info, "Title has been added");

            // Enter Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            // Choose Category
            Thread.Sleep(2000);
            Actions action = new Actions(GlobalDefinitions.driver);
            action.MoveToElement(Category).Build().Perform();
            Thread.Sleep(200);
            IList<IWebElement> category = Category.FindElements(By.TagName("option"));
            int count = category.Count();
            for (int i = 0; i < count; i++)
            {
                if (category[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Category"))
                {
                    category[i].Click();
                    Base.test.Log(LogStatus.Info, "Category is added");
                    Console.WriteLine("Count of the category:" + count);
                }
            }

            //Selecting Subcategory
            Thread.Sleep(500);
            action.MoveToElement(SubCategory).Build().Perform();
            IList<IWebElement> subcategory = SubCategory.FindElements(By.TagName("option"));
            int subcount = subcategory.Count();
            for (int i = 0; i < subcount; i++)
            {
                if (subcategory[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Sub Category"))
                {
                    subcategory[i].Click();
                    Base.test.Log(LogStatus.Info, "Sub Category is added");
                    Console.WriteLine("Subcategory count" + subcount);
                }
            }
            
            // Enter Tags
            Tags.SendKeys("Testing");
            Tags.SendKeys(Keys.Enter);

            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            //Service type
            action.MoveToElement(ServiceType).Build().Perform();
            //Storing the elements in a List
            IList<IWebElement> serviceRadio = ServiceType.FindElements(By.XPath("//div/div/div/input[@name='serviceType']"));
            int service = serviceRadio.Count();
            Console.WriteLine("Service Type: " + service);
            for (int i = 0; i < service; i++)
            {
                int j = i + 1;
                var serviceLabel = ServiceType.FindElement(By.XPath("(//div[@class='twelve wide column'])[4]/div/div[" + j + "]/div/label[contains(text(),'service')]")).Text;

                if (serviceLabel.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Service Type")))
                {
                    serviceRadio.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Service Type is selected");
                    Thread.Sleep(1000);
                }
            }

           // Location
            action.MoveToElement(Location).Build().Perform();
            IList<IWebElement> locationRadio = Location.FindElements(By.XPath("//div/div/input[contains(@name,'loc')]"));
            int loc = locationRadio.Count();
            Console.WriteLine("Location: " + loc);
            for (int i = 1; i < loc; i++)
            {
                int j = i;
                var locationLabel = Location.FindElement(By.XPath("(//div[@class='inline fields'])[2]/div[" + j + "]/div/label[contains(text(),'On')]")).Text;
                if (locationLabel.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Location")))
                {
                    locationRadio.ElementAt(i).Click();
                    Thread.Sleep(1500);
                }
            }
            
            //Enter Start Date
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start Date"));

            //Enter End Date
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End Date"));
            Thread.Sleep(1000);

            //Selecting Day
            action.MoveToElement(AvailableDay).Build().Perform();
            IList<IWebElement> dayCheckBox = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='Available']"));
            int dayRadio = dayCheckBox.Count();
            Console.WriteLine("Available Days: " + dayRadio);
            for (int i = 0; i < dayRadio; i++)
            {
                int j = i + 2;
                var dayLabel = AvailableDay.FindElement(By.XPath("//div[" + j + "]/div/div/label")).Text;
                if (dayLabel.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Day")))
                {
                    dayCheckBox.ElementAt(i).Click();
                    Thread.Sleep(1500);
                    Base.test.Log(LogStatus.Info, "Day has been Selected");
                }
            }

            //Start Time
            IList<IWebElement> startTime = AvailableDay.FindElements(By.XPath("//input[@name='StartTime']"));
            IList<IWebElement> endTime = AvailableDay.FindElements(By.XPath("//input[@name='EndTime']"));
            int startTimeCount = startTime.Count();
            int endTimeCount = endTime.Count();

            Console.WriteLine("Start time Count: " + startTimeCount);
            Console.WriteLine("End Time Count" + endTimeCount);
            for (int i = 0; i < startTimeCount; i++)
            {
                int j = i + 2;
                var dayLabel = AvailableDay.FindElement(By.XPath("//div[" + j + "]/div/div/label")).Text;
                if (dayLabel.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Day")))
                {
                    startTime.ElementAt(i).SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start Time"));
                    endTime.ElementAt(i).SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End Time"));
                    Thread.Sleep(1500);
                    Base.test.Log(LogStatus.Info, "Start Time has been Selected");
                }
            }

            //Skill Trade
            action.MoveToElement(SkillTrade).Build().Perform();
            IList<IWebElement> skillRadio = SkillTrade.FindElements(By.XPath("//div/div/input[@name='skillTrades']"));
            int skill = skillRadio.Count();
            Console.WriteLine("Skill Trade: " + skill);
            for (int i = 0; i < skill; i++)
            {
                int j = i + 1;

                var skillLabel = SkillTrade.FindElement(By.XPath("(//div[@class='inline fields'])[3]//div[" + j + "]/div/label")).Text;
                if (skillLabel.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade")))
                {
                    skillRadio.ElementAt(i).Click();
                }
            }

            //Credit Amount
            Thread.Sleep(1000);
            Credit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));

            ////Skill Exchange Tag
            //Thread.Sleep(1500);
            ////action.MoveToElement(SkillExchangeTag).Build().Perform();
            //SkillExchangeTag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill Exchange"));
            //SkillExchangeTag.SendKeys(Keys.Enter);

            // Upload Work Sample using Reference Windows.Forms
            action.MoveToElement(WorkSample).Build().Perform();
            //@"C:\Users\Kavita Kalia\Desktop\Work Sample.jpg"
            string sample = GlobalDefinitions.ExcelLib.ReadData(2, "Work Sample");
            WorkSample.Click();
            Thread.Sleep(2000);
            System.Windows.Forms.SendKeys.SendWait(sample);
            System.Windows.Forms.SendKeys.SendWait(@"{Enter}");
            Base.test.Log(LogStatus.Info, "Image has been added");

            //Active
            Thread.Sleep(3000);
            //action.MoveToElement(Active).Build().Perform();
            IList<IWebElement> activeRadio = Active.FindElements(By.XPath("//div/div/input[@name='isActive']"));
            int active = activeRadio.Count();
            Console.WriteLine(" Active:  " + active);
            for (int i = 0; i < active; i++)
            {
                int j = i + 1;
                var activeLabel = Active.FindElement(By.XPath("(//div[@class='inline fields'])[4]//div[" + j + "]/div/label")).Text;
                if (activeLabel.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Active")))
                {
                    activeRadio.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Status is Active");
                }
            }
            Thread.Sleep(1000);
            Save.Click();
            Thread.Sleep(2500);
            Base.test.Log(LogStatus.Info, " Service Listing has been Added");            
            #endregion
        }
    }
    #endregion
}
#endregion