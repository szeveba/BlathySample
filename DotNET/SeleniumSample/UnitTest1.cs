using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Text;

namespace SeleniumSample
{
    public class Tests
    {
        private EdgeDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var options = new EdgeOptions()
            {
                ImplicitWaitTimeout = TimeSpan.FromSeconds(5),
                LeaveBrowserRunning = false,
            };
            driver = new EdgeDriver(options);
        }

        [SetUp]
        public void SetUp()
        {
            driver.Url = "https://google.com";
            driver.FindElement(By.Id("W0wltc")).Click();
        }

        [Test]
        public void ReCapchaDisclaimerIsProperly()
        {
            driver.FindElements(By.XPath("//input[@name='btnI']")).Last().Click();
            var text = driver.FindElement(By.ClassName("recaptcha-disclaimer")).Text;
            Assert.That(text, Is.EqualTo("This site is protected by reCAPTCHA and the Google Privacy Policy and Terms of Service apply."));
        }

        [Test]
        public void CanSearchWithGoogle()
        {
            var searchBar = driver.FindElement(By.Id("APjFqb"));
            searchBar.SendKeys("Hello world!"+Keys.Enter);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}