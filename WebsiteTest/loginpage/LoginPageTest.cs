using NUnit.Framework;
using OpenQA.Selenium;
using Website;

namespace WebsiteTest
{
    [TestFixture]
    public class LoginPageTest : BaseTest
    {

        [Test]
        public void Login_Confirm_Test()
        {
            // Arrange
            string expectedURL = URL.ACCOUNT_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(URL.START_PAGE);

            IWebElement btnLogin = driver.FindElement(By.XPath(XPath.btnLoginStartPageXPath));
            btnLogin.Click();

            IWebElement emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys(UserInfoUser1.E_MAIl);

            IWebElement passwordFieldInput = driver.FindElement(By.Id("input-password"));
            passwordFieldInput.SendKeys(UserInfoUser1.PASSWORD);

            IWebElement btnLoginOnLoginPage = driver.FindElement(By.XPath(XPath.btnLoginLoginPageXPath));
            btnLoginOnLoginPage.Click();
           
            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
            
        }

        [Test]
        public void LoginPage_To_RegisterPage_Test()
        {
            // Arrange
            string expectedURL = URL.REGISTER_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(URL.LOGIN_PAGE);

            IWebElement btnContinue = driver.FindElement(By.XPath(XPath.btnContinueFromLoginToRegisterPage));
            btnContinue.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void LoginPage_Button_ForgetPassword_Click_And_Button_Back_Click_Test()
        {
            // Arrange
            string expectedURL = URL.LOGIN_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(URL.LOGIN_PAGE);

            IWebElement btnLoginToRegisterPage = driver.FindElement(By.XPath(XPath.btnForgottenPasswordXPath));
            btnLoginToRegisterPage.Click();

            IWebElement btnBack = driver.FindElement(By.XPath(XPath.btnBackForgetPasswordPageXPath));
            btnBack.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        } 
    }
}
