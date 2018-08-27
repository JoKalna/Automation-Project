using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework.Test_Scenarios
{
    class LogInWithInvalidPassword
    {
        IAlert alert;

        public LogInWithInvalidPassword()
        {
        }

        [SetUp]
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

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }

        [TearDown]

        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}
