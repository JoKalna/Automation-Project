using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System.Threading;

namespace AutomationFramework
{

    [Parallelizable]

    public class InvalidLoginUsername

    {
        public InvalidLoginUsername(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //initialise Alert here
        IAlert alert;
        public IWebDriver Driver { get; set; }

        /*This is where you have to provide username, password and repeat password
                      /usng config file to supply the login details 
                      e.g valid credentials
        //Setting up Nunit.Framework 
        //set up everything before the test starts!*/

        [OneTimeSetUp]
        public void Initlize()
        {
           Driver =  Actions.InitlizeDriver();
            NavigateTo.NaviateToThroughTheMenu(Driver);
        }
        //between SetUp and TearDown creat tests.
        //first test method

        /* Equal to see what we expect vs actual
        *Using Config File to get the message.
        * Actual will be the alert box on what is appearing
        */
        [Test]

        public void LessThan5Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters,
                                Config.Credentials.Valid.Password,
                                Config.Credentials.Valid.RepeatPassword,
                               Driver);

            Thread.Sleep(5000);
            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.UserNameOutOfRange, alert.Text);

            //Accept Alert box
            alert.Accept();
        }
        [Test]
        public void MoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                                Config.Credentials.Valid.Password,
                                Config.Credentials.Valid.RepeatPassword, Driver);


            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.UserNameOutOfRange, alert.Text);

            //Accept Alert box
            alert.Accept();
        }

        //user assertions to confirm if test is succesfull
        //use IAlert to recognise that th test is validd

        /*in this particular case when logged
         * Alert box appears
         * For future reference, map out how to make assertions
         * ID? Need a bit of research on how to creat good assertions
        */

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}
