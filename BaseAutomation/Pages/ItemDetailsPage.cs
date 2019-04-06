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
    class ItemDetailsPage : BasePage
    {
        RemoteWebDriver _webDriver;

        public ItemDetailsPage()
        {
            _webDriver = base.webDriver;
        }

        string productnameo1;

        By cbx_color = By.Id("msku-sel-1");
        By cbx_zize = By.Id("msku-sel-2");
        By btn_addCart = By.Id("isCartBtn_btn");

        By name = By.ClassName("it-ttl");
        By lbl_resultpage = By.Id("CenterPanelInternal");

        public void selectColor(string color)
        {
            selectComboboxText(cbx_color, color);
            productnameo1 = GetElementText(name);

        }
        public void selectSize(string size)
        {
            selectComboboxText(cbx_zize, size);
        }
        public void addItemToCart()
        {
            ClickOn(btn_addCart);
        }

        public void validatePageDetailResult()
        {
            waitForLocator(lbl_resultpage);
        }
    }
}
