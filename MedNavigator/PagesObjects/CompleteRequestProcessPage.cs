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
    public class CompleteRequestProcessPage
    {

        public CompleteRequestProcessPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }


        public IWebElement chkEnableEchoCampaign => Driver.FindElement(By.XPath("//input[@id='campaign_type']"));
        public IWebElement lnkEchoCampaignDaysSelection => Driver.FindElement(By.XPath("//select[@name='echo_day']"));
        public IWebElement select_templateTypeCampaign=> Driver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[1]/div/input[1]"));
        public IWebElement select_MednavigatorTemplate_TemplateType => Driver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[1]/div/div[2]/ul/li[1]/a"));
        public IWebElement select_templateCampaign => Driver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[2]/div/input[1]"));
        public IWebElement select_PreDefinedAdvance => Driver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[3]/div[2]/div/div[2]/ul/li[1]/a"));
        public IWebElement btnCreateNewTemplate => Driver.FindElement(By.XPath("//a[@class='btn btn-orange-new create-new-template']"));
        public IWebElement lnkTemplateName => Driver.FindElement(By.XPath("//input[@name='template_name']"));
        public IWebElement lnkSubjectLine => Driver.FindElement(By.XPath("//input[@name='template_heading']"));
        public IWebElement btnSaveButton => Driver.FindElement(By.XPath("//*[@id='searchForm1']/div[5]/button[1]"));
        public IWebElement btnSendCampaign => Driver.FindElement(By.XPath("//*[@id='searchForm1']/div[5]/button[2]"));
        public IWebElement btnSceduleCampaign => Driver.FindElement(By.XPath("//*[@id='searchForm1']/div[5]/button[3]"));
        public IWebElement btnSendTestEmail => Driver.FindElement(By.XPath("//*[@id='searchForm1']/div[5]/a"));
        public IWebElement btnCalender => Driver.FindElement(By.XPath("//span[@class='k-icon k-i-calendar']"));
        public IWebElement btnDateSelect => Driver.FindElement(By.XPath("//div[@id='datetimepicker_dateview']//div//tr[3]//td[6]//a"));
        public IWebElement btnScheduledCampaign_1 => Driver.FindElement(By.XPath("//*[@id='sheduleModal']/div/div/div[2]/div/div/div[2]/button[1]"));
        public IWebElement btnCancelScheduleCampaign => Driver.FindElement(By.XPath("//button[@class='btn btn-orange-new cancel']"));
        public IWebElement selectEcho_3Day => Driver.FindElement(By.XPath("//*[@id='submit-select-templ-frm']/div[1]/select/option[1]"));

        public IWebElement echoDisabled => Driver.FindElement(By.XPath("//select[@name='echo_day']"));

        public void DisableEchoCampaign()
        {
            Thread.Sleep(3000);
            chkEnableEchoCampaign.Click();
            if (echoDisabled.Enabled)
            {
                Console.WriteLine("Echo is enabled");
            }
            else
            {
                Console.WriteLine("Echo is not enabled");
            }
            


        }

        public void SelectEchoCampaignDays_3()
        {
            Thread.Sleep(15000);
            lnkEchoCampaignDaysSelection.Click();
            selectEcho_3Day.Click();
        }


        public void SelectMedNavigatorTemplates()
        {
            select_templateTypeCampaign.Click();
            Thread.Sleep(2000);
            select_MednavigatorTemplate_TemplateType.Click();
            Thread.Sleep(2000);
            select_templateCampaign.Click();
            select_PreDefinedAdvance.Click();
            lnkTemplateName.SendKeys("Test123");
            lnkSubjectLine.SendKeys("Test321");
        }


        public void SaveTemplate()
        {
            btnSaveButton.Click();
        }
        public void SendCampaign()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1500)");
            btnSendCampaign.Click();
        }
        public void ScheduleCampaign()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,10000)");
            btnSceduleCampaign.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            btnCalender.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            btnDateSelect.Click();

            btnScheduledCampaign_1.Click();
            Thread.Sleep(3000);
        }

        public void CancelScheduleCampign()
        {
            btnCancelScheduleCampaign.Click();
        }

        public void SendTestmail()
        {
            btnSendTestEmail.Click();
        }

        public void CreateNewTemplate()
        {
            btnCreateNewTemplate.Click();
        }

    }
}
