using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop_Automation.Pages
{
    public class OrderDetailsPage
    {
        public IWebDriver driver;
        public OrderDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//select[@id='CountryId']")]
        private IWebElement countryDropdown;
        [FindsBy(How = How.XPath, Using = "//select[@id='StateProvinceId']")]
        private IWebElement stateDropdown;
        [FindsBy(How = How.XPath, Using = "//input[@id='termsofservice']")]
        private IWebElement termCheckbox;
        [FindsBy(How = How.XPath, Using = "//button[@id='checkout']")]
        private IWebElement checkoutBtn;
        [FindsBy(How = How.XPath, Using = "(//input[@title='Continue' ])[1]")]
        private IWebElement continueBtn_BillingAdd;
        [FindsBy(How = How.XPath, Using = "(//input[@title='Continue' ])[2]")]
        private IWebElement continueBtn_ShippingAdd;
        [FindsBy(How = How.XPath, Using = "(//input[@name='PickUpInStore' ])[1]")]
        private IWebElement inStoreCheckbox_ShippingAdd;
        [FindsBy(How = How.XPath, Using = "(//input[@Value='Continue' ])[3]")]
        private IWebElement continueBtn_ShippingMethodAdd;
        [FindsBy(How = How.XPath, Using = "(//input[@Value='Continue' ])[4]")]
        private IWebElement continueBtn_PaymentMethodAdd;
        [FindsBy(How = How.XPath, Using = "(//input[@Value='Continue' ])[5]")]
        private IWebElement continueBtn_PaymentInformation;
        [FindsBy(How = How.XPath, Using = "//input[@Value='Confirm' ]")]
        private IWebElement confirmBtn;
        [FindsBy(How = How.XPath, Using = "//span[@class='product-price order-total']/strong")]
        private IWebElement TotalPrice;
    }
}
