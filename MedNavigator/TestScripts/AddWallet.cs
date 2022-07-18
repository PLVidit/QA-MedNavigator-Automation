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
    public class AddWallet 
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]

        public void SetupURL()
        {
        URLPage url = new URLPage(webDriver);
        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        webDriver.Navigate().GoToUrl("https://dev.mednavigator.com/");
        webDriver.Manage().Window.Maximize();
        }
      

        [Test]
        public void WalletAdd()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.EnterCredentials();

            MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(webDriver);
            medNavigatorPage.CheckSuccesfullyLogin();
            medNavigatorPage.ClickMyWallet();

            MyWalletPage walletPage = new MyWalletPage(webDriver);          

           var walletAmt =  walletPage.EnterWalletAmount(webDriver,4);

            SelectPaymentMethodPage selectPayment = new SelectPaymentMethodPage(webDriver);
            selectPayment.CheckProcessingFee();
            selectPayment.SelectPaypalPaymentMethod();
            selectPayment.ClickPaynowPaymentMehtod();


            Paypalpage paypalpage = new Paypalpage(webDriver);

            paypalpage.EnterCredentials_Paypal();
            paypalpage.ClickPaynow_PayPal();

           // walletPage.validateWalletAmount(webDriver, walletAmount);
            walletPage.CheckWalletAmount(walletAmt);
            medNavigatorPage.ClickLogout();














        }
    }
}
