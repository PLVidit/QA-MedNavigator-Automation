using MedNavigator.PagesObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.TestScripts
{
    public class PageValidation
    {

        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void SetupURL()
        {
            URLPage url = new URLPage(webDriver);
            url.OpenURL();
        }


        [Test]
        public void pageValidation()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.EnterCredentials();

            MedNavigatorHomePage medNavigatorPage = new MedNavigatorHomePage(webDriver);
            medNavigatorPage.ClickSearchPhysician();
            medNavigatorPage.ClickSearchAdvancedPractioner();
            medNavigatorPage.ClickSearchGMEPrograms();
            medNavigatorPage.ClickSearchResidentsAndFellows();

          
           
            medNavigatorPage.ClickMySubscriptiontab();
            MySubscriptionPage subscriptionPage = new MySubscriptionPage(webDriver);
            subscriptionPage.SelectStartDate();
            subscriptionPage.selectStatus();           
            subscriptionPage.ClickSearchButton();
            subscriptionPage.ClickResetButton();

            medNavigatorPage.ClickCampaignsTab();

            Thread.Sleep(3000);
            medNavigatorPage.ClickGroupsTab();
            GroupsPage groupPage = new GroupsPage(webDriver);
            groupPage.ClickDataBase();
            groupPage.selectDataBasePhysician();
            groupPage.clickStatus();
            groupPage.selectActiveStatus();
            groupPage.EnterGroupName();
            groupPage.clickSearchButton();
            groupPage.clickResetButton();

            Thread.Sleep(3000);
            MedNavigatorHomePage medNavigatorPage1 = new MedNavigatorHomePage(webDriver);          
            

            medNavigatorPage.ClickLogout();














        }





    }
}
