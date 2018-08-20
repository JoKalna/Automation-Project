﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
/*Creatin this class to find the necessary drivers in the log in page
 * These then will be used in Actions method to fill the log in page 
 * 
 */
namespace AutomationFramework.UI_Elements
{

    class LogInScenarioPost
    {
        public LogInScenarioPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "userid")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.Id, Using = "passid")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "repeatpassid")]
        public IWebElement RepeatPasswordField { get; set; } 
        
        //This particular element is used to find the submit button

        [FindsBy(How = How.Name, Using= "submit")]
        public IWebElement LogInButton { get; set; }     

    }
}