using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;

namespace AutomationFramework
{
    public static class Actions

        /*Created another static void method
         * This time using config file to call the BaseURL
         * Public - tells complier that the method is accessible by anyone
         * Static - declares that main method is a global one and can be caleld
         * withouth creating an instance of the class.
         * Additonal information: an instance is a variable of any type contained within a class
         * or structure, and is used to store object data. It is a member of its containing type
         * with one copy of the field for each instance of the containing type.
     */
    {
        public static void InitlizeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);

        }

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
