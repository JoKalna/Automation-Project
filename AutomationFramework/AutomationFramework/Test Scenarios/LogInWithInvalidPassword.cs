using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework.Test_Scenarios
{

    [Parallelizable]
    class LogInWithInvalidPassword
    {
        IAlert alert;

        public LogInWithInvalidPassword()
        {
        }

        [OneTimeSetUp]

        public void Initialize()
        {
            Actions.InitlizeDriver();
            NavigateTo.NaviateToThroughTheMenu();

        }


        [Test]

        public void LessThanFiveChars()
        {

            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                  Config.Credentials.Invalid.Password.PasswordFourCharacters,
                                  Config.Credentials.Invalid.Password.PasswordFourCharacters);

            Thread.Sleep(5000);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.PasswordThirteenCharacters,
                Config.Credentials.Invalid.Password.PasswordThirteenCharacters);

            Thread.Sleep(5000);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]

        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}
