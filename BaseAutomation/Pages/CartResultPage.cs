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
    class CartResultPage : BasePage
    {
        RemoteWebDriver _webDriver;

        public CartResultPage()
        {
            _webDriver = base.webDriver;
        }

        By lbl_cartResultPage = By.ClassName("cart-bucket");

        public void validatePageDetailResult()
        {
            waitForLocator(lbl_cartResultPage);
        }

    }
}
