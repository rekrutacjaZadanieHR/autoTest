using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;
using Xunit;


namespace autoTest
{
    public class Tests1 : IDisposable
    {
        public IWebDriver driver;

        public Tests1()
        {
            try
            {   
                driver = new ChromeDriver();
                
            }
            catch (Exception )
            {
                Console.WriteLine("TEST");
            }
        }
        [Fact]
        public void downloadPDF()
        {
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.medicalgorithmics.pl");
            Assert.Equal("https://www.medicalgorithmics.pl/", driver.Url);
            driver.Manage().Window.Maximize();
            //IWebElement webElement = driver.FindElement(By.XPath("//a[@xpath='1']"));
            IWebElement webElement = driver.FindElement(By.Id("mega-menu-item-29"));
            String color = driver.FindElement(By.Id("mega-menu-item-29")).GetCssValue("color");
            Assert.Equal("rgba(102, 102, 102, 1)", color);
            webElement.Click();
            Thread.Sleep(20000);


            IWebElement element = driver.FindElement(By.XPath("//img[@title='ico-circle-media']"));
            element.Click();

            

            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element).Click().Build().Perform();
            //Thread.Sleep(20000);

            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            //jse.ExecuteScript("arguments[0].scrollIntoView()", element);
            //element.Click();

            //IWebElement element = driver.FindElement(By.LinkText("Media pack"));
            //element.Click();

            //actions.MoveToElement(element).Click().Build().Perform();
            //IWebElement mediaPack = driver.FindElement(By.XPath("//img[contains(@title,'ico-circle-media')]"));
            //mediaPack.Click();
            //Actions actionsMP = new Actions(driver);
            //actionsMP.MoveToElement(element).Click().Build().Perform();


            //IWebElement logo = driver.FindElement(By.LinkText("logotypy.zip"));
            IWebElement logo = driver.FindElement(By.XPath("//strong[contains(.,'Logotypy')]"));
           
            logo.Click();
            Thread.Sleep(7000);
        }
        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch(Exception)
            {
                Console.WriteLine("TEST");
            }
        }
    }
}
