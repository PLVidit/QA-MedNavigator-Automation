using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class SelectPaymentMethodPage
    {

        public SelectPaymentMethodPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement lnkSelect_paypalPayment => Driver.FindElement(By.XPath("//*[@id='redirect-tp-payment-gateway-frm']/div/div/div[2]/div[1]/div[2]/div/div/label/span[2]"));
        public IWebElement lnkSelect_StripePayment => Driver.FindElement(By.XPath("//*[@id='redirect-tp-payment-gateway-frm']/div/div/div[2]/div[2]/div[2]/div/div/label/span[2]"));
        public IWebElement lnkProcessingFee => Driver.FindElement(By.XPath("//span[@id='processing-fee-apply-block']"));
        public IWebElement lnkPayNow_PaymentMethod => Driver.FindElement(By.XPath("//button[@id='request-pay-now-btn']"));
        public IWebElement processingFee => Driver.FindElement(By.XPath("//*[@id='processing-fee-apply-block']"));        
        public IWebElement lnkselectContinue => Driver.FindElement(By.XPath("//button[@id='select-payment-gateway-button']"));    

        public void ClickPaynowPaymentMehtod()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,500)");
            lnkPayNow_PaymentMethod.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        public void SelectStripePaymentMethod()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            lnkSelect_StripePayment.Click();

        }
        public void SelectPaypalPaymentMethod()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            lnkSelect_paypalPayment.Click();

        }
        public void CheckProcessingFee()
        {
          
         string text = processingFee.Text.ToString();
           

            if (text == "$1.50") 
            {
                Console.WriteLine("Processing Fee is added $1.50");
            }
        }

        public void SelectContinueButton()
        {
            lnkselectContinue.Click();
        }
       

    }
}
