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

        [FindsBy(How = How.LinkText, Using = "State Updates")]
        public IWebElement StateUpdates { get; set; }

        [FindsBy(How = How.LinkText, Using = "Add Individual States to Package")]
        public IWebElement AddIndividualStates { get; set; }



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
            Thread.Sleep(3000);
            AddIndividualStates.Click();
        }
    }

}
