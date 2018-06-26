using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowDemo2
{
    [Binding]
    public class Login_Steps
    {
        public IWebDriver driver;

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.store.demoqa.com";
        }
        
        [Given(@"navigates to the Login Page")]
        public void GivenNavigatesToTheLoginPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }

        [When(@"the user enters (.*) and (.*)")]
        public void WhenTheUserEntersAAnd(string username, string password)
        {
            driver.FindElement(By.Id("log")).SendKeys(username);
            driver.FindElement(By.Id("pwd")).SendKeys(password);
        }
        
        [When(@"clicks on the Login button")]
        public void WhenClicksOnTheLoginButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }
        
        [When(@"the user logs out of the application")]
        public void WhenTheUserLogsOutOfTheApplication()
        {
            driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();
        }
        
        [Then(@"the Success login message should be displayed")]
        public void ThenTheSuccessLoginMessageShouldBeDisplayed()
        {
            Thread.Sleep(20000);
            true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
            driver.Quit();
        }
        
        [Then(@"the Success logout message should be displayed")]
        public void ThenTheSuccessLogoutMessageShouldBeDisplayed()
        {
            true.Equals(driver.FindElement(By.Id("login")).Displayed);
            driver.Quit();
        }
    }
}
