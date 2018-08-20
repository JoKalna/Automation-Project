using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;

namespace AutomationFramework
{
   public static class Actions
    {
        /* This method is sending a simple text to the log in form
        *
        */
        //fill in the arguments for each of the fields
        public static void FillLoginForm(string username, 
                                        string password,
                                        string repeatpassword)
        {
         LogInScenarioPost lsPost = new LogInScenarioPost();
            lsPost.UserNameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatpassword);
            lsPost.LogInButton.Click();
        
        }
    }
}
