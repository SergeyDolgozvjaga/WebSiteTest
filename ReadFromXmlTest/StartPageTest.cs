using NUnit.Framework;
using ReadFromXml;
using System;

namespace ReadFromXmlTest
{
    [TestFixture]
    public class StartPageTest
    {
        public StartPage startPage = new StartPage();
        public LoginPage loginPage = new LoginPage();
        public Driver drivers = new Driver();



        [SetUp]
        public void SetUp()
        {
            //drivers.SetUpChromeDriver();
            drivers.SetUpFireFoxDriver();
        }

        

        [Test]
        public void StartPage_AddressBook_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = loginPage.GetLoginPageURL();
            string actualURL;
            // Act
            // go to start page          

            drivers.NavigatePage(startPage.GetStartPageURL());
            // click on button 'Address book'
            startPage.GetButtonAddressBook();
            // current URL
            
            actualURL = drivers.GetURL();
            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [TearDown]
        public void TearDown()
        {
            drivers.Close();
        }
    }
}
