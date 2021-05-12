﻿using NUnit.Framework;

namespace Bellatrix.Mobile.Android.GettingStarted
{
    [TestFixture]
    [Android(Constants.AndroidNativeAppPath,
        Constants.AndroidDefaultAndroidVersion,
        Constants.AndroidDefaultDeviceName,
        Constants.AndroidNativeAppAppExamplePackage,
        ".view.Controls1",
        Lifecycle.ReuseIfStarted)]
    public class CustomWebDriverCapabilitiesTests : MSTest.AndroidTest
    {
        // 1. BELLATRIX hides the complexity of initialization of WebDriver/Appium and all related services.
        // In some cases, you need to customise the set up of a Appium with using custom Appium options.
        // Using the App service methods you can add all of these with ease. Make sure to call them in the TestsArrange which is called before the
        // execution of the tests placed in the test class. These options are used only for the tests in this particular class.
        // Note: You can use all of these methods no matter which attributes you use- Android, AndroidSauceLabs, AndroidBrowserStack or AndroidCrossBrowserTesting.
        public override void TestsArrange()
        {
            // 2. Add custom Appium options.
            App.AddAdditionalCapability("locale", "fr_CA");
            App.AddAdditionalCapability("language", "fr");
            App.AddAdditionalCapability("autoWebview", "true");
            App.AddAdditionalCapability("noReset", "false");
        }

        [Test]
        [Ignore("API example purposes only. No need to run.")]
        public void ButtonClicked_When_CallClickMethod()
        {
            var button = App.Components.CreateByIdContaining<Button>("button");

            button.Click();
        }

        [Test]
        [Ignore("API example purposes only. No need to run.")]
        public void ButtonClicked_When_CallClickMethodSecond()
        {
            var button = App.Components.CreateByIdContaining<Button>("button");

            button.Click();
        }
    }
}