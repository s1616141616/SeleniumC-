using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ChromeBrowserLauncher
    {
        public static void LaunchChromeBrowser(String url) {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
          //  driver.Close();
            }
    }
}