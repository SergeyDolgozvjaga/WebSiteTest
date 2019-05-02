using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WebsiteTest
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // launch driver
           // driver = new FirefoxDriver();

            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            // shutdown driver
            driver.Quit();
        }
    }
}
