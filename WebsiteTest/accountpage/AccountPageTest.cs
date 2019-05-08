using NUnit.Framework;
using OpenQA.Selenium;
using Website;
using WebsiteTest.startconditions;

namespace WebsiteTest.accountpage
{
    [TestFixture]
    public class AccountPageTest : LoginBaseTest
    {
        [Test]
        public void MyAccount_Button_Click_Test()
        {
            // Arrange
            string expected = URL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'My Account'
            IWebElement btnMyAccount = driver.FindElement(By.XPath(XPath.btnMyAccountAccountPage));
            btnMyAccount.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EditAccount_Button_Click_And_Back_Button_Test()
        {
            // Arrange

            string expected = URL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Edit Account'
            IWebElement btnEditAccount = driver.FindElement(By.XPath(XPath.btnEditAccountAccountPage));
            btnEditAccount.Click();

            IWebElement btnBack = driver.FindElement(By.XPath(XPath.btnBackEditPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EditAccount_Button_Click_Then_EditUserData_And_Continue_Button_Test()
        {
            // Arrange
            string expected = URL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Edit Account'
            IWebElement btnEditAccount = driver.FindElement(By.XPath(XPath.btnEditAccountAccountPage));
            btnEditAccount.Click();

            IWebElement firstnameFieldInput = driver.FindElement(By.Id("input-firstname"));
            firstnameFieldInput.SendKeys("");

            IWebElement lastnameFieldInput = driver.FindElement(By.Id("input-lastname"));
            lastnameFieldInput.SendKeys("");

            IWebElement emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys("");

            IWebElement telephoneFieldInput = driver.FindElement(By.Id("input-telephone"));
            telephoneFieldInput.SendKeys("");

            IWebElement faxFieldInput = driver.FindElement(By.Id("input-fax"));
            //faxFieldInput.Clear();
            faxFieldInput.SendKeys("");

            IWebElement btnContinue = driver.FindElement(By.XPath(XPath.btnContinueEditPageXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Password_Button_Click_And_Back_Button_Test()
        {
            // Arrange
            string expected = URL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Password'
            IWebElement btnPassword = driver.FindElement(By.XPath(XPath.btnPasswordAccountPageXPath));
            btnPassword.Click();

            IWebElement btnBack = driver.FindElement(By.XPath(XPath.btnBackPasswordPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Password_Button_Click_And_Button_Continue_Click_Test()
        {
            // Arrange
            string expected = URL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Password'
            IWebElement btnPassword = driver.FindElement(By.XPath(XPath.btnPasswordAccountPageXPath));
            btnPassword.Click();

            IWebElement passwordInput = driver.FindElement(By.Id("input-password"));
            passwordInput.SendKeys(UserInfoUser1.PASSWORD);

            IWebElement lastnameFieldInput = driver.FindElement(By.Id("input-confirm"));
            lastnameFieldInput.SendKeys(UserInfoUser1.PASSWORD);

            IWebElement btnContinue = driver.FindElement(By.XPath(XPath.btnContinuePasswordPageXPath));
            btnContinue.Click();

            actual = driver.Url;
            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddressBook_Button_Click_And_Back_Button_Test()
        {
            // Arrange
            string expected = URL.ACCOUNT_PAGE;
            string actual;

            // Act
            // push button 'Address Book'
            IWebElement btnAddressBook = driver.FindElement(By.XPath(XPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            IWebElement btnBack = driver.FindElement(By.XPath(XPath.btnBackAddressBookPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddressBookEdit_Button_Click_And_Back_Button_Test()
        {
            // Arrange
            string expected = URL.ADDRESS_BOOK_PAGE;
            string actual;

            // Act
            IWebElement btnAddressBook = driver.FindElement(By.XPath(XPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'Edit'
            IWebElement btnEdit = driver.FindElement(By.XPath(XPath.btnEditAddressBookPageXPath));
            btnEdit.Click();

            IWebElement btnBack = driver.FindElement(By.XPath(XPath.btnBackAddressBookEditPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AddressBookEdit_Button_Click_And_Continue_Button_Test()
        {
            // Arrange
            string expected = URL.ADDRESS_BOOK_PAGE;
            string actual;

            // Act
            IWebElement btnAddressBook = driver.FindElement(By.XPath(XPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'Edit'
            IWebElement btnEdit = driver.FindElement(By.XPath(XPath.btnEditAddressBookPageXPath));
            btnEdit.Click();

            IWebElement firstNameInput = driver.FindElement(By.Id("input-firstname"));
            firstNameInput.SendKeys("");

            IWebElement lastNameInput = driver.FindElement(By.Id("input-lastname"));
            lastNameInput.SendKeys("");

            IWebElement companyInput = driver.FindElement(By.Id("input-company"));
            companyInput.SendKeys("");

            IWebElement Address1Input = driver.FindElement(By.Id("input-address-1"));
            Address1Input.SendKeys("");

            IWebElement Address2Input = driver.FindElement(By.Id("input-address-2"));
            Address2Input.SendKeys("");

            IWebElement cityInput = driver.FindElement(By.Id("input-city"));
            cityInput.SendKeys("");

            IWebElement postcodeInput = driver.FindElement(By.Id("input-postcode"));
            postcodeInput.SendKeys("");

            IWebElement btnContinue = driver.FindElement(By.XPath(XPath.btnContinueEditPageXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NewAddress_Button_Click_And_Back_Button_Test()
        {
            // Arrange
            string expected = URL.ADDRESS_BOOK_PAGE;
            string actual;

            // Act
            IWebElement btnAddressBook = driver.FindElement(By.XPath(XPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'New address'
            IWebElement btnNewAddress = driver.FindElement(By.XPath(XPath.btnNewAddressAddressBookPageXPath));
            btnNewAddress.Click();

            IWebElement btnBack = driver.FindElement(By.XPath(XPath.btnBackAddressBookEditPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
