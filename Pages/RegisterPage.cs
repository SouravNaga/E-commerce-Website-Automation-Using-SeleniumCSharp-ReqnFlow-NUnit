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
    public class RegisterPage
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            common = new CommonPageMethod(driver);
        }
        [FindsBy(How = How.Id, Using = "gender-male")]
        private IWebElement maleGen;
        [FindsBy(How = How.Id, Using = "gender-female")]
        private IWebElement femaleGen;
        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement firstname;
        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebElement lastname;
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement email;
        [FindsBy(How = How.Name, Using = "Password")]
        private IWebElement password;
        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        private IWebElement confirmPassword;
        [FindsBy(How = How.Name, Using = "register-button")]
        private IWebElement registerBtn;
        [FindsBy(How = How.XPath, Using = "//a[text()='Register']")]
        private IWebElement registerLink;
        [FindsBy(How = How.XPath, Using = "//a[text()='Log in']")]
        private IWebElement loginLink;

        public void selectGender(string gen)
        {
            if (gen.Equals("male", StringComparison.OrdinalIgnoreCase)){
                common.WaitForClickable(maleGen);
                common.HighlightElement(driver, maleGen);
                common.click(maleGen);

            }
            else {
                common.WaitForClickable(femaleGen);
                common.HighlightElement(driver, femaleGen);
                common.click(femaleGen); 
            }
        }
    
    public void enterFirstName(string fname)
        {
            common.WaitForVisible(firstname);
            common.HighlightElement(driver, firstname);
            common.enterText(firstname, fname);
        }
        public void enterLastName(string lname)
        {
            common.WaitForVisible(lastname);
            common.HighlightElement(driver, lastname);
            common.enterText(lastname, lname);
        }
        public void enterEmail(string emailValue)
        {
            common.WaitForVisible(email);
            common.HighlightElement(driver, email);
            common.enterText(email, emailValue);
        }
        public void enterPassword(string pass)
        {
            common.WaitForVisible(password);
            common.HighlightElement(driver, password);
            common.enterText(password, pass);
        }
        public void enterConfirmPassword(string confirmpass)
        {
            common.WaitForVisible(confirmPassword);
            common.HighlightElement(driver, confirmPassword);
            common.enterText(confirmPassword, confirmpass);
        }
        public void clickRegister()
        {
            common.WaitForClickable(registerBtn);
            common.HighlightElement(driver, registerBtn);
            common.click(registerBtn);
        }
        public void clickRegisterLink()
        {
            common.WaitForClickable(registerLink);
            common.HighlightElement(driver, registerLink);
            common.click(registerLink);
        }
        public void clickLoginLink()
        {
            common.WaitForClickable(loginLink);
            common.HighlightElement(driver, loginLink);
            common.click(loginLink);
        }
    }
}
