using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using GitHubTest01.Pages;
using GitHubTest01.Init;

namespace GitHubTest01.Init
{
    class Init
    {
        public void GoToHomePage(IWebDriver driver)
        {
            HomePage _homePage = new HomePage(driver);

            _homePage.GoTo();
            _homePage.MaxWin();
            //new line 1
        }

        public void FinishTest(IWebDriver driver)
        {
            HomePage _homePage = new HomePage(driver);

            driver.Quit();
        }
    }
}
