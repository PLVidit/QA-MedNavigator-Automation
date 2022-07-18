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
    public class Subscribe
    {       
            IWebDriver webDriver = new ChromeDriver();

            [SetUp]
        public void SetupURL()
        {
            URLPage url = new URLPage(webDriver);
            url.OpenURL();
        }   


        [Test]
        public void WalletAdd()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.EnterCredentials();

            SubscribePage subscribePage = new SubscribePage(webDriver);
            subscribePage.SelectPayment();
            subscribePage.clickPayNow();

            SelectPaymentMethodPage selectpaymentMethod = new SelectPaymentMethodPage(webDriver);
            selectpaymentMethod.SelectContinueButton();

            Paypalpage paypalpage = new Paypalpage(webDriver);
            paypalpage.AgreeandSubscribe();
            paypalpage.EnterCredentials_Paypal();
            paypalpage.ClickPaynow_PayPal();


            MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(webDriver);
            medNavigatorPage.ClickLogout();


        }

        }
}
