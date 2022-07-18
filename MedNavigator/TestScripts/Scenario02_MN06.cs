using MedNavigator.PagesObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// </summary>
////Test Case Description - send test mail to himself////
/// </summary>



namespace MedNavigator.TestScripts
{
    public class Scenario02_MN06
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
        public void EchoCampaign_04()
        {

            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.EnterCredentials();

            MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(webDriver);
            medNavigatorPage.CheckSuccesfullyLogin();
            medNavigatorPage.ClickSearchPhysician();
            medNavigatorPage.ClickSearchButton();
            medNavigatorPage.SelectUser();
            medNavigatorPage.SelectActionProcess();

            PaymentDetailsPage paymentDetails = new PaymentDetailsPage(webDriver);

            paymentDetails.CheckWalletBalance();


            CompleteRequestProcessPage completeRequestPage = new CompleteRequestProcessPage(webDriver);

            completeRequestPage.DisableEchoCampaign();

            completeRequestPage.SelectMedNavigatorTemplates();
            completeRequestPage.SendCampaign();

            CampaignPage campaignPage = new CampaignPage(webDriver);
            campaignPage.CheckEchoStatus();

            medNavigatorPage.ClickLogout();

        }

    }
}