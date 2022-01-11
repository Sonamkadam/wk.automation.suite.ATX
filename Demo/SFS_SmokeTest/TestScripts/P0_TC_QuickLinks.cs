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

namespace SFS_ATX.TestScripts
{
    [TestClass]
   public class P0_TC_QuickLinks : BaseTest
    {

		[TestMethod]
		public void Efile_Availability_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_022 Execution").Info("Validation Started for E-file Availability URL");
				HomePage hp = new HomePage(driver);
				hp.EfileAvailability();
				test.Log(Status.Info, "Clicked on E-file Availability Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/support/ATXJurisdictionStatus";
				Assert.AreEqual(actualurl, (expectedurl));
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				throw;

			}

		}


		[TestMethod]
		public void EFile_Status_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_023 Execution").Info("Validation Started for Efile Status URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.EFileStatus();
				test.Log(Status.Info, "Clicked on Efile Status icon");
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
				string expectedurl = "https://wdc-qa-returnquery.atxinc.com/";
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
		public void ATX_Forms_Schedule_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_024 Execution").Info("Validation Started for ATX Forms Schedule URL");
				HomePage hp = new HomePage(driver);
				hp.ATXFormsSchedule();
				test.Log(Status.Info, "Clicked on ATX Forms Schedule Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/support/FormStatus/FormName";
				Assert.AreEqual(actualurl, (expectedurl));
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				throw;

			}

		}

		[TestMethod]
		public void Calenders_And_Charts_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_025 Execution").Info("Validation Started for Calenders and Charts URL");
				HomePage hp = new HomePage(driver);
				hp.CalendarsandCharts();
				test.Log(Status.Info, "Clicked on Calenders and Charts Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/support/atxcalendarsandcharts";
				Assert.AreEqual(actualurl, (expectedurl));
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				throw;

			}

		}

		[TestMethod]
		public void ATX_Product_Schedule_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_026 Execution").Info("Validation Started for  ATX Product Schedule  URL");
				HomePage hp = new HomePage(driver);
				hp.ATXProductSchedule();
				test.Log(Status.Info, "Clicked on Calenders and Charts Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/support/atxproductschedule";
				Assert.AreEqual(actualurl, (expectedurl));
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				throw;

			}

		}

		[TestMethod]
		public void AnswerConnect_Research_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_027 Execution").Info("Validation Started for AnswerConnect Research URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.AnswerConnectResearch();
				test.Log(Status.Info, "Clicked on AnswerConnect Reasearch icon");
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
				string expectedurl = "https://answerconnect.cch.com/federal";
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
		public void Remote_Connection_Utility_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_028 Execution").Info("Validation Started for Remote Connection Utility URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.RemoteConnectionUtility();
				test.Log(Status.Info, "Clicked on Remote Connection Utility icon");
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
				string expectedurl = "https://support-demo.cch.com/remote/";
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
		public void GDPR_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_029 Execution").Info("Validation Started for  GDPR link");
				HomePage hp = new HomePage(driver);
				hp.GDPR();
				test.Log(Status.Info, "Clicked on GDPR Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/support/GDPR";
				Assert.AreEqual(actualurl, (expectedurl));
				Console.WriteLine("Pass" + actualurl);
				test.Log(Status.Pass, "Result is Pass");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail, "Result is Fail");
				Console.WriteLine("Fail" + e);
				throw;

			}

		}
	}
}
