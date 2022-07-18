using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class MedNavigatorHomePage
    {
      

        public MedNavigatorHomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement lnkSearchDropDown => Driver.FindElement(By.XPath("//a[@href ='javascript:void(0);']"));     
        public IWebElement lnkSearchPhysician => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[1]/ul/li[1]/a"));
        public IWebElement lnkSearchAdvancedPractioners => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[1]/ul/li[2]/a"));
        public IWebElement lnkSearchGMEPrograms => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[1]/ul/li[3]/a"));
        public IWebElement lnkResidentsAndFellows => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[1]/ul/li[4]/a"));

        public IWebElement lnkMySubscriptionTab => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[2]/a"));

        public IWebElement lnkCampaignTab => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[3]/a"));

        public IWebElement lnkGroupsTab => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[4]/a"));
        public IWebElement lnkEmailDropDown => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[5]/a']"));
        public IWebElement lnkInboxOption => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[5]/ul/li[1]/a"));
        public IWebElement lnkEmailTemplates => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[5]/ul/li[2]/a"));
        public IWebElement lnkAllEmailsSent => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[5]/ul/li[3]/a"));

        public IWebElement lnkAccountstab => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/a"));
        public IWebElement lnkMyWallet => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/ul/li[1]/a"));
        public IWebElement lnkSettings => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/ul/li[2]/a"));
        public IWebElement lnkDashBoard => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/ul/li[3]/a"));
        public IWebElement lnkActionPending => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/ul/li[4]/a"));
        public IWebElement lnkLogOut => Driver.FindElement(By.XPath("//*[@id='navbar-collapse-1']/ul/li[6]/ul/li[5]/a"));
        public IWebElement lnkSearchButton => Driver.FindElement(By.XPath("//*[@id='searchForm']/div[19]/button[2]"));
        public IWebElement lnkSearchButton_AdvancedPractioner => Driver.FindElement(By.XPath("//*[@id='searchForm']/div[18]/button[2]"));
        public IWebElement lnkSearchButton_GME => Driver.FindElement(By.XPath("//*[@id='searchForm']/div[10]/button[2]"));
        public IWebElement lnkSearchButton_ResidentsAndFollows => Driver.FindElement(By.XPath("//*[@id='searchForm']/div[15]/button[2]"));
        public IWebElement lnkSelectCredential_1 => Driver.FindElement(By.XPath("//*[@id='dataTable']/tbody/tr[1]/td[1]/input"));
        public IWebElement lnkSelectCredential_2 => Driver.FindElement(By.XPath("//*[@id='dataTable']/tbody/tr[2]/td[1]/input"));
        public IWebElement lnkSelectCredential_3 => Driver.FindElement(By.XPath("//*[@id='dataTable']/tbody/tr[3]/td[1]/input"));
        public IWebElement lnkSelectCredential_All => Driver.FindElement(By.XPath("//*[@id='datatable-select-all']"));
        public IWebElement lnkSelectAction => Driver.FindElement(By.XPath("//select[@id='mass-action']"));
        public IWebElement lnkSelectGoButton => Driver.FindElement(By.XPath("//button[@id='mass-action-apply-btn']"));
        public IWebElement lnkValidationMessage  => Driver.FindElement(By.XPath("//*[@id='success_message']"));
        public IWebElement btnDetails => Driver.FindElement(By.XPath("//*[@id='dataTable']/tbody/tr[1]/td[12]/div/a/i"));








        //Methods 
        public void ClickDetails()
        {
            Thread.Sleep(5000);
            btnDetails.Click();
            Thread.Sleep(10000);

        }





        public void ClickSearchDropDown()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            lnkSearchDropDown.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);                
        }

        public void ClickSearchPhysician()
        {          
            
            ClickSearchDropDown();          
            try
            {
                lnkSearchPhysician.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Console.WriteLine("Physician Record is opened");

            }
            catch (Exception)
            {
                Console.WriteLine("Physician Record is not opened");
            }
           
        }

        public void ClickSearchAdvancedPractioner()
        {
            ClickSearchDropDown();
            try
            {
                lnkSearchAdvancedPractioners.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Console.WriteLine("Advanced Practioner is opened");
            }
            catch(Exception)
            {
                Console.WriteLine("Advanced Practioner Record is not opened");
            }
           
        }

        public void ClickSearchGMEPrograms()
        {
            ClickSearchDropDown();
            try
            {
                lnkSearchGMEPrograms.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Console.WriteLine("GME Program is opened");
            }
            catch (Exception)
            {
                Console.WriteLine("GMEnRecord is not opened");
            }
        }

        public void ClickSearchResidentsAndFellows()
        {
            ClickSearchDropDown();
            try
            {
                lnkResidentsAndFellows.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
            catch (Exception )
            {
                Console.WriteLine("Residents and Follows is not opened ");
            }
           
        }

        public void ClickMySubscriptiontab()
        { 
            try
            {
                lnkMySubscriptionTab.Click();
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("window.scrollTo(1500,0)");
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch(Exception)
            {
                Console.WriteLine("MySubscription Page is not opened ");
            }
           
        }

        public void ClickCampaignsTab()
        {
            try
            {
                lnkCampaignTab.Click();
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("window.scrollTo(1500,0)");
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch(Exception)
            {
                Console.WriteLine("Campaigns Page is not opened ");
            }
        }

        public void ClickGroupsTab()
        {
            try
            {
                lnkGroupsTab.Click();
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("window.scrollTo(1500,0)");
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch( Exception )
            {
                Console.WriteLine("Groups Page is not opened");
            }
           
        }

        public void ClickEmailDropdown()
        {
            lnkEmailDropDown.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void ClickEmailTeamplates()
        {
            ClickEmailDropdown();
            lnkEmailTemplates.Click();
        }

        public void ClickSentEmail()
        {
            try
            {
                ClickEmailDropdown();
                lnkAllEmailsSent.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Console.WriteLine("Email Is opened ");
            }
            catch (Exception)
            {
                Console.WriteLine("Email is not opened ");
            }
           
        }


        public void ClickAccountTab()
        {
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(1500,0)");
            Thread.Sleep(3000);
            lnkAccountstab.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public void ClickMyWallet()
        {
            ClickAccountTab();
            lnkMyWallet.Click();
        }

        public void ClickSettings()
        {
            ClickAccountTab();
            lnkSettings.Click();
        }

        public void ClickDashBoard()
        {
            ClickAccountTab();
            lnkDashBoard.Click();
        }

        public void ActionPending()
        {
            ClickAccountTab();
            lnkActionPending.Click();
        }

        public void ClickLogout()
        {
            Thread.Sleep(3000);
            ClickAccountTab();
            Thread.Sleep(3000);
            lnkLogOut.Click();
            Driver.Quit();
        }

        public void ClickSearchButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            lnkSearchButton.Click();          
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public void ClickSearchButton_AdvancedPractioner()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            lnkSearchButton_AdvancedPractioner.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public void ClickSearchButton_GME()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            lnkSearchButton_GME.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public void ClickSearchButton_ResidentsAndFollows()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            lnkSearchButton_ResidentsAndFollows.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public   void SelectUser()
        {       
            Thread.Sleep(30000);  
            lnkSelectCredential_1.Click();
            lnkSelectCredential_2.Click();
            lnkSelectCredential_3.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void SelectAllUser()
        {
            lnkSelectCredential_1.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void SelectActionProcess()
        {
            lnkSelectAction.Click();
            SelectElement selectOptions = new SelectElement(lnkSelectAction);
            selectOptions.SelectByText("Email Campaign");
            lnkSelectGoButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void CheckSuccesfullyLogin()
        {
            // IAlert alert = (IAlert)Driver;
            // Assert.That(alert.Text, Does.Match("Logged in successfully."));
            try
            {
                Assert.AreEqual(lnkValidationMessage.Text, "Logged in successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Username/Password. Please Try Again", ex);
                Driver.Quit();
            }          

        }
        public void SelectInbox()
        {
            lnkInboxOption.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
        }
        public void SelectEmailTemplates()
        {
            lnkEmailTemplates.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void SelectSentEmails()
        {
            lnkAllEmailsSent.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }



        
        //public IWebElement text => Driver.FindElement(By.XPath("//input[@id='login']"));

        //public void t()
        //{
        //    text.SendKeys("aaa");
        //}









    }
}
