using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumCSLearning
{
	public class AppiumTests
	{
        AppiumDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string appPath = projectDirectory + "/apps/Android-MyDemoAppRN.1.3.0.build-244.apk";
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("appium:platformName", "Android");
            options.AddAdditionalCapability("appium:automationName", "UiAutomator2");
            options.AddAdditionalCapability("appium:deviceName", "Pixel7");
            options.AddAdditionalCapability("appium:app", appPath);
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("App Launched...");
        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}

