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

            string expected = URL.ACCOUNT_LOGOUT_PAGE;
            string actual;

            // Act

            // push button 'Logout'
            IWebElement btnLogout = driver.FindElement(By.XPath(XPath.btnLogoutAccountPageXPath));
            btnLogout.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Logout_To_HomePage_Test()
        {
            // Arrange
            string expected = URL.HOME_PAGE;
            string actual;

            // Act

            // push button 'Logout'
            IWebElement btnLogout = driver.FindElement(By.XPath(XPath.btnLogoutAccountPageXPath));
            btnLogout.Click();

            // push button 'Continue'
            IWebElement btnContinue = driver.FindElement(By.XPath(XPath.btnContinueLogoutXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
