using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumSample.KeywordDriven;

namespace SeleniumSample.TestScript.KeywordDriven
{
    [TestClass]
    public class TestKeywordDriven
    {
        [TestMethod]
        public void TestKeyword()
        {
            DataEngine keyDataEngine = new DataEngine();
            keyDataEngine.ExecuteScript(@"C:\SampleKeywordDrivenTest.xlsx", "Sheet1");

        }
    }
}
