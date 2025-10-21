using DemoWebShop_Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRM_Automation.Pages;
using ReqnFlowFramework.Reporting;

namespace DemoWebShop_Automation.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public Dictionary<string, string> config;
        public RegisterPage registerpage;
        public LoginPage loginpage;
        public LoginSteps(IWebDriver driver)
        {
            this.driver = driver;
            string folderPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName, "TestData\\");
            config = PropertiesReader.LoadProperties(folderPath + "data.properties");
            registerpage = new RegisterPage(driver);
            loginpage = new LoginPage(driver);


        }
        [Given("Click on the Login button")]
        public void GivenClickOnTheLoginButton()
        {
            registerpage.clickLoginLink();
        }

        [Then("enter email")]
        public void ThenEnterEmail()
        {
            loginpage.enterEmail(config["Email"]);
        }

        [Then("enter valid password")]
        public void ThenEnterValidPassword()
        {
            loginpage.enterPassword(config["Loginpassword"]);
        }

        [Then("click Login button")]
        public void ThenClickLoginButton()
        {
            loginpage.clickLogin();   
        }

        [Then("Verify Login successful or not")]
        public void ThenVerifyLoginSuccessfulOrNot()
        {
            Console.WriteLine("Steps to be added");
        }


    }
}
