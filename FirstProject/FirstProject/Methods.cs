using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Methods
    {
        //Passing search values
        public static void InputText(IWebDriver driver, string element, string input, string elementtype) {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(input);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(input);
        }

        //Selecting Box,Radios
        public static void ClickonElement(IWebDriver driver, string element, string input, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        public static void InputSelect(IWebDriver driver, string element, string input, string elementtype) {
            
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByIndex(2);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByIndex(2);

        }
    }
}
