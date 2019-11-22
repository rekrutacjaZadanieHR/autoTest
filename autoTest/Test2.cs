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
    public class Tests2 : IDisposable
    {
        public IWebDriver driver;

        public Tests2()
        {
            try
            {
                driver = new ChromeDriver();

          
            }
            catch (Exception )
            {
                Console.WriteLine("Test");
            }
        }
        [Fact]
        public void wyszukiwanie()
        {
            
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
           driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
           driver.Navigate().GoToUrl("https://www.medicalgorithmics.pl");
            
            Assert.Equal("https://www.medicalgorithmics.pl/", driver.Url);
           
            driver.Manage().Window.Maximize();
            IWebElement search = driver.FindElement(By.XPath("//span[contains(@class,'search ')]"));
            search.Click();
            Thread.Sleep(1000);
            IWebElement search2 = driver.FindElement(By.XPath("//input[@name='s']"));
            search2.SendKeys("Pocket ECG CRS");
            IWebElement enter = driver.FindElement(By.XPath("//span[contains(@class,'element')]"));
            enter.Click();
            Thread.Sleep(3000);

            //int resultList = driver.FindElements(By.ClassName("latest_post_custom")).Count();

            //var rList = driver.FindElements(By.ClassName("latest_post_custom"));

            
          

        }
        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                Console.WriteLine("Test");
            }
        }
    }
}
