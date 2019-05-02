using NUnit.Framework;
using OpenQA.Selenium;
using Website;
using WebsiteTest.startconditions;

namespace WebsiteTest
{
    [TestFixture]
    public class AccountPageLogoutTest : LoginBaseTest
    {
        [Test]
        public void Logout_AccountPage_Test()
        {
            // Arrange

            string expected = ConstantURL.ACCOUNT_LOGOUT_PAGE;
            string actual;

            // Act

            // push button 'Logout'
            var btnLogout = driver.FindElement(By.XPath(ConstantXPath.btnLogoutLoginPageXPath));
            btnLogout.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Logout_To_HomePage_Test()
        {
            // Arrange
            string expected = ConstantURL.HOME_PAGE;
            string actual;

            // Act

            // push button 'Logout'
            var btnLogout = driver.FindElement(By.XPath(ConstantXPath.btnLogoutLoginPageXPath));
            btnLogout.Click();

            // push button 'Continue'
            var btnContinue = driver.FindElement(By.XPath(ConstantXPath.btnContinueLogoutXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
