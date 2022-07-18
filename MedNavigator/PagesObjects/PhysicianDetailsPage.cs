using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class PhysicianDetailsPage
    {

        public PhysicianDetailsPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }


        public IWebElement btnSelect => Driver.FindElement(By.XPath("//a[@class='btn select-record reset-btn mT20']"));
        public IWebElement btnSelectNext => Driver.FindElement(By.XPath("//a[@class='btn pagination-button reset-btn mT20 next-btn']"));
        public IWebElement btnCreateCampaign => Driver.FindElement(By.XPath("//a[@class='btn reset-btn createcampaign mT20']"));
        public IWebElement btnSelectAction => Driver.FindElement(By.XPath("//select[@id='mass-action']"));
        public IWebElement btnGo => Driver.FindElement(By.XPath("//button[@id='mass-action-apply-btn']"));





        public void selectCandidate()
        {
            btnSelect.Click();Thread.Sleep(5000);
            btnSelectNext.Click(); btnSelect.Click(); Thread.Sleep(5000);
            btnSelectNext.Click(); btnSelect.Click(); Thread.Sleep(5000);
        }

        public void CreateCampaign()
        {
            btnCreateCampaign.Click();
            btnSelectAction.Click();
            SelectElement selectOptions = new SelectElement(btnSelectAction);
            selectOptions.SelectByText("Email Campaign");
            btnGo.Click();  
        }


    }
}
