using System;

namespace Website
{
    public class ConstantXPath
    {
        //start page
        public static readonly string btnLoginStartPageXPath = "//*[@class='list-group']//*[text()='Login']";
        public static readonly string btnMyAccountStartPageXPath = "//*[@class='list-group']//*[text()='My Account']";
        public static readonly string btnAddressBookStartPageXPath = "//*[@class='list-group']//*[text()='Address Book']";
        public static readonly string btnRegisterStartPageXPath = "//*[@class='list-group']//*[text()='Register']";
        // login page
        public static readonly string btnLoginLoginPageXPath = "//input[@value='Login']";
        public static readonly string btnContinueLogoutXPath = "//*[@class='pull-right']//*[text()='Continue']";     
        public static readonly string btnContinueFromLoginToRegisterPage = "//*[@class='well']//*[text()='Continue']";
        public static readonly string btnForgottenPasswordXPath = "//*[@class='form-group']//*[text()='Forgotten Password']";
        // account page
        public static readonly string btnMyAccountAccountPage = "//*[@class='list-group']//*[text()='My Account']";
        public static readonly string btnEditAccountAccountPage = "//*[@class='list-group']//*[text()='Edit Account']";
        public static readonly string btnAddressBookAccountPage = "//*[@class='list-group']//*[text()='Address Book']";
        public static readonly string btnLogoutLoginPageXPath = "//*[@class='list-group']//*[text()='Logout']";
        public static readonly string btnPasswordAccountPageXPath = "//*[@class='list-group']//*[text()='Password']";
        // edit account page
        public static readonly string btnBackEditPageXPath = "//*[@class='pull-left']//*[text()='Back']";
        public static readonly string btnContinueEditPageXPath = "//input[@value='Continue']";
        // password edit page
        public static readonly string btnBackPasswordPageXPath = "//*[@class='pull-left']//*[text()='Back']";
        public static readonly string btnContinuePasswordPageXPath = "//input[@value='Continue']";
        // address book page
        public static readonly string btnBackAddressBookPageXPath = "//*[@class='pull-left']//*[text()='Back']";
        public static readonly string btnEditAddressBookPageXPath = "//*[@class='text-right']//*[text()='Edit']";
        public static readonly string btnBackAddressBookEditPageXPath = "//*[@class='pull-left']//*[text()='Back']";
        public static readonly string btnNewAddressAddressBookPageXPath = "//*[@class='pull-right']//*[text()='New Address']";
        public static readonly string btnDeleteAddressAddressBookPageXPath = "//*[@class='text-right']//*[text()='Delete']";
        // register page
        public static readonly string btnContinueRegisterPage = "//*[@class='pull-right']//*[text()='Continue']";
        public static readonly string refbtnFromRegisterToLoginPage = "//*[@class='row']//*[text()='login page']";
        public static readonly string registerCheckboxValue = "//*[@class='pull-right']//*[text()='1']";
        // forget password page
        public static readonly string btnBackForgetPasswordPageXPath = "//*[@class='pull-left']//*[text()='Back']";

    }
}
