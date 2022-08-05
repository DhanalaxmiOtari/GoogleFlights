using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CrossBrowserFunctionalTest.Hooks
{
    [Binding]
    public sealed class Hooks1:Test.Tests
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        Test.Tests driver = new Test.Tests();
        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            driver.SetUp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            driver.TearDown();
        }
    }
}
