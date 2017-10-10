using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestSeleniumWebDriver.GeneralHook
{
    [Binding]
    public sealed class GeneralHook
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("BeforeTestRun Hook");
        }

        [AfterTestRun]
        public static void AftereTestRun()
        {
            Console.WriteLine("AftereTestRun Hook");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("BeforeFeature Hook");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("AfterFeature Hook");
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario Hook");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("AfterScenario Hook");
        }
    }
}
