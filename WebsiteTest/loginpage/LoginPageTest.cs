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
            string expectedURL = ConstantURL.ACCOUNT_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(ConstantURL.START_PAGE);

            var btnLogin = driver.FindElement(By.XPath(ConstantXPath.btnLoginStartPageXPath));
            btnLogin.Click();

            var emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys(ConstantUserInfoUser1.E_MAIl);

            var passwordFieldInput = driver.FindElement(By.Id("input-password"));
            passwordFieldInput.SendKeys(ConstantUserInfoUser1.PASSWORD);

            var btnLoginOnLoginPage = driver.FindElement(By.XPath(ConstantXPath.btnLoginLoginPageXPath));
            btnLoginOnLoginPage.Click();
           
            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void LoginPage_To_RegisterPage_Test()
        {
            // Arrange
            string expectedURL = ConstantURL.REGISTER_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(ConstantURL.LOGIN_PAGE);

            var btnLoginToRegisterPage = driver.FindElement(By.XPath(ConstantXPath.btnContinueFromLoginToRegisterPage));
            btnLoginToRegisterPage.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void LoginPage_Button_ForgetPassword_Click_And_Button_Back_Click_Test()
        {
            // Arrange
            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(ConstantURL.LOGIN_PAGE);

            var btnLoginToRegisterPage = driver.FindElement(By.XPath(ConstantXPath.btnForgottenPasswordXPath));
            btnLoginToRegisterPage.Click();

            var btnBack = driver.FindElement(By.XPath(ConstantXPath.btnBackForgetPasswordPageXPath));
            btnBack.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }
    }
}
