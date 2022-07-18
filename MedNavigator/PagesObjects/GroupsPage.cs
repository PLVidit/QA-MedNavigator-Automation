using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class GroupsPage
    {
        public GroupsPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement selectDataBase => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[1]/div/input[1]"));
        public IWebElement selectDataBase_Physician => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[1]/div/div[2]/ul/li[1]/a"));
        public IWebElement selectDataBase_GME => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[1]/div/div[2]/ul/li[3]/a"));
        public IWebElement selectDataBase_AdvancedPractioner => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[1]/div/div[2]/ul/li[2]/a"));
        public IWebElement selectDataBase_ResidentsAndFollows => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[1]/div/div[2]/ul/li[4]/a"));
        public IWebElement selectStatus_Groups => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[2]/div/div/input[1]"));
        public IWebElement selectActiveStatus_Groups => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[2]/div/div/div[2]/ul/li[1]/a"));
        public IWebElement selectInActiveStatus_Groups => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[2]/div/div/div[2]/ul/li[2]/a"));
        public IWebElement enterGroupName => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[3]/input"));
        public IWebElement btnReset_Groups => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[6]/button[1]"));
        public IWebElement btnSearch_Groups => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[6]/button[2]"));
        public IWebElement lnkStatus => Driver.FindElement(By.XPath("//*[@id='collectionSearchForm']/div/div[2]/div/div/input[1]"));
       public void ClickDataBase()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectDataBase.Click();
        }


        public void selectDataBasePhysician()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectDataBase_Physician.Click();
        }
        public void selectDataBaseAdvancedPractioner()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectDataBase_AdvancedPractioner.Click();
        }

        public void selectDataBaseGME()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectDataBase_GME.Click();
        }

        public void selectResidentsAndFollows()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectDataBase_ResidentsAndFollows.Click();
        }

        public void EnterGroupName()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            enterGroupName.SendKeys("Test123");
        }

        public void clickStatus()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            lnkStatus.Click();
        }
        public void selectActiveStatus()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectActiveStatus_Groups.Click();
        }

        public void selectInActiveStatus()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            selectInActiveStatus_Groups.Click();
        }

        public void clickSearchButton()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnSearch_Groups.Click();
        }
        public void clickResetButton()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnReset_Groups.Click();
            string value = selectDataBase.Text;
            string value1 = selectStatus_Groups.Text;

            if (value.Contains("") && value1.Contains(""))
            {
                Console.WriteLine(" Groups Field is Empty");
            }
        }









    }
}
