﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFS_ATX.BaseClass;
using SFS_ATX.PagesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SFS_ATX.TestScripts
{
	[TestClass]
	public class P0_TC_Generic : BaseTest
	{

		[TestMethod]
		public void KBSearch_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_004 Execution").Info("Validation Started for KB Search URL");
				HomePage hp = new HomePage(driver);
				String parentWindowHandle = driver.CurrentWindowHandle;
				Console.WriteLine("CurrentWindow" + parentWindowHandle);
				hp.KbSearchTextBox("ATX tax article");
				test.Log(Status.Info, "Clicked on Serach icon");
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
				string expectedurl = "https://support-demo.cch.com/sfs";
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
		public void PasswordCenter_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_005 Execution").Info("Validation Started for PasswordCenter URL");
				HomePage hp = new HomePage(driver);
				hp.PasswordCenterLink();
				test.Log(Status.Info, "Clicked on PasswordCenter Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/home/passwordcenter";
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
		public void ATXProgramDownload_HomePageTestcases()
		{
			try
			{
				test = extent.CreateTest("TC_021 Execution").Info("Validation Started for ATXProgramDownload URL");
				HomePage hp = new HomePage(driver);
				hp.ATXProgramDownloadsLink();
				test.Log(Status.Info, "Clicked on ATXProgramDownload Link");
				string actualurl = driver.Url;
				string page_title = driver.Title;
				Console.WriteLine("Current_Page_Title" + page_title);
				string expectedurl = "https://wdc-qa-support.atxinc.com/download/ATXProgramDownload";
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


