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
            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(ConstantURL.REGISTER_PAGE);

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
            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act
            driver.Navigate().GoToUrl(ConstantURL.START_PAGE);
            
            var btnRegister = driver.FindElement(By.XPath(ConstantXPath.btnRegisterStartPageXPath));
            btnRegister.Click();

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

            SelectElement regionSelection = new SelectElement(driver.FindElement(By.Id("input-zone")));
            regionSelection.SelectByText(ConstantUserInfoUser2.REGION);

            var passwordInput = driver.FindElement(By.Id("input-password"));
            passwordInput.SendKeys(ConstantUserInfoUser2.PASSWORD);

            var lastnameFieldInput = driver.FindElement(By.Id("input-confirm"));
            lastnameFieldInput.SendKeys(ConstantUserInfoUser2.PASSWORD);


            driver.FindElement(By.ClassName("pull-right")).Click();
           
            /*
            var checkBoxInput = driver.FindElement(By.XPath(ConstantXPath.registerCheckboxValue));
            checkBoxInput.Click();
            */

            /*
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
