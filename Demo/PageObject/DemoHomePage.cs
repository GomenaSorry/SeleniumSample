using OpenQA.Selenium;
using SeleniumSample.Settings;
using SeleniumSample.ComponentHelper;


namespace SeleniumSample.Demo.PageObject
{
    public class DemoHomePage
    {
        private readonly IWebDriver driver;

        public DemoHomePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        #region WebElement

        public By MenuButton = By.XPath("//body/div[@id='YouMoney']/div[1]/div[1]/div[3]/div[2]/div[2]/div[1]/div[1]/div[1]/button[1]/*[1]");
        public By PayeesButton = By.XPath("//span[contains(text(),'Payees')]");

        public IWebElement MenuButtonElement => driver.FindElement(MenuButton);
        public IWebElement PayeesButtonElement => driver.FindElement(PayeesButton);

        #endregion

        #region Action
        // pending
        #endregion

        #region Navigation
        public DemoPayeesPage NavigateToPayeesPage(IWebDriver driver)
        {
            ButtonHelper.ClickButton(PayeesButton);
            return new DemoPayeesPage(driver);
        }
        #endregion

        public string Title
        {
            get { return ObjectRepository.Driver.Title; }
        }
    }

}
