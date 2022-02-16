using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SFS_ATX;
using SFS_ATX.PagesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SFS_SmokeTest.TestScripts.SessionTimeout
{
    [TestCategory("PooledSessionTimeOut")]
    [TestClass]
    public class P1_TC_Enviornment
    {
        [DataTestMethod]
        [CsvDataSource("SFS_SmokeTest/TestData/Login.csv")]
        public void P1_TC_EnviornmentPage(string cid, string userName, string passWord)
        {

            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(4000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            driver.Url = "https://wdc-qa-support.taxwise.com/";
            HomeIndexPage HIP = new HomeIndexPage(driver);
            //HIP.SafeLink();
            // driver.Url = "https://ppd1-support.taxwise.com/";
            Thread.Sleep(4000);
            LoginPage Lp = new LoginPage(driver);
            Thread.Sleep(4000);
            Lp.ClientLoginPage(cid, userName, passWord);
            Thread.Sleep(4000);


            HIP.EnviornmentLink();

        }
    }
}

