using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class MySubscriptionPage
    {
        public MySubscriptionPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement btnStartDate => Driver.FindElement(By.XPath("//input[@name='start_date']"));
        public IWebElement btnEndDate => Driver.FindElement(By.XPath("//input[@name='end_date']"));
        public IWebElement btnPreviousDateIcon => Driver.FindElement(By.XPath("/html/body/div[8]/div[1]/table/thead/tr[1]/th[1]"));
        public IWebElement selectStartDates => Driver.FindElement(By.XPath("/html/body/div[8]/div[1]/table/tbody/tr[1]/td[4]"));
        public IWebElement selectStatusSubscription => Driver.FindElement(By.XPath("//*[@id='orderSearchForm']/div/div[3]/div/input[1]"));
        public IWebElement btnReset => Driver.FindElement(By.XPath("//*[@id='orderSearchForm']/div/div[7]/button[1]"));
        public IWebElement btnDetailsIcon => Driver.FindElement( By.XPath("//i[@class='fa fa-info-circle circle-icon']"));
        public IWebElement btnHistoryIcon => Driver.FindElement(By.XPath("//i[@class='fa fa-history-circle circle-icon']"));
        public IWebElement btnTransIcon => Driver.FindElement(By.XPath("//i[@class='fa fa-usd-view-trans']"));
        public IWebElement selectCompleteStatus => Driver.FindElement(By.XPath("//*[@id='orderSearchForm']/div/div[3]/div/div[2]/ul/li[1]/a"));
        public IWebElement btnSearch_MySubscription => Driver.FindElement(By.XPath("//*[@id='orderSearchForm']/div/div[7]/button[2]"));
        public IWebElement btn_Subscribe => Driver.FindElement(By.XPath("//a[@id='subscribe-btn-id']"));
        public IWebElement subscriptionPaymentTerm => Driver.FindElement(By.XPath("//select[@id='subscription-plan']"));
        public IWebElement payNow => Driver.FindElement(By.XPath("//*[@id='form-signin']/div/div[2]/div[7]/a[1]"));
        public void SelectStartDate()
        {
            Thread.Sleep(3000);
            btnStartDate.Click();
            btnPreviousDateIcon.Click();
            selectStartDates.Click();
         
        }
        public void SelectPaymentTerm()
        {
            btn_Subscribe.Click();
            SelectElement subscription = new SelectElement(subscriptionPaymentTerm);
            subscription.SelectByText("Monthly");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            Thread.Sleep(3000);
            payNow.Click();
        }


        public void selectStatus()
        {
            Thread.Sleep(3000);
            selectStatusSubscription.Click();
            selectCompleteStatus.Click();
        }

        public void ClickResetButton()
        {
            Thread.Sleep(3000);
            btnReset.Click();
            string value = selectStatusSubscription.Text;
            string value1 = btnStartDate.Text;



            if (value.Contains("") && value1.Contains(""))
                {
                Console.WriteLine("Field is Empty");
            }
        }
        public void ClickSearchButton()
        {
            btnSearch_MySubscription.Click();
        }








    }
}
