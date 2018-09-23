using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class FirefoxDriverLauncher
    {
        static IWebDriver driver;
        public static void LaunchFirefoxBrowser(String url)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
        //    driver.Close();
        }
    }
}