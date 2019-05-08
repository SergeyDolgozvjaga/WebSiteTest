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
            string expectedURL = URL.LOGIN_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(URL.START_PAGE);

            // click on button 'Address book'
            IWebElement btnAddressBook = driver.FindElement(By.XPath(XPath.btnAddressBookStartPageXPath));
            btnAddressBook.Click();

            // current URL
            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);         
        }
      
        [Test]
        public void StartPage_MyAccount_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = URL.LOGIN_PAGE;
            string actualURL;

            // Act

            // start URL
            driver.Navigate().GoToUrl(URL.START_PAGE);

            // click on button 'My Account'
            IWebElement btnMyAccount = driver.FindElement(By.XPath(XPath.btnMyAccountStartPageXPath));
            btnMyAccount.Click();

            actualURL = driver.Url;

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }     
    }
}
