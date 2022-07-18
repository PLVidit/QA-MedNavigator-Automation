using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class SubscribePage
    {      

            public SubscribePage(IWebDriver webDriver)
            {
                Driver = webDriver;
            }

            public IWebDriver Driver { get; }

      public IWebElement subscriptionPaymentTerm => Driver.FindElement(By.XPath("//select[@id='subscription-plan']"));

      public IWebElement payNow => Driver.FindElement(By.XPath("//*[@id='form-signin']/div[1]/div[2]/div/div[23]/input[2]"));
     //   public IWebElement payNow => Driver.FindElement(By.XPath("//*[@id='form-signin']/div[1]/div[2]/div/div[23]/input[2]"));


        public void SelectPayment()
        {
            SelectElement subscription = new SelectElement(subscriptionPaymentTerm);
            subscription.SelectByText("Monthly");
        }
        public void clickPayNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            System.Threading.Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0,950)");
            payNow.Click();            
        }







    }
}
