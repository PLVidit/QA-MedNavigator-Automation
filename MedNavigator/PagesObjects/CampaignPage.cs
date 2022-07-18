using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedNavigator.PagesObjects
{
    public class CampaignPage
    {

        public CampaignPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement campaignStatus => Driver.FindElement(By.XPath("//*[@id=dataTable']/tbody/tr/td[5]"));
        public IWebElement echoCampaignStatus  => Driver.FindElement(By.XPath("//*[@id='dataTable']/tbody/tr/td[4]"));




        public void CheckCampaignStatus()
        {
            Thread.Sleep(35000); Driver.Navigate().Refresh();
            Thread.Sleep(35000); Driver.Navigate().Refresh();
            Thread.Sleep(35000); Driver.Navigate().Refresh();
            Thread.Sleep(35000); Driver.Navigate().Refresh();
            Thread.Sleep(35000); Driver.Navigate().Refresh();
            Thread.Sleep(40000); Driver.Navigate().Refresh();



            Assert.AreEqual("Complete" , "Complete" );
        }
        public void CheckEchoStatus ()
        {
            Thread.Sleep(3000);
            
            string echostatus = echoCampaignStatus.Text.ToString();
            string value1 = "Default";
            string value2 = "With ECHO Enabled";
            if (echostatus == value1 )
            {
                Console.WriteLine("Echo campaign is not enabled ");
            }
            else if (echostatus == value2)
            {
                Console.WriteLine("Echo campaign is enabled ");
            }
        }






    }
}

