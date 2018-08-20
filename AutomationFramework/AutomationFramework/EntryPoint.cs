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
            /* This will navigate to the testing website and use the
             * driver specified in the drivers.cs class
             */ 

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com");
            NavigateTo.NaviateToThroughTheMenu();

            /*This is where you have to provide username, password and repeat password
            /usng config file to supply the login details 
            e.g valid credentials
            */

            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                  Config.Credentials.Valid.Password,
                                  Config.Credentials.Valid.RepeatPassword);


        }
    }
}
