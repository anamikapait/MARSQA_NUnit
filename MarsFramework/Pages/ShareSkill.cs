using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    class ShareSkill
    {

        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Find Share Skill button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        private IWebElement ShareSkillButton { get; set; }

        //Find Title text box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }

        //Find Description box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Find A Category
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]")]
        private IWebElement Category { get; set; }

        //Find A SubCategory
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[2]")]
        private IWebElement SubCategory { get; set; }

        //Find Tags
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement Tags { get; set; }

        //Find Hourly Service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyServiceType { get; set; }

        //Find One Off Service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneOffServiceType { get; set; }

        //Find Onsite Location type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement OnsiteLocationType { get; set; }

        //Find Online Location type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement OnlineLocationType { get; set; }

        //Find Available Start date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        private IWebElement AvailableStartDate { get; set; }

        //Find Available End date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        private IWebElement AvailableEndDate { get; set; }

        //Find Sunday Checkbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        private IWebElement SundayCheckbox { get; set; }

        //Find Sunday starttime
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        private IWebElement SundayStartTime { get; set; }

        //Find Sunday endtime
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        private IWebElement SundayEndTime { get; set; }

        //Find Skill Exchange Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchangeType { get; set; }

        //Find Credits Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement CreditsType { get; set; }

        //Find Skill Exchange Tag
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }

        //Find Active Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveButton { get; set; }

        //Find Hidden Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenButton { get; set; }

        //Find Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement SaveButton { get; set; }

        //Find Cancel Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[2]")]
        private IWebElement CancelButton { get; set; }

        internal void ShareSkillSteps()
        {
            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "ShareSkill");
            
            //Click on Title text box
            ShareSkillButton.Click();
            Thread.Sleep(1500);
            Title.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Click on Description
            Description.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Select A Category
            Category.Click();

            //Select Sub Category
            SubCategory.Click();

            //Add Tags
            Tags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Tag"));
            Tags.SendKeys(Keys.Enter);
           
            //Select Service type
            OneOffServiceType.Click();

            //Select Location type
            OnlineLocationType.Click();

            //Select Available Start date
            AvailableStartDate.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AvailableStartDate"));

            //Select Available End date
            AvailableEndDate.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AvailableEndDate"));

            //Click on Sunday checkbox
            SundayCheckbox.Click();

            //Select Sunday Start time
            SundayStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "SundayStartTime"));

            //Select Sunday End time
            SundayEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "SundayEndTime"));

            //Select Skill Exchange Type
            SkillExchangeType.Click();

            //Add Skill Exchange Tag
            SkillExchangeTag.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchangeTab"));
            SkillExchangeTag.SendKeys(Keys.Enter);

            //Select Active Button
            ActiveButton.Click();

            //Click on Save Button
            SaveButton.Click();

        }


    }
}
