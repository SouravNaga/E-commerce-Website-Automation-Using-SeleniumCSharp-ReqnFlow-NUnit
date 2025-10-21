using DemoWebShop_Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRM_Automation.Pages;
using ReqnFlowFramework.Reporting;

namespace DemoWebShop_Automation.StepDefinitions
{
    [Binding]
    public sealed class ProductCartSteps
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public Dictionary<string, string> config;
        public RegisterPage registerpage;
        public LoginPage loginpage;
        public ProductSearchPage productsearchpage;
        public ProductCartSteps(IWebDriver driver)
        {
            this.driver = driver;
            string folderPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName, "TestData\\");
            config = PropertiesReader.LoadProperties(folderPath + "data.properties");
            registerpage = new RegisterPage(driver);
            loginpage = new LoginPage(driver);
            productsearchpage = new ProductSearchPage(driver);

        }
        [Given("Select below product item")]
        public void GivenSelectBelowProductItem(DataTable dataTable)
        {
            var dict = dataTable.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            productsearchpage.selectProduct(dict["product"]);
        }

        [Then("Fetch all products names")]
        public void ThenFetchAllProductsNames()
        {
            productsearchpage.fetchAllElements();
        }

        [Then("select third product")]
        public void ThenSelectThirdProduct()
        {
            productsearchpage.SelectthirdProduct();
        }

        [Then("Verify correct product displaying or not")]
        public void ThenVerifyCorrectProductDisplayingOrNot()
        {
            productsearchpage.verifyProdname();
        }

        [Then("Fetch all details for the product")]
        public void ThenFetchAllDetailsForTheProduct()
        {
            productsearchpage.fetchAllDetails();
        }

        [Then("Click Add to cart button")]
        public void ThenClickAddToCartButton()
        {
            productsearchpage.clickAddToCartt();
        }

        [Then("Click Shopping cart link")]
        public void ThenClickShoppingCartLink()
        {
            productsearchpage.clickShoppingCartLink();
        }

        [Then("Verify product cut successful or not")]
        public void ThenVerifyProductCutSuccessfulOrNot()
        {
            Assert.IsTrue(productsearchpage.verifyProdPresence());
        }


    }
}
