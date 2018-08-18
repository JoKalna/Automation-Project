using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;
using System.Threading;

namespace AutomationFramework
{
   public class EntryPoint
    {
        static void Main()
        {
            /* This will navigate to the testing website and use the driver specified in the drivers.cs class
             */ 

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com");
            NavigateTo.NaviateToThroughTheMenu();
            Thread.Sleep(5000);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com");
            NavigateTo.LogInFormThroughThePost();
            Thread.Sleep(5000);

            Driver.driver.Quit();

            /* Accessin config file
            / This resembles plain english and understandable language
                Below is a crumbtrail of accessing Credential class, witin that class Invalid username, with fourcharacters test
            */
            //  Config.Credentials.Invalid.Username.FourCharacters;

        }
    }
}
