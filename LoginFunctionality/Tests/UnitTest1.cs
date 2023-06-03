using LoginFunctionality.PageOjects;
using LoginFunctionality.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace LoginFunctionality.Tests
{
    public class Tests : Base
    {


        [Test]
        public void Test1()
        {
            Login login = new Login(getDriver());
            login.getUserName().SendKeys("rahulshettyacademy");
            login.getPassword().SendKeys("learning");
            login.getCheckbox().Click();
            login.getSignIn().Click();
        }
    }
}