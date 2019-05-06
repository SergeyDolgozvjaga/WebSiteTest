using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ReadFromXml
{
    public class Driver
    {
        public IWebDriver driver;

        public void SetUpFireFoxDriver()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        public void SetUpChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void NavigatePage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetURL()
        {
            return driver.Url;
        }

        public void Close()
        {            
            driver.Quit();
        }
    }
}
