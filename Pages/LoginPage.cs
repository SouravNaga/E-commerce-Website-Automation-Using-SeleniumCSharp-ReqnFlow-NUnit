using OpenQA.Selenium;
using OrangeHRM_Automation.Pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace DemoWebShop_Automation.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            common = new CommonPageMethod(driver);
        }
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement email;
        [FindsBy(How = How.Name, Using = "Password")]
        private IWebElement password;
        [FindsBy(How = How.Name, Using = "RememberMe")]
        private IWebElement rememberMe;
        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        private IWebElement loginBtn;
        [FindsBy(How = How.XPath, Using = "//span[@class='forgot-password']")]
        private IWebElement forgotPassword;
        [FindsBy(How = How.XPath, Using = "//input[@value='Register']")]
        private IWebElement registerBtn;

        public void enterEmail(string emailValue)
        {
            common.WaitForVisible(email);
            common.enterText(email, emailValue);
        }
        public void enterPassword(string pass)
        {
            common.WaitForVisible(password);
            common.enterText(password, pass);
        }
        public void clickRememberMe()
        {
            common.WaitForClickable(rememberMe);
            common.click(rememberMe);
        }
        public void clickLogin()
        {
            common.WaitForClickable(loginBtn);
            common.click(loginBtn);
        }
        public void clickForgotPass()
        {
            common.WaitForClickable(forgotPassword);
            common.click(forgotPassword);
        }
        public void clickRegister()
        {
            common.WaitForClickable(registerBtn);
            common.click(registerBtn);
        }
    }
}
