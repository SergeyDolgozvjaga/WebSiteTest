using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Website;

namespace WebsiteTest
{
    [TestFixture]
    public class RegisterPageTest : BaseTest
    {
        [Test]
        public void From_RegisterPage_To_LoginPage_Using_LinkButton_Test()
        {
            // Arrange
            string expectedURL = URL.LOGIN_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(URL.REGISTER_PAGE);

            IWebElement btnLoginPage = driver.FindElement(By.XPath(XPath.refbtnFromRegisterToLoginPage));
            btnLoginPage.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void Registration_Confirm_Test()
        {
            // Arrange
            string expectedURL = URL.ACCOUNT_SUCESS_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(URL.START_PAGE);

            IWebElement btnRegister = driver.FindElement(By.XPath(XPath.btnRegisterStartPageXPath));
            btnRegister.Click();

            IWebElement firstnameInput = driver.FindElement(By.Id("input-firstname"));
            firstnameInput.SendKeys(UserInfoUser2.FIRSTNAME);

            IWebElement lastnameInput = driver.FindElement(By.Id("input-lastname"));
            lastnameInput.SendKeys(UserInfoUser2.LASTNAME);

            IWebElement emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys(UserInfoUser2.E_MAIl);

            IWebElement telephoneInput = driver.FindElement(By.Id("input-telephone"));
            telephoneInput.SendKeys(UserInfoUser2.TELEPHONE);

            IWebElement faxInput = driver.FindElement(By.Id("input-fax"));
            faxInput.SendKeys(UserInfoUser2.FAX);

            IWebElement companyInput = driver.FindElement(By.Id("input-company"));
            companyInput.SendKeys(UserInfoUser2.COMPANY);

            IWebElement Address1Input = driver.FindElement(By.Id("input-address-1"));
            Address1Input.SendKeys(UserInfoUser2.ADDRESS1);

            IWebElement Address2Input = driver.FindElement(By.Id("input-address-2"));
            Address2Input.SendKeys(UserInfoUser2.ADDRESS2);

            IWebElement cityInput = driver.FindElement(By.Id("input-city"));
            cityInput.SendKeys(UserInfoUser2.CITY);

            IWebElement postcodeInput = driver.FindElement(By.Id("input-postcode"));
            postcodeInput.SendKeys(UserInfoUser2.POSTCODE);         

            SelectElement regionSelection = new SelectElement(driver.FindElement(By.Id("input-zone")));
            regionSelection.SelectByText(UserInfoUser2.REGION);

            IWebElement passwordInput = driver.FindElement(By.Id("input-password"));
            passwordInput.SendKeys(UserInfoUser2.PASSWORD);

            IWebElement lastnameFieldInput = driver.FindElement(By.Id("input-confirm"));
            lastnameFieldInput.SendKeys(UserInfoUser2.PASSWORD);

            IWebElement checkbox = driver.FindElement(By.Name("agree"));
            checkbox.Click();

            IWebElement btnContinue = driver.FindElement(By.XPath(XPath.btnContinueRegisterPage));
            btnContinue.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }
    }
}
