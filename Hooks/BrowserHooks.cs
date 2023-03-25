using System;
using InternetHerokuapp.Driver;
using InternetHerokuapp.PageObjects;
using TechTalk.SpecFlow;

namespace InternetHerokuapp.Hooks
{
    [Binding]
    public class BrowserHooks
    {

        [BeforeScenario]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var Driver = new Add_Remove_Elements_Page(browserDriver.Current);

        }

        [AfterScenario]
        public static void AfterScenario(BrowserDriver browserDriver)
        {
            browserDriver.Dispose();

            

        }

    }
}
