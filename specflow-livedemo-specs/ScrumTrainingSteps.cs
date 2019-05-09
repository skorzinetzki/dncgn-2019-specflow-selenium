using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace specflow_livedemo_specs
{
    [Binding]
    public class ScrumTrainingSteps
    {
        private static IWebDriver _driver;

        [BeforeFeature()]
        public static void BeforeFeature()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            _driver.Quit();
        }

        [BeforeStep()]
        public void BeforeStep()
        {
            System.Threading.Thread.Sleep(5000);
        }

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _driver.Navigate().GoToUrl("https://www.lise.de");
        }
        
        [When(@"I click on the menu")]
        public void WhenIClickOnTheMenu()
        {
            _driver
                .FindElement(By.CssSelector("#page-header > div > div.col-md-11 > button.menu-btn"))
                .Click();
        }
        
        [When(@"I click on scrum trainings")]
        public void WhenIClickOnScrumTrainings()
        {
            IWebElement element = _driver
                .FindElement(By.CssSelector("div.top > div > ul > li.pushy-submenu.pushy-submenu-open"))
                .FindElement(By.LinkText("SCRUM TRAININGS"));

            Assert.That(element.Text.Trim(), Is.EqualTo("SCRUM TRAININGS"));

            element.Click();
        }
        
        [Then(@"I should be navigated to ""(.*)""")]
        public void ThenIShouldBeRedirectTo(string expectedUrlPath)
        {
            string url = _driver.Url.TrimEnd('/');
            Assert.That(url.EndsWith(expectedUrlPath), Is.True, $"{url} does not end with {expectedUrlPath}");
        }
    }
}
