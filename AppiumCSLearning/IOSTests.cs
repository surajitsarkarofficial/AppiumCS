using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;

namespace AppiumCSLearning
{
	public class IOSTests
	{
        AppiumDriver<IOSElement> driver;

        [SetUp]
        public void Setup()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string appPath = projectDirectory + "/apps/iOS-Simulator-MyRNDemoApp.1.3.0-162.zip";
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("appium:platformName", "iOS");
            options.AddAdditionalCapability("appium:automationName", "XCUITest");
            options.AddAdditionalCapability("appium:deviceName", "iPhone 15 Pro Max");
            options.AddAdditionalCapability("appium:app", appPath);
            options.AddAdditionalCapability("appium:newCommandTimeout", "120000");
            driver = new IOSDriver<IOSElement>(new Uri("http://127.0.0.1:4723"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void IOSTest1()
        {
            TestContext.Progress.WriteLine("App Launched...");
        }
        [TearDown]
        public void Teardown()
        {
            driver.TerminateApp("com.saucelabs.mydemoapp.rn");
            driver.Quit();
        }
    }
}

