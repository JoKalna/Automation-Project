using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;

namespace AutomationFramework
{
   public class EntryPoint
    {
        static void Main()
        {
            /* This will navigate to the testing website and use the driver specified in the drivers.cs class
             * and use the UI Element file to find "Selector" menu
             */ 

            Menu menu = new Menu();
            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com");
            menu.Selectors.Click();

            /* Accessin config file
            / This resembles plain english and understandable language
                Below is a crumbtrail of accessing Credential class, witin that class Invalid username, with fourcharacters test
            */
            Config.Credentials.Invalid.Username.FourCharacters;

        }
    }
}
