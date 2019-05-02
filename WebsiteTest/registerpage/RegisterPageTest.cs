using NUnit.Framework;
using OpenQA.Selenium;
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

            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(ConstantURL.REGISTER_PAGE);

            // click on button 'Login page'
            var btnLoginPage = driver.FindElement(By.XPath(ConstantXPath.refbtnFromRegisterToLoginPage));
            btnLoginPage.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void Registration_Confirm_Test()
        {
            // Arrange

            string expectedURL = ConstantURL.REGISTER_PAGE;
            string actualURL;

            // Act

            // input data to registeration new user
            driver.Navigate().GoToUrl(ConstantURL.REGISTER_PAGE);

            var firstnameInput = driver.FindElement(By.Id("input-firstname"));
            firstnameInput.SendKeys(ConstantUserInfoUser2.FIRSTNAME);

            var lastnameInput = driver.FindElement(By.Id("input-lastname"));
            lastnameInput.SendKeys(ConstantUserInfoUser2.LASTNAME);

            var emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys(ConstantUserInfoUser2.E_MAIl);

            var telephoneInput = driver.FindElement(By.Id("input-telephone"));
            telephoneInput.SendKeys(ConstantUserInfoUser2.TELEPHONE);

            var faxInput = driver.FindElement(By.Id("input-fax"));
            faxInput.SendKeys(ConstantUserInfoUser2.FAX);

            var companyInput = driver.FindElement(By.Id("input-company"));
            companyInput.SendKeys(ConstantUserInfoUser2.COMPANY);

            var Address1Input = driver.FindElement(By.Id("input-address-1"));
            Address1Input.SendKeys(ConstantUserInfoUser2.ADDRESS1);

            var Address2Input = driver.FindElement(By.Id("input-address-2"));
            Address2Input.SendKeys(ConstantUserInfoUser2.ADDRESS2);

            var cityInput = driver.FindElement(By.Id("input-city"));
            cityInput.SendKeys(ConstantUserInfoUser2.CITY);

            var postcodeInput = driver.FindElement(By.Id("input-postcode"));
            postcodeInput.SendKeys(ConstantUserInfoUser2.POSTCODE);

            var countryInput = driver.FindElement(By.Id("input-country"));
            countryInput.SendKeys(ConstantUserInfoUser2.COUNTRY);

            var zoneInput = driver.FindElement(By.Id("input-zone"));
            zoneInput.SendKeys(ConstantUserInfoUser2.REGION);

            var passwordInput = driver.FindElement(By.Id("input-password"));
            passwordInput.SendKeys(ConstantUserInfoUser2.PASSWORD);

            var lastnameFieldInput = driver.FindElement(By.Id("input-confirm"));
            lastnameFieldInput.SendKeys(ConstantUserInfoUser2.PASSWORD);

            /*
            var checkBoxInput = driver.FindElement(By.XPath(ConstantXPath.registerCheckboxValue));
            checkBoxInput.Click();

            // click on button 'Continue'
            var btnContinue = driver.FindElement(By.XPath(ConstantXPath.btnContinueRegisterPage));
            btnContinue.Click();
            */

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }
    }
}
