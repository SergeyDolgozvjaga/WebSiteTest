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
            driver.Navigate().GoToUrl(URL.START_PAGE);

            IWebElement btnLogin = driver.FindElement(By.XPath(XPath.btnLoginStartPageXPath));
            btnLogin.Click();

            IWebElement emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys(UserInfoUser1.E_MAIl);

            IWebElement passwordFieldInput = driver.FindElement(By.Id("input-password"));
            passwordFieldInput.SendKeys(UserInfoUser1.PASSWORD);

            IWebElement btnLoginOnLoginPage = driver.FindElement(By.XPath(XPath.btnLoginLoginPageXPath));
            btnLoginOnLoginPage.Click();
        }
    }
}
