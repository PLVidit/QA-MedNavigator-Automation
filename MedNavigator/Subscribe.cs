using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace MedNavigator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {          
                //Open Browser
                IWebDriver webDriver = new ChromeDriver();
                webDriver.Navigate().GoToUrl("https://dev.mednavigator.com/");
            
                webDriver.Manage().Window.Maximize();

            //Identify Login 
            IWebElement Login_1 = webDriver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li/a"));
            Login_1.Click();
            IWebElement EmailID = webDriver.FindElement(By.XPath("//*[@id='form-signin']/div/div/div[2]/div/div[1]/input"));
            IWebElement password = webDriver.FindElement(By.XPath("//*[@id='password']"));
            EmailID.SendKeys("prince.test@yopmail.com");
            password.SendKeys("Admin@123");

            IWebElement Login = webDriver.FindElement(By.XPath("//*[@id='form-signin']/div/div/div[2]/div/div[4]/button"));
            Login.Click();


            //Subscription 
            
            IWebElement subscriptionPaymentTerm = webDriver.FindElement(By.XPath("//select[@id='subscription-plan']"));



           // Boolean subscriptionPaymentTermDisplay = webDriver.FindElement(By.XPath("//select[@id='subscription-plan']")).Displayed;
            
                SelectElement subscription = new SelectElement(subscriptionPaymentTerm);
                subscription.SelectByText("Monthly");

                IWebElement payNow = webDriver.FindElement(By.XPath("//*[@id='form-signin']/div[1]/div[2]/div/div[23]/input[2]"));

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                System.Threading.Thread.Sleep(1000);
                js.ExecuteScript("window.scrollTo(0,950)");
                payNow.Click();



                //PayPal transaction
                IWebElement continuePaypalPayment = webDriver.FindElement(By.XPath("//button[@id='select-payment-gateway-button']"));
                continuePaypalPayment.Click();
                System.Threading.Thread.Sleep(10000);
                IWebElement emailAdressPaypal = webDriver.FindElement(By.XPath("//input[@id='email']"));
                emailAdressPaypal.SendKeys("vijay.kansal-buyer@gmail.com");
                IWebElement nextButtonPayPal = webDriver.FindElement(By.XPath("//button[@id='btnNext']"));
                nextButtonPayPal.Click();
                System.Threading.Thread.Sleep(10000);
                IWebElement enterPaypalPassword = webDriver.FindElement(By.XPath("//input[@id='password']"));
                enterPaypalPassword.SendKeys("admin123");
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)webDriver;
                System.Threading.Thread.Sleep(1000);
                js1.ExecuteScript("window.scrollTo(0,1000)");

                IWebElement loginPayPal = webDriver.FindElement(By.XPath("//button[@id='btnLogin']"));
                loginPayPal.Click();

                IJavaScriptExecutor js3 = (IJavaScriptExecutor)webDriver;
                System.Threading.Thread.Sleep(1000);
                js3.ExecuteScript("window.scrollTo(0,1000)");

                IWebElement agreeAndSubscribePayPal = webDriver.FindElement(By.XPath("//input[@id='confirmButtonTop']"));
                agreeAndSubscribePayPal.Click();

                System.Threading.Thread.Sleep(10000);



            
               
            

            webDriver.Quit();


            //BackEnd AdminPage Work






        }
    }
}