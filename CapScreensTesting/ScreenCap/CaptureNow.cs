using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace ScreenCap
{
    public class CaptureNow
    {
        public CaptureNow(string something)
        {

        }

        public void Start()
        {
            IWebDriver chromedDriver = new ChromeDriver(@"C:\Users\Brett\source\repos\Work\CapScreensTesting\ScreenCap\bin\Debug\netstandard2.0");
            chromedDriver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 1, 0);
            chromedDriver.Manage().Window.Maximize();
            chromedDriver.Navigate().GoToUrl("http://www.google.com");


            chromedDriver.Manage().Window.Maximize();
            chromedDriver.Navigate().GoToUrl("https://qeworks.com/questions/question/selenium-webdriver-c-full-website-screenshots-with-chromedriver-and-firefoxdriver");
            ITakesScreenshot screenshotDriver = chromedDriver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\Brett\Pictures\TesingProjectScreeencap\test.png");
        }


    }
}
