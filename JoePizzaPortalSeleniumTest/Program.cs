using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace JoePizzaPortalSeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver(@"C:\Users\11035908\source\PhaseFour\chromedriver_win32");
                var js = (IJavaScriptExecutor)driver;
                driver.Navigate().GoToUrl("http://localhost:1150");
                
                //Click on the hyperlink Button
                IWebElement ele = driver.FindElement(By.XPath("//a[@href='/Pizza']"));
                ele.Click();

                //Choose Quantity
                ele = driver.FindElement(By.Id("3-Quantity"));
                ele.Clear();
                ele.SendKeys("1");

                //Choose Type
                ele = driver.FindElement(By.Id("Type-3-NonVeg"));
                ele.Click();
                Thread.Sleep(1000);

                //Continue
                ele = driver.FindElement(By.Name("Proceed-3"));
                Thread.Sleep(1000);
                ele.Click();

                Thread.Sleep(1000);
                ele = driver.FindElement(By.Name("CCName"));
                ele.SendKeys("Niranjana B S");
                ele = driver.FindElement(By.Name("CardNumber"));
                ele.SendKeys("345612890990");
                ele = driver.FindElement(By.Name("ShippingAddress"));
                ele.SendKeys("10th Main Road,CHBC Layout,Vijayanagar,Bangalore");
                ele = driver.FindElement(By.Name("cvv"));
                ele.SendKeys("123");
                Thread.Sleep(2000);
                ele = driver.FindElement(By.Name("Submit"));
                ele.Click();

                //Go back to home
                ele = driver.FindElement(By.XPath("//a[@href='/']"));
                Thread.Sleep(2000);

                driver.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error >> \n" + e.Message);
            }


        }
    }
}
