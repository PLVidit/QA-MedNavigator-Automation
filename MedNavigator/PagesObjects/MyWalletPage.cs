using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class MyWalletPage
    {

        public MyWalletPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }



        public IWebElement btnViewAllPromotionalCodes => Driver.FindElement(By.XPath("//a[@id='check_all_coupons']"));
        public IWebElement btnAddFunds => Driver.FindElement(By.XPath("//a[@id='add_funds']"));
        public IWebElement btnAddAmount => Driver.FindElement(By.XPath("//input[@id='addfund_wallet_amount']"));
        public IWebElement btnAddFunds_ToWallet => Driver.FindElement(By.XPath("//button[@class='btn btn-orange-new']"));
        public IWebElement btnViewAvailableRefunds => Driver.FindElement(By.XPath("//a[@id='check_refunds']"));
        public IWebElement selectCredit_Debit => Driver.FindElement(By.XPath("//*[@id='transForm']/div/div[2]/div/input[1]"));
        public IWebElement selectPaymentMethod => Driver.FindElement( By.XPath("//*[@id='transForm']/div/div[3]/div/input[1]"));
        public IWebElement selecttransactionType => Driver.FindElement(By.XPath("//*[@id='transForm']/div/div[4]/div/input[1]"));
        public IWebElement selectCampaignID => Driver.FindElement(By.XPath("//*[@id='requestId']"));
        public IWebElement btnReset_MyWallet => Driver.FindElement(By.XPath("//*[@id='transForm']/div/div[8]/button[1]"));
        public IWebElement btnSearchButton_MyWallet => Driver.FindElement(By.XPath("//*[@id='transForm']/div/div[8]/button[2]"));
        public IWebElement validateWalletAmount => Driver.FindElement(By.XPath("//div[@class='green-wallet-bg balance-icon']/h4"));    


        
       

        

        public void ClickSearchWallet()
        {
            btnSearchButton_MyWallet.Click();
        }
        public void ClickResetWallet()
        {
            btnReset_MyWallet.Click();
        }

        public void ViewAvailableRefunds()
        {
            btnViewAvailableRefunds.Click();
        }
        public void ViewAllPromotionalCode()
        {
            btnViewAllPromotionalCodes.Click();
        }

       
        public  double EnterWalletAmount(IWebDriver Driver, double value)
        {
            //string s1 = validateWalletAmount.ToString();
            // s1 = s1.Substring(1);
            Thread.Sleep(7000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(1500,0)");


            string value1 = validateWalletAmount.Text.ToString();
            value1 = value1.Substring(1);

            Thread.Sleep(7000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            btnAddFunds.Click();
            btnAddAmount.SendKeys(value.ToString());
            btnAddFunds_ToWallet.Click();
            return Convert.ToDouble(value1) + value;
           
        }

       
        public void CheckWalletAmount( double walAmt)
        {
            Thread.Sleep(13000);
            //  string value = validate_AfterWalletAmount.Text.ToString();
            string value = validateWalletAmount.Text.ToString();
            value = value.Substring(1);

           var result = Convert.ToDouble(value);        


            if (walAmt == result)
            {
                Console.WriteLine("The wallet amount added is:" + value);
            }
            else
            {
                Console.WriteLine("Wallet amount is not added");
            }
         

          

        }









    }
}


