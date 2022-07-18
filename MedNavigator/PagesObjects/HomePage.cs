using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class HomePage
    {

        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

      //  public IWebElement lnkLogin => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li/a"));
        public IWebElement lnkLogin => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']//ul/li/a"));

        //public void OpenURl()
        //{

        //    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);
        //    Driver.Navigate().GoToUrl("https://dev.mednavigator.com/");
        //    Driver.Manage().Window.Maximize();
        //}


        public void ClickLogin()
        {
            IWebElement Login_1 = Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li/a"));
            Login_1.Click();
        }

    }
}
