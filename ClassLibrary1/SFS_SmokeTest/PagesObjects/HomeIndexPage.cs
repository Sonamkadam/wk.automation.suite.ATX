using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

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


        public void HomeMenulink()
        {
            HomeMenu.Click();
            //return new HomePage(Driver);
        }
    }
}
