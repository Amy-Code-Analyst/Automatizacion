using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automatizacion
{
    class Program
    {
  
        static void Main(string[] args)
        {

            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();//**
            //
            IWebElement input = driver.FindElement(By.Id("search_query_top"));
            input.SendKeys("Vestidos");
            //
            IWebElement button = driver.FindElement(By.Name("submit_search"));
            button.Click();
            
        }
    }
}
