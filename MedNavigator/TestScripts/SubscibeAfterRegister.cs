using MedNavigator.PagesObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.TestScripts
{
    public class SubscribeAfterRegister
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void SetupURL()
        {
            URLPage url = new URLPage(webDriver);
            url.OpenURL();
        }


        [Test]
        public void Subscribe_Register()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.EnterCredentials();

            MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(webDriver);
            medNavigatorPage.ClickMySubscriptiontab();

            MySubscriptionPage subscriptionPage = new MySubscriptionPage(webDriver);
            subscriptionPage.SelectPaymentTerm();


            SelectPaymentMethodPage selectpaymentMethod = new SelectPaymentMethodPage(webDriver);
            selectpaymentMethod.SelectContinueButton();

            Paypalpage paypalpage = new Paypalpage(webDriver);
            paypalpage.EnterCredentials_Paypal();
            paypalpage.AgreeandSubscribe();
           


            
            medNavigatorPage.ClickLogout();



        }
    }
}