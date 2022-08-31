using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumSample.Interfaces;
using SeleniumSample.PageObject;
using SeleniumSample.Demo.PageObject;
using OpenQA.Selenium;

namespace SeleniumSample.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        // SpecFlow dependency injection
        public static HomePage homePage;
        public static HtmlFormPage htmlFormPage;
        public static FormProcessorPage formProcessorPage;

        // Banking web application demo
        public static DemoHomePage demoHomePage;
        public static DemoPayeesPage demoPayeesPage;
    }
}
