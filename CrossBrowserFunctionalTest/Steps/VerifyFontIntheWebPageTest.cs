using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace CrossBrowserFunctionalTest
{
    [Binding]
    public class VerifyFontIntheWebPageTest: Test.Tests
    {
        Test.Tests driver = new Test.Tests();

        [Given(@"Load the page")]
        public void GivenLoadThePage()
        {
            string URL = "https://www.msn.com/en-in/entertainment/bollywood/monica-lewinsky-urges-beyonc%C3%A9-to-change-a-lyric-about-her-in-2013-song-partition-after-making-changes-to-new-album/ar-AA10gz4P?ocid=entnewsntp&cvid=43da457988294e2781d86247e05a5fa6";
            driver.Navigate(URL);
            
        }
        
        [Then(@"Verify Fonts in webpage")]
        public void ThenVerifyFontsInWebpage()
        {
            string xpath = "//div[@class='viewsTitle']";
            driver.CSSFontSizePropFindElement(xpath);
            driver.CSSFontNamePropFindElement(xpath);
            Assert.AreEqual(32, driver.CSSFontSizePropFindElement(xpath));

        }
    }
}
