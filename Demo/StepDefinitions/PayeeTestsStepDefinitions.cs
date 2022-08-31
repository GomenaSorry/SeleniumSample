using TechTalk.SpecFlow;
using SeleniumSample.ComponentHelper;
using SeleniumSample.Settings;
using SeleniumSample.Demo.PageObject;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumSample.StepDefinitions
{
    [Binding]
    public class PayeeTestsStepDefinitions
    {
        #region Given
        [Given(@"that the user is in the Home page")]
        public void GivenThatTheUserIsInTheHomePage()
        {
            ObjectRepository.demoHomePage = new DemoHomePage(ObjectRepository.Driver);
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetDemoWebsite());
        }

        [Given(@"that the user is in the Payees page")]
        public void GivenThatTheUserIsInThePayeesPage()
        {
            ObjectRepository.demoHomePage = new DemoHomePage(ObjectRepository.Driver);
            NavigationHelper.NavigateUrl(ObjectRepository.Config.GetDemoWebsite());
            ButtonHelper.ClickButton(ObjectRepository.demoHomePage.MenuButton);
            ObjectRepository.demoPayeesPage = new DemoPayeesPage(ObjectRepository.Driver);
            ButtonHelper.ClickButton(ObjectRepository.demoHomePage.PayeesButton);
            ObjectRepository.demoPayeesPage = ObjectRepository.demoHomePage.NavigateToPayeesPage(ObjectRepository.Driver);
        }
        #endregion

        #region When
        [When(@"the user clicks the Menu element")]
        public void WhenTheUserClicksTheMenuElement()
        {
            ButtonHelper.ClickButton(ObjectRepository.demoHomePage.MenuButton);
        }

        [When(@"the user clicks the Payees element")]
        public void WhenTheUserClicksThePayeesElement()
        {
            ObjectRepository.demoPayeesPage = new DemoPayeesPage(ObjectRepository.Driver);
            ButtonHelper.ClickButton(ObjectRepository.demoHomePage.PayeesButton);
            ObjectRepository.demoPayeesPage = ObjectRepository.demoHomePage.NavigateToPayeesPage(ObjectRepository.Driver);
        }

        [When(@"the user clicks the Add element")]
        public void WhenTheUserClicksTheAddElement()
        {
            ButtonHelper.ClickButton(ObjectRepository.demoPayeesPage.AddPayee);
        }

        [When(@"the user enters the payee details")]
        public void WhenTheUserEntersThePayeeDetails()
        {
            ObjectRepository.demoPayeesPage.EnterPayeeTestDetails();
        }

        [When(@"the user clicks the Add Payee element")]
        public void WhenTheUserClicksTheAddPayeeElement()
        {
            ObjectRepository.demoPayeesPage.ClickAddPayeeButton();
        }

        [When(@"the user provides a Payee name")]
        public void WhenTheUserProvidesAPayeeName()
        {
            TextBoxHelper.TypeInTextBox(ObjectRepository.demoPayeesPage.PayeeNameInput, "TestPayee");
            ButtonHelper.ClickButton(By.XPath("//span[contains(text(),'Someone new: TestPayee')]"));
        }

        [When(@"the user clicks the Name element")]
        public void WhenTheUserClicksTheNameElement()
        {
           GenericHelper.GetElement(By.XPath("//span[contains(text(),'Name')]")).Click();
        }
        #endregion

        #region Then
        [Then(@"the user should be in the Payees page")]
        public void ThenTheUserShouldBeInThePayeesPage()
        {
            GenericHelper.IsElementPresent(ObjectRepository.demoPayeesPage.HeaderText);
        }

        [Then(@"the page should load completely under (.*) milliseconds")]
        public void ThenThePageShouldLoadCompletelyUnderSeconds(int baseline)
        {
            PerformanceHelper.GetPageLoadTime(baseline);
        }

        [Then(@"the user added Payee should be present")]
        public void ThenTheUserAddedPayeeShouldBePresent()
        {
            ObjectRepository.demoPayeesPage.CheckAddedTestAccount();
        }

        [Then(@"the following error message should show when clicking an input field")]
        public void ThenTheFollowingErrorMessageShouldShowWhenClickingAnInputField(Table table)
        {
            foreach (var row in table.Rows)
            {
                GenericHelper.GetElement(By.Id(row["inputField"])).Click();
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath($"//p[contains(text(), '{row["errorMessage"]}')]")));
            }
        }

        [Then(@"no error messages should be shown")]
        public void ThenNoErrorMessagesShouldBeShown()
        {
            Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//div[@class='error-header']")));
        }

        [Then(@"the payee list should be ordered alphabetically")]
        public void ThenThePayeeListShouldBeOrderedAlphabetically()
        {
            ListHelper.CheckListIfSorted(By.XPath("//ul/li"));
        }

        [Then(@"the payee list should be ordered alphabetically reversed")]
        public void ThenThePayeeListShouldBeOrderedAlphabeticallyReversed()
        {
            ListHelper.CheckListIfSortedReversed(By.XPath("//ul/li"));
        }
        #endregion
    }
}
