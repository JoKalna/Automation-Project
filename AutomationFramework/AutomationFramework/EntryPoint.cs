using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using AutomationFramework.UI_Elements;
using System.Threading;
using NUnit.Framework;

namespace AutomationFramework
{
    public class EntryPoint

    {
        //initialise Alert here
        IAlert alert;
        static void Main()
        {
            /*This is where you have to provide username, password and repeat password
               /usng config file to supply the login details 
               e.g valid credentials
               */
               

           
        }
        //Setting up Nunit.Framework 
        //set up everything before the test starts!
      
        [SetUp]
        public void Initlize()
        {
            Actions.InitlizeDriver();
        }
        //between SetUp and TearDown creat tests.

        [Test]
        //first test method

            public void ValidLogin()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                 Config.Credentials.Valid.Password,
                                 Config.Credentials.Valid.RepeatPassword);

            /*se Equal to see what we expect vs actual
            //Using Config File to get the message.
            Actual will be the alert box on what is appearing
            */
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccesfullLogin, alert.Text);

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

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
