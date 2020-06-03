using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Examine
{
    [TestClass]
    public class Exam
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //HighlightElementsUsingJavaScript
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
