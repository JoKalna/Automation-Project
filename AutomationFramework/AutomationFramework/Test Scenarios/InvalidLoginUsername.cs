using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace AutomationFramework
{
    public class InvalidLoginUsername

    {
        public InvalidLoginUsername()
        {

        }

        //initialise Alert here
        IAlert alert;
        /*This is where you have to provide username, password and repeat password
                      /usng config file to supply the login details 
                      e.g valid credentials
        //Setting up Nunit.Framework 
        //set up everything before the test starts!*/


        [SetUp]
        public void Initlize()
        {
            Actions.InitlizeDriver();
            NavigateTo.NaviateToThroughTheMenu();
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
            NavigateTo.NaviateToThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters,
                                Config.Credentials.Valid.Password,
                                Config.Credentials.Valid.RepeatPassword);

            Thread.Sleep(5000);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.UserNameOutOfRange, alert.Text);

            //Accept Alert box
            alert.Accept();
        }
        [Test]
        public void MoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                                Config.Credentials.Valid.Password,
                                Config.Credentials.Valid.RepeatPassword);


            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.UserNameOutOfRange, alert.Text);

            //Accept Alert box
            alert.Accept();
        }



        public void ValidLogin()
        {
           
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
