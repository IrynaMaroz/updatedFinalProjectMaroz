using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework

{
    public class Driver
    {
        static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }
        public static IWebDriver GetDriver()
        {
            return driver;
        }
        public static void OpenPage (string url)
        {
            driver.Url = url;
        }
        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}