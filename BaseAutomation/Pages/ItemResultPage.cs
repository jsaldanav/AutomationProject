using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAutomation.Pages
{
    class ItemResultPage : BasePage
    {
        RemoteWebDriver _webDriver;
        public ItemResultPage()
        {
            _webDriver = base.webDriver;
        }


        By txt_result = By.ClassName("srp-results");

        By txt_hypervinculo1 = By.Id("srp-river-results-listing1");

        By txt_hypervinculo2 = By.Id("srp-river-results-listing2");


        public void clickFirstItem()
        {
            ClickOn(txt_hypervinculo1);
        }
        public void clickSecondItem()
        {
            ClickOn(txt_hypervinculo2);
        }

        public void validatePageResult()
        {
            waitForLocator(txt_result);
        }



    }
}
