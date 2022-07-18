using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class LoginPage
    {

        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }
        public IWebElement lnkEmailID => Driver.FindElement(By.XPath("//*[@id='form-signin']/div/div/div[2]/div/div[1]/input"));
        public IWebElement lnkPassword => Driver.FindElement(By.XPath("//*[@id='password']"));
        public IWebElement lnkClickLogin => Driver.FindElement(By.XPath("//*[@id='form-signin']/div/div/div[2]/div/div[4]/button"));
        

        private bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void EnterCredentials()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);
            lnkEmailID.SendKeys("intellinez.test@yopmail.com");
            lnkPassword.SendKeys("Admin@123");
            lnkClickLogin.Click();



            //var dangerMessage = IsElementPresent(By.Id("danger_message"));

            //IWebElement abc;
            //IWebElement invalidMessage = dangerMessage ? Driver.FindElement(By.XPath("//*[@id='danger_message']")) : abc;

            //string actualError = "Success";
            //if (invalidMessage != null)
            //    actualError = invalidMessage.Text;

            //Console.WriteLine(actualError);

        }
    }



}















