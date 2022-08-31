using OpenQA.Selenium;
using SeleniumSample.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SeleniumSample.Demo.PageObject
{
    public class DemoPayeesPage : DemoBasePage
    {
        private readonly IWebDriver driver;
        public DemoPayeesPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Web Element
        public By HeaderText = By.XPath("//span[contains(text(),'Payees')]");
        public By AddPayee = By.XPath("//span[contains(text(),'Add')]");
        public By PayeeNameInput = By.Id("ComboboxInput-apm-name");
        public By ApmBankInput = By.Id("apm-bank");
        public By ApmBranchInput = By.Id("apm-branch");
        public By ApmAccountInput = By.Id("apm-account");
        public By ApmSuffixInput = By.Id("apm-suffix");
        public By AddPayeeButton = By.XPath("//body/div[@id='YouMoney']/div[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/form[1]/div[2]/button[3]");

        public IWebElement HeaderTextElement => driver.FindElement(HeaderText);
        public IWebElement AddPayeeElement => driver.FindElement(AddPayee);
        #endregion

        #region Action
        public void EnterPayeeTestDetails()
        {
            TextBoxHelper.TypeInTextBox(PayeeNameInput, "TestPayee");
            ButtonHelper.ClickButton(By.XPath("//span[contains(text(),'Someone new: TestPayee')]"));
            TextBoxHelper.TypeInTextBox(ApmBankInput, "03");
            TextBoxHelper.TypeInTextBox(ApmBranchInput, "1111");
            TextBoxHelper.TypeInTextBox(ApmAccountInput, "1234567");
            TextBoxHelper.TypeInTextBox(ApmSuffixInput, "000");
        }

        public void ClickAddPayeeButton()
        {
            ButtonHelper.ClickButton(AddPayeeButton);
        }

        public void CheckAddedTestAccount()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[contains(text(),'TestPayee')]")));
        }
        #endregion

    }
}
