
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SFS_ATX
{
    public class HomePage
    {

        IWebDriver Driver;

        //Constructors 
        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }


        //Identifiers
       

        [FindsBy(How = How.Id, Using = "sfsSearchInput")]
        public IWebElement KbSearch { get; set; }


        [FindsBy(How = How.ClassName, Using = "sfsSearchButton")]
        public IWebElement ClicktKbSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "password center")]
        public IWebElement PasswordCenter { get; set; }

        [FindsBy(How = How.LinkText, Using = "Search")]
        public IWebElement Search { get; set; }

        [FindsBy(How = How.LinkText, Using = "View")]
        public IWebElement View { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ask")]
        public IWebElement Ask { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage")]
        public IWebElement Manage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Bank")]
        public IWebElement Bank{ get; set; }

        [FindsBy(How = How.LinkText, Using = "Chat")]
        public IWebElement Chat { get; set; }

        [FindsBy(How = How.LinkText, Using = "Open")]
        public IWebElement Open { get; set; }

        [FindsBy(How = How.LinkText, Using = "Click")]
        public IWebElement Click { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@title='Download Tax Preparation Products, Tax Program Updates, PCR Payroll Products, PCR Program Updates']")]
        public IWebElement ATXProgramDownload { get; set; }

        [FindsBy(How =How.LinkText, Using = "Getting Started with ATX 2020")]
        public IWebElement GettingStartedWithATX2020Link { get; set; }

        [FindsBy(How = How.LinkText, Using = "ATX Blog")]
        public IWebElement ATXBlogLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "User Guides")]
        public IWebElement UserGuidesLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Conversions")]
        public IWebElement ConversionsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "System Requirements")]
        public IWebElement SystemRequirementsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "ATX Learning Portal")]
        public IWebElement ATXLearningPortalLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "PCR Learning Portal")]
        public IWebElement PCRLearningPortalLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "E-file Availability")]
        public IWebElement EfileAvailabilityLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "E-File Status")]
        public IWebElement EFileStatusLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "ATX Forms Schedule")]
        public IWebElement ATXFormsScheduleLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Calendars and Charts")]
        public IWebElement CalendarsandChartsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "ATX Product Schedule")]
        public IWebElement ATXProductScheduleLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "AnswerConnect Research")]
        public IWebElement AnswerConnectResearchLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Remote Connection Utility")]
        public IWebElement RemoteConnectionUtilityLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "GDPR (EU tax preparers, tax payers or data subjects)")]
        public IWebElement GDPRLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "NATP")]
        public IWebElement NATPLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "iTransact")]
        public IWebElement iTransactLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Protection Plus")]
        public IWebElement ProtectionPlusLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Banking Partners")]
        public IWebElement BankingPartnersLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Versicom Communications")]
        public IWebElement VersicomCommunicationsLink { get; set; }
        /// <summary>
        /// Methods for functioning on the elements.
        /// </summary>

        public void KbSearchTextBox(String value)
        {
            KbSearch.SendKeys(value);
            Thread.Sleep(5000);
            ClicktKbSearch.Click();

        }

        public void PasswordCenterLink()
        {
            PasswordCenter.Click();
        }

        public void SearchLink()
        {
            Search.Click();
        }
        public void ViewLink()
        {
            View.Click();
        }

        public void AskLink()
        {
            Ask.Click();
        }

        public void ManageLink()
        {
            Manage.Click();

        }

        public void BankLink()
        {
            Bank.Click();
        }

        public void ChatLink()
        {
            Chat.Click();
        }

        public void OpenLink()
        {
            Open.Click();
        }

        public void ClickLink()
        {
            Click.Click();
        }

        public void ATXProgramDownloadsLink()
        {
            ATXProgramDownload.Click();
        }

        public void GettingStartedWithATX2020()
        {
            GettingStartedWithATX2020Link.Click();
        }
        public void ATXBlog()
        {
            ATXBlogLink.Click();
        }

        public void UserGuides()
        {
            UserGuidesLink.Click();
        }

        public void Conversions()
        {
            ConversionsLink.Click();
        }

        public void SystemRequirements()
        {
            SystemRequirementsLink.Click();
        }

        public void ATXLearningPortal()
        {
            ATXLearningPortalLink.Click();
        }

        public void PCRLearningPortal()
        {
            PCRLearningPortalLink.Click();
        }

        public void EfileAvailability()
        {
            EfileAvailabilityLink.Click();            
        }

        public void EFileStatus()
        {
            EFileStatusLink.Click();
        }

        public void ATXFormsSchedule()
        {
            ATXFormsScheduleLink.Click();
        }

        public void CalendarsandCharts()
        {
            CalendarsandChartsLink.Click();
        }

        public void ATXProductSchedule()
        {
            ATXProductScheduleLink.Click();
        }

        public void AnswerConnectResearch()
        {
            AnswerConnectResearchLink.Click();
        }

        public void RemoteConnectionUtility()
        {
            RemoteConnectionUtilityLink.Click();
        }

        public void GDPR()
        {
            GDPRLink.Click();
        }

        public void NATP()
        {
            NATPLink.Click();
        }

        public void iTransact()
        {
            iTransactLink.Click();
        }

        public void ProtectionPlus()
        {
            ProtectionPlusLink.Click();
        }

        public void BankingPartners()
        {
            BankingPartnersLink.Click();
        }

        public void VersicomCommunications()
        {
            VersicomCommunicationsLink.Click();
        }
    }
}
