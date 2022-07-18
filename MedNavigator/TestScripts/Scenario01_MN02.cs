﻿using MedNavigator.PagesObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// </summary>
////Test Case Description - User is able to create camapaign for Advance Practitioners Profile for n number of profiles (Payment through Paypal/Stripe payment)/////
/// </summary>




namespace MedNavigator.TestScripts
{
    public class Scenario01_MN02
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
        public void CampaignCreation()
        {

            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.EnterCredentials();

            MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(webDriver);
            medNavigatorPage.CheckSuccesfullyLogin();
            medNavigatorPage.ClickSearchAdvancedPractioner();
            medNavigatorPage.ClickSearchButton_AdvancedPractioner();
            medNavigatorPage.SelectUser();
            medNavigatorPage.SelectActionProcess();

            PaymentDetailsPage paymentDetails = new PaymentDetailsPage(webDriver);
            paymentDetails.CheckWalletBalance();         
            

            CompleteRequestProcessPage completeRequestPage = new CompleteRequestProcessPage(webDriver);
           
           
            completeRequestPage.SelectMedNavigatorTemplates();
            completeRequestPage.SendCampaign();           

            medNavigatorPage.ClickLogout();

        }
    }
}