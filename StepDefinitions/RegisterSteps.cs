using DemoWebShop_Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRM_Automation.Pages;
using ReqnFlowFramework.Reporting;

namespace DemoWebShop_Automation.StepDefinitions
{
    [Binding]
    public sealed class RegisterSteps
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public Dictionary<string, string> config;
        public RegisterPage registerpage;
        public RegisterSteps(IWebDriver driver)
        {
            this.driver = driver;
            string folderPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName, "TestData\\");
            config = PropertiesReader.LoadProperties(folderPath + "data.properties");
            registerpage = new RegisterPage(driver);


        }
        [Given("Open the browser")]
        public void GivenOpenTheBrowser()
        {
            Console.WriteLine("Browser opened");
        }

        [When("Login the url")]
        public void WhenLoginTheUrl()
        {
            string url = config["baseUrl"];
            driver.Url = url;
        }

        [Given("Click on the Register button")]
        public void GivenClickOnTheRegisterButton()
        {
            registerpage.clickRegisterLink();
        }

        [When("Fill all details with valid data")]
        public void WhenFillAllDetailsWithValidData(DataTable dataTable)
        {
            var dict = dataTable.Rows.ToDictionary(row => row["Field"], row => row["Value"]);

            Console.WriteLine($"Gender: {dict["Gender"]}");
            Console.WriteLine($"Firstname: {dict["Firstname"]}");
            Console.WriteLine($"Lastname: {dict["Lastname"]}");
            //Console.WriteLine($"Email: {dict["Email"]}");
            registerpage.selectGender(dict["Gender"]);
            registerpage.enterFirstName(dict["Firstname"]);
            registerpage.enterLastName(dict["Lastname"]);
            registerpage.enterEmail(config["Email"]);

        }

        [Then("enter password")]
        public void ThenEnterPassword()
        {
            string pass = config["password"];
            registerpage.enterPassword(pass);
        }

        [Then("enter confirm password")]
        public void ThenEnterConfirmPassword()
        {
            string pass = config["Confirm_password"];
            registerpage.enterConfirmPassword(pass);
        }

        [Then("click Register button")]
        public void ThenClickRegisterButton()
        {
            registerpage.clickRegister();
        }

        [Then("Verify register successful or not")]
        public void ThenVerifyRegisterSuccessfulOrNot()
        {
            Console.WriteLine("steps to be added");
        }
        [Then("enter gmail")]
        public void ThenEnterGmail()
        {
            registerpage.enterEmail(config["username"]);
        }


    }
}
