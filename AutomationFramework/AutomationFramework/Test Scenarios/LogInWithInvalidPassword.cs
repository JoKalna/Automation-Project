using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Test_Scenarios
{

    [Parallelizable]

   public class LogInWithInvalidPassword
    {
    

        public LogInWithInvalidPassword(IWebDriver Driver)
        {
        }

        IAlert alert;
        //property we can use across all classes
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]

        public void Initialize()
        {
            Driver = Actions.InitlizeDriver();
            NavigateTo.NaviateToThroughTheMenu(Driver);
        }


        [Test]

        public void LessThanFiveChars()
        {

            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                  Config.Credentials.Invalid.Password.PasswordFourCharacters,
                                  Config.Credentials.Invalid.Password.PasswordFourCharacters, Driver);

            Thread.Sleep(5000);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.PasswordThirteenCharacters,
                Config.Credentials.Invalid.Password.PasswordThirteenCharacters,
                Driver);

            Thread.Sleep(5000);
            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]

        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}
