using TechTalk.SpecFlow;
using NUnit.Framework;
//Docs on NUnit parallelization: https://github.com/nunit/docs/wiki/Framework-Parallel-Test-Execution
[assembly: Parallelizable(ParallelScope.Fixtures)]
//Set this value to the Maximum amount of VMs that you have in Sauce Labs
[assembly: LevelOfParallelism(4)]



namespace CrossBrowserFunctionalTest.Steps
{
    [Binding]
    public class WebsiteUIandFunctionalTestScript:Test.Tests
    {
        Test.Tests driver = new Test.Tests();
        [Given(@"Load Website ""http://google\.com")]
        public void GivenLoadWebsiteHttpGoogle_Com(string URL)
        {
            URL = "http://google.com";
            driver.Navigate(URL);
        }
        
        [Given(@"Enter Serach text ""(.*)""")]
        public void GivenEnterSerachText(string p0)
        {
            string Xpath = "//input[@title='Search']";
            p0 = "Selenium Test";
            driver.TxtBoxFindElement(Xpath,p0 );
        }
        
        [When(@"Click on Search button")]
        public void WhenClickOnSearchButton()
        {
            string xpath = "//div[@class='CqAVzb lJ9FBc']//input[@name='btnK']";
            driver.ButtonFindElement(xpath);
        }
        
        [Then(@"Search Reasults displayed")]
        public void ThenSearchReasultsDisplayed()
        {
            System.Console.WriteLine("Results displayed");
            
        }
    }
}
