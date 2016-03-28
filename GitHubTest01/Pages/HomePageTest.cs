using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GW_POP_Test01.Pages.UsersAndExtensions
{
    public class HomePageTest
    {
        public readonly IWebDriver driver;

        public HomePageTest(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
        }

        //Element - Field
        [FindsBy(How = How.ClassName, Using = "location")]
        public IWebElement ElementName { get; set; }

        public void Action()
        {

        }
    }
}
