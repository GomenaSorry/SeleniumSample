using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumSample.ComponentHelper;


namespace SeleniumSample.ComponentHelper
{
    public class LinkHelper
    {
        public static IWebElement element;

        public static void ClickLink(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Click();
        }
    }
}
