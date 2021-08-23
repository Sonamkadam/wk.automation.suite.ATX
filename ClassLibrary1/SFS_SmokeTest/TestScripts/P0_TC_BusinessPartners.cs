using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFS_ATX;
using SFS_ATX.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATX_lib.SFS_SmokeTest.TestScripts
{
    [TestClass]
    public class P0_TC_BusinessPartners : BaseTest
    {

		[TestMethod]
		public void NATP_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_030 Execution").Info("Validation Started for NATP URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.NATP();
				test.Log(Status.Info, "Clicked on NATP icon");
				List<String> listOfWindow = driver.WindowHandles.ToList();
				String ChildWindowHandle = "";
				foreach (var Handle in listOfWindow)
				{
					Console.WriteLine("New Window " + Handle);
					driver.SwitchTo().Window(Handle);
					ChildWindowHandle = Handle;
				}
				driver.SwitchTo().Window(parentWindowHandle);
				driver.Close();
				driver.SwitchTo().Window(ChildWindowHandle);
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://www.wolterskluwer.com/en/solutions/tax-accounting-us/partner-solutions-for-tax-offices";
				StringAssert.Contains(actualurl, expectedurl);
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				Thread.Sleep(3000);
				throw;

			}
		}

		[TestMethod]
		public void iTransact_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_031 Execution").Info("Validation Started for iTransact URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.iTransact();
				test.Log(Status.Info, "Clicked on iTransact icon");
				List<String> listOfWindow = driver.WindowHandles.ToList();
				String ChildWindowHandle = "";
				foreach (var Handle in listOfWindow)
				{
					Console.WriteLine("New Window " + Handle);
					driver.SwitchTo().Window(Handle);
					ChildWindowHandle = Handle;
				}
				driver.SwitchTo().Window(parentWindowHandle);
				driver.Close();
				driver.SwitchTo().Window(ChildWindowHandle);
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://www.wolterskluwer.com/en/solutions/tax-accounting-us/partner-solutions-for-tax-offices";
				StringAssert.Contains(actualurl, expectedurl);
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				Thread.Sleep(3000);
				throw;

			}
		}

		[TestMethod]
		public void Protection_Plus_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_032 Execution").Info("Validation Started for Protection Plus URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.ProtectionPlus();
				test.Log(Status.Info, "Clicked on Protection Plus icon");
				List<String> listOfWindow = driver.WindowHandles.ToList();
				String ChildWindowHandle = "";
				foreach (var Handle in listOfWindow)
				{
					Console.WriteLine("New Window " + Handle);
					driver.SwitchTo().Window(Handle);
					ChildWindowHandle = Handle;
				}
				driver.SwitchTo().Window(parentWindowHandle);
				driver.Close();
				driver.SwitchTo().Window(ChildWindowHandle);
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://taxprotectionplus.com/cch-online-enrollment";
				StringAssert.Contains(actualurl, expectedurl);
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				Thread.Sleep(3000);
				throw;

			}
		}


		[TestMethod]
		public void Banking_Partners_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_033 Execution").Info("Validation Started for Banking Partners URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.BankingPartners();
				test.Log(Status.Info, "Clicked on Banking Partners icon");
				List<String> listOfWindow = driver.WindowHandles.ToList();
				String ChildWindowHandle = "";
				foreach (var Handle in listOfWindow)
				{
					Console.WriteLine("New Window " + Handle);
					driver.SwitchTo().Window(Handle);
					ChildWindowHandle = Handle;
				}
				driver.SwitchTo().Window(parentWindowHandle);
				driver.Close();
				driver.SwitchTo().Window(ChildWindowHandle);
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://www.wolterskluwer.com/en/solutions/taxwise/taxwise-refund-transfer-solutions";
				StringAssert.Contains(actualurl, expectedurl);
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				Thread.Sleep(3000);
				throw;

			}
		}

		[TestMethod]
		public void Versicom_Communications_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_034 Execution").Info("Validation Started for Versicom Communications URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.VersicomCommunications();
				test.Log(Status.Info, "Clicked on Versicom Communications icon");
				List<String> listOfWindow = driver.WindowHandles.ToList();
				String ChildWindowHandle = "";
				foreach (var Handle in listOfWindow)
				{
					Console.WriteLine("New Window " + Handle);
					driver.SwitchTo().Window(Handle);
					ChildWindowHandle = Handle;
				}
				driver.SwitchTo().Window(parentWindowHandle);
				driver.Close();
				driver.SwitchTo().Window(ChildWindowHandle);
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://www.wolterskluwer.com/en/solutions/tax-accounting-us/partner-solutions-for-tax-offices";
				StringAssert.Contains(actualurl, expectedurl);
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				Thread.Sleep(3000);
				throw;

			}
		}


	}
}
