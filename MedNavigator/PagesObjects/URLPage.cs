using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
   public class  URLPage
    {
        IWebDriver webDriver = new ChromeDriver();
        public URLPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public void OpenURL()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            webDriver.Navigate().GoToUrl("https://dev.mednavigator.com/");
            webDriver.Manage().Window.Maximize();

        }
    }
}
