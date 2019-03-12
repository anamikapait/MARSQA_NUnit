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
    class ManageListings
    {

        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Find Manage Listings button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
        private IWebElement ManageListingsbutton { get; set; }

        //Find the Eye icon button

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[contains(@class, 'eye icon')]")]
        private IWebElement EyeIconButton { get; set; }

        //Find Service Detail Page
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']")]
        private IWebElement ServiceDetailPage { get; set; }

        //Find Delete button
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[contains(@class, 'remove icon')]")]
        private IWebElement DeleteButton { get; set; }

        //Find Delete confirm button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement DeleteConfirmButton { get; set; }

        
        internal void ManageListingsViewDetailsSteps()
        {
            //Click on Manage Listings button
            ManageListingsbutton.Click();
            Thread.Sleep(1500);
            //Click on the Eye icon button
            EyeIconButton.Click();
            Thread.Sleep(1500);
            
            //Verify
            if (ServiceDetailPage != null)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "View Details Successful");
            }
            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "View Details Unsuccessful");

        }

        internal void ManageListingsDeleteListingSteps()
        {
            //Click on Manage Listings button
            ManageListingsbutton.Click();
            Thread.Sleep(1500);
            //Click on the Delete icon button
            DeleteButton.Click();
            //Confirm delete
            DeleteConfirmButton.Click();
            Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete Successful");
        }

    }
}
