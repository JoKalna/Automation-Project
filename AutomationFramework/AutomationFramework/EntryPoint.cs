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
           Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("http://testing.todovachev.com");
            menu.About.Click();
            

        }
    }
}
