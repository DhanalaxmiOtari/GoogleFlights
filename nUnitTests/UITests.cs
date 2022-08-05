using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        IWebDriver _webDriver;
        string Xpath = "//div[@id='SIvCob']";
        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }
        
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void Test()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google"));
        }
        [Test]
        public void Navigate()
        {
            string URL = "https://www.google.com";
            _webDriver.Navigate().GoToUrl(URL);
            System.Console.WriteLine("size "+CSSFontSizePropFindElement(Xpath));
            System.Console.WriteLine("name "+CSSFontNamePropFindElement(Xpath));
        }
        public void TxtBoxFindElement(string SendKeyValue, string Xpath)
        {

            _webDriver.FindElement(By.XPath("Xpath")).SendKeys(SendKeyValue);
        }
        public void ButtonFindElement(string Xpath)
        {
            _webDriver.FindElement(By.XPath("Xpath")).Click();
        }

        public string CSSFontSizePropFindElement(string Xpath)
        {

            string font_size = _webDriver.FindElement(By.XPath(Xpath)).GetCssValue("font-size");
            return font_size;
        }
        public string CSSFontNamePropFindElement(string Xpath)
        {
            Xpath = "//div[@class='viewsTitle']";
            string font_name = _webDriver.FindElement(By.XPath(Xpath)).GetCssValue("font-type");
            return font_name;
        }
    }
}