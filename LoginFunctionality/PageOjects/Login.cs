using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Database;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFunctionality.PageOjects
{
    public class Login
    {
        private IWebDriver driver;
        public Login(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);



        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group'][5]/label/span/input")]
        private IWebElement checkbox;

        [FindsBy(How = How.CssSelector, Using = "input[value='Sign In")]
        private IWebElement signInButton;


        public IWebElement getUserName()

        {
            return username;


        }

        public IWebElement getPassword()

        {
            return password;
        }

        public IWebElement getCheckbox()

        {
            return checkbox;
        }

        public IWebElement getSignIn()

        {
            return signInButton;
        }


    }
}
