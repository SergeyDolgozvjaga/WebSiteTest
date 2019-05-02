using NUnit.Framework;
using OpenQA.Selenium;
using Website;

namespace WebsiteTest.startconditions
{
    [TestFixture]
    public class LoginBaseTest : BaseTest
    {
        [SetUp]
        public void SetUpLogin()
        {
            driver.Navigate().GoToUrl(ConstantURL.LOGIN_PAGE);

            var emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys(ConstantUserInfoUser1.E_MAIl);

            var passwordFieldInput = driver.FindElement(By.Id("input-password"));
            passwordFieldInput.SendKeys(ConstantUserInfoUser1.PASSWORD);

            var btnLoginOnLoginPage = driver.FindElement(By.XPath(ConstantXPath.btnLoginLoginPageXPath));
            btnLoginOnLoginPage.Click();
        }
    }
}
