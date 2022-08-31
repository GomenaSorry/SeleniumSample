using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumSample.ComponentHelper;
using System.Collections;
using SeleniumSample.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SeleniumSample.ComponentHelper
{
    public class ListHelper
    {
        public static IWebElement element;

        public static void CheckListIfSorted(By locator)
        {
            ArrayList obtainedList = new ArrayList();
            IReadOnlyCollection<IWebElement> elementList = ObjectRepository.Driver.FindElements(locator);
            foreach (IWebElement we in elementList)
            {
                obtainedList.Add(we.Text.ToString());
            }

            ArrayList sortedList = new ArrayList();
            foreach (string s in obtainedList)
            {
                sortedList.Add(s);
            }
            sortedList.Sort();

            CollectionAssert.AreEqual(sortedList, obtainedList);
        }

        public static void CheckListIfSortedReversed(By locator)
        {
            ArrayList obtainedList = new ArrayList();
            IReadOnlyCollection<IWebElement> elementList = ObjectRepository.Driver.FindElements(locator);
            foreach (IWebElement we in elementList)
            {
                obtainedList.Add(we.Text.ToString());
            }

            ArrayList sortedList = new ArrayList();
            foreach (string s in obtainedList)
            {
                sortedList.Add(s);
            }
            sortedList.Sort();
            sortedList.Reverse();

            CollectionAssert.AreEqual(sortedList, obtainedList);
        }
    }
}