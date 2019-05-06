using OpenQA.Selenium;
using System;

namespace ReadFromXml
{
    public class StartPage : Driver
    {
        XmlParser parser = new XmlParser();

        public string GetStartPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Start_page").InnerText;
        }

        public string GetButtonAddressBook()
        {
            return parser.LoadFileFindElementsTableStartPageXPath().SelectSingleNode("Button_Address_book").InnerText;
        }

        public string GetButtonMyAccount()
        {
            return parser.LoadFileFindElementsTableStartPageXPath().SelectSingleNode("Button_My_account").InnerText;
        }

        public void ButtonAddressBookClick()
        {
            IWebElement btnAddressBook = driver.FindElement(By.XPath(GetButtonAddressBook()));
            btnAddressBook.Click();
        }

        public void ButtonMyAccountClick()
        {
            IWebElement btnMyAccount = driver.FindElement(By.XPath(GetButtonMyAccount()));
            btnMyAccount.Click();
        }
    }
}
