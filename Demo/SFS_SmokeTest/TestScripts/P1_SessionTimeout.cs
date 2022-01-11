using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFS_ATX.BaseClass;
using SFS_ATX.PagesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.ClassLevel)]
namespace Demo.SFS_SmokeTest.TestScripts
{
    [TestClass]
  public  class P1_SessionTimeout : BaseTest

    {
        [TestMethod]
        public void pooled_connection()
        {
            HomeIndexPage HIP = new HomeIndexPage(driver);

            HIP.DownloadsLink();
 
        }
    }
}
