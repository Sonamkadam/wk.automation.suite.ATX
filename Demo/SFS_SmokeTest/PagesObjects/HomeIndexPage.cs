using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace SFS_ATX.PagesObjects
{
    public class HomeIndexPage
    {
        IWebDriver Driver;


        public HomeIndexPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeMenu { get; set; }


        [FindsBy(How = How.LinkText, Using = "Downloads")]
        public IWebElement DownloadsMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='navbarSupportedContent']/ul/li[4]/div/a[4]")]
        public IWebElement StateUpdates { get; set; }

        [FindsBy(How = How.LinkText, Using = " Add Individual States to Package")]
        public IWebElement AddIndividualStates { get; set; }


        [FindsBy(How = How.LinkText, Using = "My Information")]
        public IWebElement MyInfo { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Product Information")]
        public IWebElement ProductInfo { get; set; }

        [FindsBy(How = How.Id, Using = "details-button")]
        public IWebElement Advancebtn { get; set; }

        [FindsBy(How = How.LinkText, Using = "Proceed to qa1-support.taxwise.com (unsafe)")]
        public IWebElement unsafelnk { get; set; }


        public void HomeMenulink()
        {
            HomeMenu.Click();
            //return new HomePage(Driver);
        }


        public void DownloadsLink()
        {
            DownloadsMenu.Click();
            Thread.Sleep(3000);
            StateUpdates.Click();
            Thread.Sleep(6000);
            AddIndividualStates.Click();
        }

        public void SafeLink()
        {
            Advancebtn.Clear();
            Thread.Sleep(3000);
            unsafelnk.Clear();
            Thread.Sleep(3000);
        }

        public void MyProductsLink()
        {

            Driver.Url = "https://wdc-qa-support.taxwise.com/myinformation/MyProducts";
            //Driver.Url = "https://ppd1-support.taxwise.com/myinformation/MyProducts";
            //MyInfo.Click();
            //Thread.Sleep(3000);
            //ProductInfo.Click();

        }

        public void CASLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/download/ClientAccountingSuite";
        }

        public void PaperlessPlusLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/download/PaperlessPlus";
        }

        public void EnviornmentLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/myinformation/environment";
        }

        public void ReturnRetrievalLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/support/ReturnRetrieval";
        }
        public void StateUpdatesLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/download/TWStateUpdates";
        }
        public void BankUpdatesLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/download/TWBankUpdates";
        }

        public void TWSoftwareLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/download/TWSoftwareDownload";
        }

        public void SubmitEfinLink()
        {
            Driver.Url = "https://wdc-qa-support.taxwise.com/myinformation/CurrentEFIN";
        }





    }
}
