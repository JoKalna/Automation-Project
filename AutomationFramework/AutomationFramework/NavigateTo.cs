

using AutomationFramework.UI_Elements;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework
{
    /* THere will be two methods that will guide us to
     * a log in form via 2 different routs. 
     */
    public static class NavigateTo
    {

        public static void NaviateToThroughTheMenu(IWebDriver driver)
        {
            //using a method that is created in UI Elements
            Menu menu = new Menu(driver);
            //initialise test scenario page
            //create log in element 
            TestScenarioPage tsPage = new TestScenarioPage(driver);
            //calling a method that are stored in Menu.cs      
            menu.TestScenarios.Click();
            tsPage.LogInFormScenario.Click();
        }

        public static void LogInFormThroughThePost(IWebDriver driver)
        {
            //using UI elements form Menu.cs method
            Menu menu = new Menu(driver);
            TestCasePage tsPage = new TestCasePage(driver);
            Thread.Sleep(5000);
            //TestCase can be found under menue.cs
            menu.TestCases.Click();
            Thread.Sleep(5000);
            //initiate just now create ts page using TestCasePageLink created in Test Case Page
            tsPage.TestCasePageLink.Click();
            Thread.Sleep(5000);

        }
    }
}
