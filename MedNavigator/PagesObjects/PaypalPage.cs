using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{   
        public class Paypalpage
        {

         public Paypalpage(IWebDriver webDriver)
         {
          Driver = webDriver;
         }

         public IWebDriver Driver { get; }

        public IWebElement lnkPayNow_PayPal => Driver.FindElement(By.XPath("//button[@id='payment-submit-btn']"));
        public IWebElement lnkCancelPayment_Paypal => Driver.FindElement(By.XPath("//a[@class='CancelLink_cancel-link_2uud4']"));
        public IWebElement lnkEmailAddress_Paypal => Driver.FindElement(By.XPath("//input[@id='email']"));
        public IWebElement lnkpassword_Paypal => Driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement lnkLoginButton_PayPal => Driver.FindElement(By.XPath("//button[@id='btnLogin']"));
        public IWebElement btnNext => Driver.FindElement(By.XPath("//button[@id='btnNext']"));
        public IWebElement agreeAndSubscribePayPal => Driver.FindElement(By.XPath("//input[@id='confirmButtonTop']"));


        public void AgreeandSubscribe()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,500)");
            agreeAndSubscribePayPal.Click();
        }
        public void EnterCredentials_Paypal()
        {
            lnkEmailAddress_Paypal.SendKeys("vijay.kansal-buyer@gmail.com");
            btnNext.Click();
            lnkpassword_Paypal.SendKeys("admin123");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,500)");
            lnkLoginButton_PayPal.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void ClickPaynow_PayPal()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            Thread.Sleep(3000);
            lnkPayNow_PayPal.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public void CancelPayment_PayPal()
        {
            lnkCancelPayment_Paypal.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }




    }
}
