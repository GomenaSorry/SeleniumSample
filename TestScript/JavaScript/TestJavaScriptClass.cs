using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumSample.ComponentHelper;
using SeleniumSample.Settings;

namespace SeleniumSample.TestScript.JavaScriptClass
{
    [TestClass]
    public class TestJavaScriptClass
    {
        [TestMethod]
        public void TestJavaScript()
        {
            NavigationHelper.NavigateUrl("https://demos.telerik.com/kendo-ui/textbox/index");
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.Driver);
            executor.ExecuteScript("document.getElementById('textbox').value='test'");
        }
    }
}
