using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;
using OpenQA.Selenium.Chrome;
using System.IO;
using System;

namespace AutomationFramework
{

    /* Action class perfomrs all the actions - Fills our loging form
     * 
     */
    /*Created another static void method
       * This time using config file to call the BaseURL
       * Public - tells complier that the method is accessible by anyone
       * Static - declares that main method is a global one and can be caleld
       * withouth creating an instance of the class.
       * Additonal information: an instance is a variable of any type contained within a class
       * or structure, and is used to store object data. It is a member of its containing type
       * with one copy of the field for each instance of the containing type.
   */
    public static class Actions
    {
        public static IWebDriver InitlizeDriver()
        {

            // new test intialise in its own driver and then quick the driver
            //when it goes to the second driver it will initalise it in its class then close it at the end

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }

        /* This method is sending a simple text to the log in form
        *Fill in the arguments for each of the fields
        */
       
        public static void FillLoginForm(string username,
                                        string password,
                                        string repeatpassword,
                                        IWebDriver driver)

        {
            LogInScenarioPost lsPost = new LogInScenarioPost(driver);
     

            //using clear to clear any content before its run. e.g. all the inputs in the field.
            //Find better way to clear all down before filling rather than 3 times
            lsPost.UserNameField.Clear();
            lsPost.UserNameField.SendKeys(username);

            lsPost.PasswordField.Clear();
            lsPost.PasswordField.SendKeys(password);
            
            
            lsPost.RepeatPasswordField.Clear();
            lsPost.RepeatPasswordField.SendKeys(repeatpassword);

            lsPost.LogInButton.Click();

        }


        //Need to figure out how to use th
    /*    public static void TakeAScreenshot()
        {
            IWebDriver chrome = new ChromeDriver();
            string screenshotDirectory = Directory.GetCurrentDirectory() + @"\screenshots";

            Screenshot elemetnScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();
            if(true)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            }

            elemetnScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\mytestelement.png", ScreenshotImageFormat.Png);

        }
        */



        }

    }





