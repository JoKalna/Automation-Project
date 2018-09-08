using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;
using OpenQA.Selenium.Chrome;

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
            // new test intialise in its own driver and then quick the driver
            //when it goes to the second driver it will initalise it in its class then close it at the end
            Driver.driver = new ChromeDriver();
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

            //using clear to clear any content before its run. e.g. all the inputs in the field.
            //Need to find a better way of how to clear down rather than coppying it 3 times

            lsPost.UserNameField.Clear();
            lsPost.UserNameField.SendKeys(username);

            lsPost.PasswordField.Clear();
            lsPost.PasswordField.SendKeys(password);

            lsPost.RepeatPasswordField.Clear();
            lsPost.RepeatPasswordField.SendKeys(repeatpassword);
            
            lsPost.LogInButton.Click();
        
        }
    }
}
