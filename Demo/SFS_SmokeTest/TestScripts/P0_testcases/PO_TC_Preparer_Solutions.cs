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
	public class PO_TC_Preparer_Solutions : BaseTest
	{
		[TestMethod]
		public void Getting_Started_with_ATX_2020_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_014 Execution").Info("Validation Started for Getting Started with ATX 2020 URL");
				HomePage hp = new HomePage(driver);
				hp.GettingStartedWithATX2020();
				test.Log(Status.Info, "Clicked on Getting Started with ATX 2020 Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/taxna/getting-started/atx/2020";
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
		public void ATX_Blog_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_015 Execution").Info("Validation Started for ATX Blog URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.ATXBlog();
				test.Log(Status.Info, "Clicked on ATX Blog icon");
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
				string expectedurl = "https://myatx.blogspot.com/";
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
		public void User_Guides_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_016 Execution").Info("Validation Started for User Guides URL");
				HomePage hp = new HomePage(driver);
				hp.UserGuides();
				test.Log(Status.Info, "Clicked on User Guides Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/support/atxuserguides";
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
		public void Conversions_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_017 Execution").Info("Validation Started for Conversions URL");
				HomePage hp = new HomePage(driver);
				hp.Conversions();
				test.Log(Status.Info, "Clicked on Conversions Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/download/ATXConversions";
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
		public void System_Requirements_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_018 Execution").Info("Validation Started for System Requirements URL");
				HomePage hp = new HomePage(driver);
				hp.SystemRequirements();
				test.Log(Status.Info, "Clicked on System Requirements Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/taxna/software-system-requirements";
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
		public void ATX_Learning_Portal_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_019 Execution").Info("Validation Started for ATX Learning Portal URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.ATXLearningPortal();
				test.Log(Status.Info, "Clicked on ATX Learning Portal icon");
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
				string expectedurl = "https://support-demo.cch.com/lms/sfs/atx";
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
		public void PCR_Learning_Portal_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_020 Execution").Info("Validation Started for ATX Learning Portal URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.PCRLearningPortal();
				test.Log(Status.Info, "Clicked on PCR Learning Portal icon");
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
				string expectedurl = "https://support-demo.cch.com/lms/sfs/PCR";
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


