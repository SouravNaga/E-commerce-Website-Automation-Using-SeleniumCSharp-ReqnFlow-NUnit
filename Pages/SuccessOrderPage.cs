using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop_Automation.Pages
{
    public class SuccessOrderPage
    {
        public IWebDriver driver;
        public SuccessOrderPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'order-completed')]/descendant::strong")]
        private IWebElement successMsg;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'order-completed')]/descendant::ul/li")]
        private IWebElement orderNumber;
        [FindsBy(How = How.XPath, Using = "//input[@value='Continue']")]
        private IWebElement continueBtn;
        [FindsBy(How = How.XPath, Using = "//a[text()='Log out']")]
        private IWebElement logoutLink;
    }
}
