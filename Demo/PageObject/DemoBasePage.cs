using SeleniumSample.ComponentHelper;
using OpenQA.Selenium;
using SeleniumSample.Settings;


namespace SeleniumSample.Demo.PageObject
{
    public class DemoBasePage
    {
        private readonly IWebDriver driver;

        public DemoBasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        #region WebElement

        private readonly By BackButton = By.XPath("//header/h1[1]/button[1]");

        public IWebElement BackButtonElement => driver.FindElement(BackButton);

        #endregion

        #region Action
        // pending
        #endregion

        #region Navigation
        // pending
        #endregion

        public string Title
        {
            get { return ObjectRepository.Driver.Title; }
        }
    }

}
