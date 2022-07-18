using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace MedNavigator
{
    public class CreateCampaign
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test2()
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
            EmailID.SendKeys("vidit.test@yopmail.com");
            password.SendKeys("Admin@123");

            IWebElement Login = webDriver.FindElement(By.XPath("//*[@id='form-signin']/div/div/div[2]/div/div[4]/button"));
            Login.Click();     
  

            ////Accept Term Policy Subscription 
            //IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            //System.Threading.Thread.Sleep(1000);
            //js.ExecuteScript("window.scrollTo(0,1500)");

            //IWebElement termsAndConditions = webDriver.FindElement(By.XPath("//input[@id='privacy_policy']"));
            //termsAndConditions.Click();
            //IWebElement acceptTermAndPolicy = webDriver.FindElement(By.XPath("//input[@id='sub']"));
            //acceptTermAndPolicy.Click();      


            //Create Campaign 
            IWebElement searchDropDown = webDriver.FindElement(By.XPath("//a[@href ='javascript:void(0);']"));
            searchDropDown.Click();
          IWebElement selectPhysician = webDriver.FindElement(By.XPath("//li//a[@href ='https://dev.mednavigator.com/search/results/physicians/allopathic-osteopathic-physicians']"));
            selectPhysician.Click();
         
            System.Threading.Thread.Sleep(15000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollTo(0,800)");

           // IWebElement SpecialityDropDown = webDriver.FindElement(By.XPath("//*[@id='searchForm']/div[5]/div/div"));
           // SpecialityDropDown.Click();
           // IWebElement selectSpecialityDropDown = webDriver.FindElement(By.XPath("/html/body/div[14]/div/div[2]/ul/li[1]"));
           // selectSpecialityDropDown.Click();
           //// SelectElement selectSpecialityOption = new SelectElement(selectSpecialityDropDown);
           // //selectSpecialityOption.SelectByText("Allergy & Immunology (4844)");


            IWebElement search = webDriver.FindElement(By.XPath("//*[@id='searchForm']/div[19]/button[2]"));
            search.Click();
            System.Threading.Thread.Sleep(15000);

            IWebElement selectAllOption = webDriver.FindElement(By.XPath("//*[@id='dataTable']/tbody/tr[2]/td[1]/input"));
            selectAllOption.Click();

            IWebElement selectAction = webDriver.FindElement(By.XPath("//select[@id='mass-action']"));
            selectAction.Click();
            SelectElement selectOptions = new SelectElement(selectAction);
            selectOptions.SelectByText("Email Campaign");

            IWebElement clickGoButton = webDriver.FindElement(By.XPath("//button[@id='mass-action-apply-btn']"));
            clickGoButton.Click();

            System.Threading.Thread.Sleep(5000);


            IJavaScriptExecutor js1 = (IJavaScriptExecutor)webDriver;
            System.Threading.Thread.Sleep(1000);
            js1.ExecuteScript("window.scrollTo(0,1500)");

            IWebElement payNowButton = webDriver.FindElement(By.XPath("//button[@id='request-pay-now-btn']"));
            payNowButton.Click();


            //try
            //{
            //    Boolean completeRequestProcessIsDisplayed = webDriver.FindElement(By.XPath("//*[@id='crumbs']/ol/li[2]")).Displayed;
            //    IWebElement templateType = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[1]/div/input[1]"));
            //    templateType.Click();
            //    IWebElement selectTemplateType = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[1]/div/div[2]/ul/li[1]/a"));
            //    selectTemplateType.Click();

            //    IWebElement templateTypeCampaign = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[2]/div/input[1]"));
            //    templateTypeCampaign.Click();
            //    IWebElement templateTypeName = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[2]/div/div[2]/ul/li[1]/a"));
            //    templateTypeName.Click();
            //    IWebElement enterTemplateName = webDriver.FindElement(By.XPath("//*[@id='searchForm1']/div[2]/input[1]"));
            //    enterTemplateName.SendKeys("test123");
            //}
          //  catch (Exception ex)
            //{
                //Paypal Transaction 

                IJavaScriptExecutor js2 = (IJavaScriptExecutor)webDriver;
                System.Threading.Thread.Sleep(1000);
                js2.ExecuteScript("window.scrollTo(0,500)");

                IWebElement paypalpayNow = webDriver.FindElement(By.XPath("//button[@id='request-pay-now-btn']"));
                paypalpayNow.Click();
                IWebElement emailAdressPaypal = webDriver.FindElement(By.XPath("//input[@id='email']"));
                emailAdressPaypal.SendKeys("vijay.kansal-buyer@gmail.com");
                IWebElement nextButtonPayPal = webDriver.FindElement(By.XPath("//button[@id='btnNext']"));
                nextButtonPayPal.Click();
                System.Threading.Thread.Sleep(1000);
                IWebElement enterPaypalPassword = webDriver.FindElement(By.XPath("//input[@id='password']"));
                enterPaypalPassword.SendKeys("admin123");

                IJavaScriptExecutor js5 = (IJavaScriptExecutor)webDriver;
                System.Threading.Thread.Sleep(1000);
                js5.ExecuteScript("window.scrollTo(0,500)");


                IWebElement loginPayPal = webDriver.FindElement(By.XPath("//button[@id='btnLogin']"));
                loginPayPal.Click();
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)webDriver;
                System.Threading.Thread.Sleep(1000);
                js3.ExecuteScript("window.scrollTo(0,1000)");

                IWebElement payNowPayPal = webDriver.FindElement(By.XPath("//button[@id='payment-submit-btn']"));
                payNowPayPal.Click();
                System.Threading.Thread.Sleep(20000);
            //  }




            ////Paypal Transaction 

            //IJavaScriptExecutor js2 = (IJavaScriptExecutor)webDriver;
            //System.Threading.Thread.Sleep(1000);
            //js2.ExecuteScript("window.scrollTo(0,500)");

            //IWebElement paypalpayNow = webDriver.FindElement(By.XPath("//button[@id='request-pay-now-btn']"));
            //paypalpayNow.Click();





            //IWebElement emailAdressPaypal = webDriver.FindElement(By.XPath("//input[@id='email']"));
            //emailAdressPaypal.SendKeys("vijay.kansal-buyer@gmail.com");
            //IWebElement nextButtonPayPal = webDriver.FindElement(By.XPath("//button[@id='btnNext']"));
            //nextButtonPayPal.Click();
            //System.Threading.Thread.Sleep(1000);
            //IWebElement enterPaypalPassword = webDriver.FindElement(By.XPath("//input[@id='password']"));
            //enterPaypalPassword.SendKeys("admin123");
            //IWebElement loginPayPal = webDriver.FindElement(By.XPath("//button[@id='btnLogin']"));
            //loginPayPal.Click();

            //IJavaScriptExecutor js3 = (IJavaScriptExecutor)webDriver;
            //System.Threading.Thread.Sleep(1000);
            //js3.ExecuteScript("window.scrollTo(0,1000)");

            //IWebElement payNowPayPal = webDriver.FindElement(By.XPath("//button[@id='payment-submit-btn']"));
            //payNowPayPal.Click();



            //Template Selection
            IWebElement templateType = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[1]/div/input[1]"));
            templateType.Click();
            IWebElement selectTemplateType = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[1]/div/div[2]/ul/li[1]/a"));
            selectTemplateType.Click();

            IWebElement templateTypeCampaign = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[2]/div/input[1]"));
            templateTypeCampaign.Click();
            IWebElement templateTypeName = webDriver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[2]/div/div[2]/ul/li[1]/a"));
            templateTypeName.Click();





            IWebElement enterTemplateName = webDriver.FindElement(By.XPath("//*[@id='searchForm1']/div[2]/input[1]"));
            enterTemplateName.SendKeys("test123");
            System.Threading.Thread.Sleep(20000);
            IJavaScriptExecutor js4 = (IJavaScriptExecutor)webDriver;
            js4.ExecuteScript("window.scrollTo(0,1200)");

            IWebElement sendCampaign = webDriver.FindElement(By.XPath("//*[@id='searchForm1']/div[5]/button[2]"));
            sendCampaign.Click();



            //Logout
            System.Threading.Thread.Sleep(15000);

            IWebElement accountDropDown = webDriver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/a"));
            accountDropDown.Click();
            IWebElement logoutButton = webDriver.FindElement(By.XPath("//a[@href ='https://dev.mednavigator.com/logout']"));
            logoutButton.Click();
          

            webDriver.Quit();


        }
    }
}
