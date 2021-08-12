using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SFS_ATX.BaseClass
{
 
    public  class TestData
    {
        [TestMethod]
        public void fileread()
        {
            FileStream fs = new FileStream("C:\\FileStreamautomation\\sonam.xls", FileMode.Open);
            fs.Close();
            Console.WriteLine("done");

        }
    }
}
