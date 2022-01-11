using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SFS_ATX.PagesObjects;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Threading;


namespace SFS_ATX.BaseClass
{
    [TestClass]
    public class BaseTest 
    {
        public static IWebDriver driver;
        public static ExtentReports extent = new ExtentReports();
        public static ExtentTest test;
        
       //[ClassInitialize]
        public  void ExtentStart()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Automation Framework\new prog\ATX\wk.automation.suite.ATX\ClassLibrary1\SFS_SmokeTest\Extent Reports\result.html");
            htmlReporter.Config.Theme = Theme.Dark;
            extent.AttachReporter(htmlReporter);
            
        }
        [TestInitialize]
        public void Setup()
        {
            //for(i)
               
            ExtentStart();
            test = extent.CreateTest("TC_001 Execution").Info("Login Testcase");
            Console.Write("Setup");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            test.Log(Status.Info, "Launched browser");
            Thread.Sleep(3000);
            driver.Url = "https://wdc-qa-support.taxwise.com/";
            test.Log(Status.Info, "Hit WebSite");
     
            Console.Write("Setup");
            LoginPage Lp = new LoginPage(driver);
            Lp.ClientLoginPage("80006125", "sonam", "WebTeam@21");
            test.Log(Status.Info, "Successfully Login");
            test.Log(Status.Pass, "Login Passed");
            //HomeIndexPage hIp = new HomeIndexPage(driver);
            //hIp.HomeMenulink();
            test.Log(Status.Info, "Clicked on Home Link");
            //driver.Url = ConfigurationManager.AppSettings.Get("URL");
            //Console.WriteLine("URL" + url);
            //driver.Navigate()d.GoToUrl(url);
            Thread.Sleep(3000);

        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
            Console.Write("Quit");
            test.Log(Status.Info, "Closed browser");
            ExtentClose();
        }

      [ClassCleanup]
        public void ExtentClose()
        {
            extent.Flush();
            Console.WriteLine("Flush");

        }

    }   
}
