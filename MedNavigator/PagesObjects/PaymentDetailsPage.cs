using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class PaymentDetailsPage
    {
        public PaymentDetailsPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement lnkSelectAvailableCode => Driver.FindElement(By.XPath("//a[@class='code-information-list']"));

        // public IWebElement lnkSelectPromotionalCode_1 => Driver.FindElement(By.XPath(""));
        public IWebElement lnkPaynowButton => Driver.FindElement(By.XPath("//button[@id='request-pay-now-btn']"));
        public IWebElement lnkCancelButton => Driver.FindElement(By.XPath("//*[@id='paymentModel']/div/div/form/div/div[3]/a"));

        public IWebElement lnkWalletBalance => Driver.FindElement(By.XPath("//h2[@id='walletamt-total-amt-blk']"));
        public IWebElement lnkGrandTotal => Driver.FindElement(By.XPath("//h2[@id='grand-total-amt-blk']"));
        public IWebElement closePaymentDetailsPopUp => Driver.FindElement(By.XPath("//*[@id='paymentModel']/div/div/div/button"));
        public IWebElement DrxtCompleteRequestProcess => Driver.FindElement(By.XPath("//li[contains(text(), 'Complete Request Process')]"));




        public void CheckWalletBalance()
        {
            Thread.Sleep(7000);
            string value = lnkWalletBalance.Text.ToString();
            value = value.Substring(1);
            string value1 = lnkGrandTotal.Text.ToString();
            value1 = value1.Substring(1);

            var intvalue = Convert.ToDouble(value);
            var intvalue1 = Convert.ToDouble(value1);

            if (intvalue >= intvalue1)
            {
                SelectPayNowButton();
            }
            else
            {
                try
                {
                    SelectPayNowButton();

                    SelectPaymentMethodPage selectPayment = new SelectPaymentMethodPage(Driver);
                    selectPayment.SelectPaypalPaymentMethod();
                    selectPayment.ClickPaynowPaymentMehtod();

                    Paypalpage paypalpage = new Paypalpage(Driver);

                    paypalpage.EnterCredentials_Paypal();
                    paypalpage.ClickPaynow_PayPal();
                }
                catch (Exception)
                {
                    Console.WriteLine("PayNow functionality is not working");
                    Driver.Quit();
                }
              
            }
          
        }

        public void CheckWalletAmount()
        {
            string walletAmount = lnkWalletBalance.Text.ToString();
            walletAmount = walletAmount.Substring(1);

            var intWalletAmount = Convert.ToDouble(walletAmount);
            Thread.Sleep(3000);
          
            string value1 = lnkGrandTotal.Text.ToString();
            value1 = value1.Substring(1);

            
            var intvalue1 = Convert.ToDouble(value1);

            if (intWalletAmount >= intvalue1)
            {
                SelectPayNowButton();
            }

            else
            {
                closePaymentDetailsPopUp.Click();
                MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(Driver);               
                medNavigatorPage.ClickMyWallet();
                MyWalletPage walletPage = new MyWalletPage(Driver);
                var walletAmt = walletPage.EnterWalletAmount(Driver, 4);

                SelectPaymentMethodPage selectPayment = new SelectPaymentMethodPage(Driver);
                selectPayment.CheckProcessingFee();
                selectPayment.SelectPaypalPaymentMethod();
                selectPayment.ClickPaynowPaymentMehtod();


                Paypalpage paypalpage = new Paypalpage(Driver);

                paypalpage.EnterCredentials_Paypal();
                paypalpage.ClickPaynow_PayPal();
                Thread.Sleep(10000);
            }


        }
        public void WalletTransactionContinue()              
        
        {
            try
            {
                DrxtCompleteRequestProcess.Displayed.ToString();
            }
            catch (Exception)
            {              

                IJavaScriptExecutor js2 = (IJavaScriptExecutor)Driver;
                System.Threading.Thread.Sleep(1000);
                js2.ExecuteScript("window.scrollTo(800,0)");
                MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(Driver);
               
                medNavigatorPage.ClickSearchPhysician();
                medNavigatorPage.ClickSearchButton();
                medNavigatorPage.SelectUser();
                medNavigatorPage.SelectActionProcess();
            }
        }










        public void SelectAvailableCode()
        {
            lnkSelectAvailableCode.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void SelectPayNowButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            lnkPaynowButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void SelectCancelButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            lnkCancelButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }












    }
}
