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

            string expected = ConstantURL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'My Account'
            var btnMyAccount = driver.FindElement(By.XPath(ConstantXPath.btnMyAccountAccountPage));
            btnMyAccount.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EditAccount_Button_Click_And_Back_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Edit Account'
            var btnEditAccount = driver.FindElement(By.XPath(ConstantXPath.btnEditAccountAccountPage));
            btnEditAccount.Click();

            var btnBack = driver.FindElement(By.XPath(ConstantXPath.btnBackEditPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EditAccount_Button_Click_Then_EditUserData_And_Continue_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Edit Account'
            var btnEditAccount = driver.FindElement(By.XPath(ConstantXPath.btnEditAccountAccountPage));
            btnEditAccount.Click();

            var firstnameFieldInput = driver.FindElement(By.Id("input-firstname"));
            firstnameFieldInput.SendKeys("");

            var lastnameFieldInput = driver.FindElement(By.Id("input-lastname"));
            lastnameFieldInput.SendKeys("");
          
            var emailFieldInput = driver.FindElement(By.Id("input-email"));
            emailFieldInput.SendKeys("");
                       
            var telephoneFieldInput = driver.FindElement(By.Id("input-telephone"));
            telephoneFieldInput.SendKeys("");
                      
            var faxFieldInput = driver.FindElement(By.Id("input-fax"));
            faxFieldInput.SendKeys("");            

            var btnContinue = driver.FindElement(By.XPath(ConstantXPath.btnContinueEditPageXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Password_Button_Click_And_Back_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Password'
            var btnPassword = driver.FindElement(By.XPath(ConstantXPath.btnPasswordAccountPageXPath));
            btnPassword.Click();




            var btnBack = driver.FindElement(By.XPath(ConstantXPath.btnBackPasswordPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Password_Button_Click_And_Button_Continue_Click_Test()
        {
            // Arrange

            string expected = ConstantURL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Password'
            var btnPassword = driver.FindElement(By.XPath(ConstantXPath.btnPasswordAccountPageXPath));
            btnPassword.Click();


            var passwordInput = driver.FindElement(By.Id("input-password"));
            passwordInput.SendKeys(ConstantUserInfoUser1.PASSWORD);

            var lastnameFieldInput = driver.FindElement(By.Id("input-confirm"));
            lastnameFieldInput.SendKeys(ConstantUserInfoUser1.PASSWORD);



            var btnContinue = driver.FindElement(By.XPath(ConstantXPath.btnContinuePasswordPageXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddressBook_Button_Click_And_Back_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ACCOUNT_PAGE;
            string actual;

            // Act

            // push button 'Address Book'
            var btnAddressBook = driver.FindElement(By.XPath(ConstantXPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            var btnBack = driver.FindElement(By.XPath(ConstantXPath.btnBackAddressBookPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddressBookEdit_Button_Click_And_Back_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ADDRESS_BOOK_PAGE;
            string actual;

            // Act

            var btnAddressBook = driver.FindElement(By.XPath(ConstantXPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'Edit'
            var btnEdit = driver.FindElement(By.XPath(ConstantXPath.btnEditAddressBookPageXPath));
            btnEdit.Click();

            var btnBack = driver.FindElement(By.XPath(ConstantXPath.btnBackAddressBookEditPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AddressBookEdit_Button_Click_And_Continue_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ADDRESS_BOOK_PAGE;
            string actual;

            // Act

            var btnAddressBook = driver.FindElement(By.XPath(ConstantXPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'Edit'
            var btnEdit = driver.FindElement(By.XPath(ConstantXPath.btnEditAddressBookPageXPath));
            btnEdit.Click();

            var firstNameInput = driver.FindElement(By.Id("input-firstname"));
            firstNameInput.SendKeys("");

            var lastNameInput = driver.FindElement(By.Id("input-lastname"));
            lastNameInput.SendKeys("");

            var companyInput = driver.FindElement(By.Id("input-company"));
            companyInput.SendKeys("");

            var Address1Input = driver.FindElement(By.Id("input-address-1"));
            Address1Input.SendKeys("");

            var Address2Input = driver.FindElement(By.Id("input-address-2"));
            Address2Input.SendKeys("");

            var cityInput = driver.FindElement(By.Id("input-city"));
            cityInput.SendKeys("");

            var postcodeInput = driver.FindElement(By.Id("input-postcode"));
            postcodeInput.SendKeys("");

            var btnContinue = driver.FindElement(By.XPath(ConstantXPath.btnContinueEditPageXPath));
            btnContinue.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NewAddress_Button_Click_And_Back_Button_Test()
        {
            // Arrange

            string expected = ConstantURL.ADDRESS_BOOK_PAGE;
            string actual;

            // Act

            var btnAddressBook = driver.FindElement(By.XPath(ConstantXPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'New address'
            var btnNewAddress = driver.FindElement(By.XPath(ConstantXPath.btnNewAddressAddressBookPageXPath));
            btnNewAddress.Click();

            var btnBack = driver.FindElement(By.XPath(ConstantXPath.btnBackAddressBookEditPageXPath));
            btnBack.Click();

            actual = driver.Url;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        /*
        [Test]
        public void Delete_Button_For_NotDefaultAddressDelete_Click_Test()
        {
            // Arrange
            string expectMsg = "Warning: You can not delete your default address!";
            string expected = ConstantURL.ADDRESS_BOOK_EDIT_USER1_PAGE;
            string actual;

            // Act

            var btnAddressBook = driver.FindElement(By.XPath(ConstantXPath.btnAddressBookAccountPage));
            btnAddressBook.Click();

            // push button 'New address'
            var btnNewAddress = driver.FindElement(By.XPath(ConstantXPath.btnDeleteAddressAddressBookPageXPath));
            btnNewAddress.Click();

            actualMsg = driver.Title;
            actual = driver.Url;

            // Assert

            Assert.AreEqual(expectMsg, actualMsg);
            Assert.AreEqual(expected, actual);
        }
        */


    }
}
