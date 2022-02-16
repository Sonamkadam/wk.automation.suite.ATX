
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using SFS_ATX.PagesObjects;
using System.Threading;

namespace SFS_ATX
{
    public class LoginPage
    {
        IWebDriver Driver;

      
        //Constructors 
        public  LoginPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver, this);

        }
        //Identifiers
        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement Loginlink { get; set; }

        [FindsBy(How=How.Id,Using="ctl00_MainContentPlaceHolder_LoginId")]
        public IWebElement ClientId { get; set; }

       [FindsBy(How=How.Id,Using = "ctl00_MainContentPlaceHolder_LoginUserName")]
        public IWebElement Username { get; set; }

       [FindsBy(How=How.Id,Using = "LoginPassword")]
        public IWebElement Password { get; set; }
        [FindsBy(How=How.Id,Using = "ctl00_MainContentPlaceHolder_LoginButton")]
        public IWebElement LoginButton  { get; set; }
        
        [FindsBy(How = How.LinkText, Using = "I understand")]
        public IWebElement Understand { get; set; }
        //Methods
        public void ClientLoginPage(string cntId,string Uname, string Pword)
        {
            Loginlink.Click();
            //string cntId1 =cntId;
            ClientId.SendKeys(cntId);
            Username.SendKeys(Uname);
            Password.SendKeys(Pword);
            Understand.Click();
            Thread.Sleep(4000);
            LoginButton.Click();
           // return new HomeIndexPage(Driver);

        }







    }
}