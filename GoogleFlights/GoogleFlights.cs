using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class GoogleFlights
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheGoogleFlightsTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/flights");
            driver.FindElement(By.XPath("//input[@value='Pune']")).Click();
            driver.FindElement(By.XPath("//div[@id='i15']/div[6]/div[2]/div[2]/div/div/input")).Clear();
            driver.FindElement(By.XPath("//div[@id='i15']/div[6]/div[2]/div[2]/div/div/input")).SendKeys("Pune, Ma");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Showing 1 nearby location.'])[1]/following::div[7]")).Click();
            driver.Navigate().GoToUrl("https://www.google.com/travel/flights?tfs=CBwQARoVagcIARIDUE5REgoyMDIyLTA1LTE1GhUSCjIwMjItMDUtMTlyBwgBEgNQTlFwAYIBCwj___________8BQAFIAZgBAQ");
            driver.FindElement(By.XPath("//div[@id='i15']/div[4]/div/div/div/div/div/input")).Click();
            driver.FindElement(By.XPath("//div[@id='i15']/div[6]/div[2]/div[2]/div/div/input")).Clear();
            driver.FindElement(By.XPath("//div[@id='i15']/div[6]/div[2]/div[2]/div/div/input")).SendKeys("Dubai");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Showing 2 nearby locations.'])[1]/following::div[7]")).Click();
            driver.Navigate().GoToUrl("https://www.google.com/travel/flights?tfs=CBwQARoeagcIARIDUE5REgoyMDIyLTA1LTE1cgcIARIDRFhCGh5qBwgBEgNEWEISCjIwMjItMDUtMTlyBwgBEgNQTlFwAYIBCwj___________8BQAFIAZgBAQ");
            driver.FindElement(By.XPath("//*/text()[normalize-space(.)='₹21.6K']/parent::*")).Click();
            driver.FindElement(By.XPath("//div[@id='ow60']/div[2]/div/div[2]/div[2]/div/div/div/div/div/div[2]/div[3]/div[4]/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='ow60']/div[2]/div/div[3]/div[3]/div/button/div[3]")).Click();
            driver.Navigate().GoToUrl("https://www.google.com/travel/flights/search?tfs=CBwQAhoeagcIARIDUE5REgoyMDIyLTA1LTIwcgcIARIDRFhCGh5qBwgBEgNEWEISCjIwMjItMDUtMjNyBwgBEgNQTlFwAYIBCwj___________8BQAFIAZgBAQ");
            driver.FindElement(By.XPath("//body[@id='yDmH0d']/div[8]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
