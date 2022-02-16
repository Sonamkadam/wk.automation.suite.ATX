using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SFS_SmokeTest.TestScripts.SessionTimeout
{
    public class CsvDataSourceAttribute : Attribute, ITestDataSource
    {

        public CsvDataSourceAttribute(string fileName)
        {
            FileName = fileName;
        }


        public string FileName { get; }


        public  IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            string[] csvLines = File.ReadAllLines(FileName);
            var testCases = new List<object[]>();
            foreach (var csvLine in csvLines)
            {
                IEnumerable<string> values = csvLine.Split(',');
                object[] testCase = values.Cast<object>().ToArray();
                testCases.Add(testCase);

            }
            return testCases;
             
    }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data == null)
                return null;
            return $"{methodInfo.Name}  ({ string.Join(",",data)})";
        }
    }
}
