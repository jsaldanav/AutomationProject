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
    class SearchItemPage : BasePage
    {
        #region Base Page Configuration
        RemoteWebDriver _webDriver;
        public SearchItemPage()
        {
            _webDriver = base.webDriver;
        }
        #endregion

        #region Page Selectors
        By TXT_SEARCHBOX = By.Name("_nkw");
        By BTN_SEARCH = By.Id("gh-btn");
        #endregion

        #region Page Methods
        public void goPage(string url)
        {
            Navigate(url);
        }

        public void inputSearchText(string text)
        {
            SendKeysOn(TXT_SEARCHBOX, text);
        }

        public void clickOnSearchButton()
        {
            ClickOn(BTN_SEARCH);
        }
        #endregion
    }
}
