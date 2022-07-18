//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MedNavigator.PagesObjects
//{
//    public class AdminPage
//    {

//        public AdminPage(IWebDriver webDriver)
//        {
//            Driver = webDriver;
//        }

//        public IWebDriver Driver { get; }


//        public IWebElement btnSearch => Driver.FindElement(By.XPath("//*[@id='searchFormPrograms']/div[7]/button[1]"));
//        public IWebElement btnReset => Driver.FindElement(By.XPath("//*[@id='searchFormPrograms']/div[7]/button[2]"));
//        public IWebElement programDropDown => Driver.FindElement(By.XPath("//*[@id='searchFormPrograms']/div[2]/div/input[1]"));
//        public IWebElement programNumber => Driver.FindElement(By.XPath("//*[@id='searchFormPrograms']/div[2]/div/input[1]"));
//        public IWebElement stateDropDown => Driver.FindElement(By.XPath("//*[@id='searchFormPrograms']/div[4]/div/input[1]"));
//        public IWebElement statusDropDown => Driver.FindElement(By.XPath("//*[@id='searchFormPrograms']/div[5]/div/input[1]"));
//        public IWebElement addCandidateTab => Driver.FindElement(By.XPath(" //*[@id='navbar-collapse-1']/ul/li[2]/a"));


//        public void PerformHomeFunctionality()
//        {
//            programDropDown.Click();
//            Thread.Sleep(3000);
//            programNumber.Click();
//            Thread.Sleep(3000);
//            stateDropDown.Click();
//            Thread.Sleep(3000);
//            statusDropDown.Click();
//            Thread.Sleep(3000);
//            btnSearch.Click();
//            Thread.Sleep(3000);
//            btnReset.Click();
//            Thread.Sleep(3000);
//        }

//        public void AddCandidate()
//        {
//            addCandidateTab.Click();
//                Driver.SwitchTo().Window(actual);
//        }




//}
//}
