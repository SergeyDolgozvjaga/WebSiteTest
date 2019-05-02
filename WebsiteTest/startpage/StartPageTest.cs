using NUnit.Framework;
using OpenQA.Selenium;
using Website;

namespace WebsiteTest
{
    [TestFixture]
    public class StartPageTest : BaseTest
    {       

        [Test]
        public void StartPage_AddressBook_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(ConstantURL.START_PAGE);

            // click on button 'Address book'
            var btnAddressBook = driver.FindElement(By.XPath(ConstantXPath.btnAddressBookStartPageXPath));
            btnAddressBook.Click();

            // current URL
            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);         
        }

        [Test]
        public void StartPage_Login_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(ConstantURL.START_PAGE);

            // find and click on button 'Login'
            var btnLogin = driver.FindElement(By.XPath(ConstantXPath.btnLoginStartPageXPath));
            btnLogin.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);           
        }

        [Test]
        public void StartPage_MyAccount_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = ConstantURL.LOGIN_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(ConstantURL.START_PAGE);

            // click on button 'My Account'
            var btnMyAccount = driver.FindElement(By.XPath(ConstantXPath.btnMyAccountStartPageXPath));
            btnMyAccount.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void StartPage_Register_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = ConstantURL.REGISTER_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(ConstantURL.START_PAGE);

            // click on button 'Register'
            var btnRegister = driver.FindElement(By.XPath(ConstantXPath.btnRegisterStartPageXPath));
            btnRegister.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }
    }
}
