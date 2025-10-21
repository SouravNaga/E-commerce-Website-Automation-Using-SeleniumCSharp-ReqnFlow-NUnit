using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRM_Automation.Pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop_Automation.Pages
{
    public class ProductSearchPage
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public string thirdItem = null;
        public ProductSearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            common = new CommonPageMethod(driver);
        }
        [FindsBy(How = How.XPath, Using = "//span[text()='Shopping cart']")]
        private IWebElement shoppingCartLink;
        [FindsBy(How = How.XPath,Using = "//h2[@class='product-title']/a")]
        private IList<IWebElement> allProducts;
        [FindsBy(How = How.XPath, Using = "(//h2[@class='product-title']/a)[3]")]
        private IWebElement thirdProduct;
        [FindsBy(How = How.XPath, Using = "//h1[@itemprop='name']")]
        private IWebElement prodName;
        [FindsBy(How = How.XPath, Using = "//div[@class='short-description']")]
        private IWebElement prodDescription;
        [FindsBy(How = How.XPath, Using = "//span[@itemprop='price']")]
        private IWebElement prodPrice;
        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'add-to-cart-button')]")]
        private IWebElement addToCartBtn;
        [FindsBy(How = How.XPath, Using = "//td[@class='product']/a")]
        private IList<IWebElement> allCartProducts;
        public void selectProduct(string prod)
        {
            IWebElement pro = driver.FindElement(By.XPath("(//a[contains(text(),'"+ prod + "')])[1]"));
            common.WaitForClickable(pro);
            common.click(pro);

        }
        public bool verifyProdPresence()
        {
            bool flag = false;
            for (int i = 0; i < allCartProducts.Count; i++)
            {
                string avlprod = allCartProducts[i].Text;
                if (avlprod.Equals(thirdItem))
                {
                    flag =  true;
                    common.HighlightElement(driver, allCartProducts[i]);
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public void clickAddToCartt()
        {
            common.WaitForClickable(addToCartBtn);
            common.HighlightElement(driver, addToCartBtn);
            common.click(addToCartBtn);

        }
        public void clickShoppingCartLink()
        {
            common.WaitForClickable(shoppingCartLink);
            common.HighlightElement(driver, shoppingCartLink);
            common.click(shoppingCartLink);

        }
        public void fetchAllDetails()
        {
            common.WaitForVisible(prodName);
            common.HighlightElement(driver, prodName);
            Console.WriteLine("Product Name : "+prodName.Text);
            common.HighlightElement(driver, prodDescription);
            Console.WriteLine("Product Description : " + prodDescription.Text);
            common.HighlightElement(driver, prodPrice);
            Console.WriteLine("Product Price : " + prodPrice.Text);
        }
        public void fetchAllElements()
        {
            common.WaitForVisible(driver.FindElement(By.XPath("(//h2[@class='product-title']/a)[1]")));
            for (int i = 0; i < allProducts.Count; i++) { 
                Console.WriteLine(allProducts[i].Text);
            }
        }
        public void SelectthirdProduct()
        {
            common.WaitForClickable(thirdProduct);
            common.HighlightElement(driver, thirdProduct);
            thirdItem = thirdProduct.Text;
            common.click(thirdProduct);
        }
       public void verifyProdname()
        {
            common.WaitForVisible(prodName);
            string actTitle = prodName.Text;
            Assert.AreEqual(thirdItem, actTitle,"Item not matched");
        }
    }
}
