using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var driver = new EdgeDriver(new EdgeOptions()
            {
                ImplicitWaitTimeout = TimeSpan.FromSeconds(5),
                LeaveBrowserRunning = true
            });
            driver.Url = "https://google.com";
            driver.FindElement(By.Id("W0wltc")).Click();
            driver.FindElements(By.Name("btnI")).Last().Click();
        }
    }
}
