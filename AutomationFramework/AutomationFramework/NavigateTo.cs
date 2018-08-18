

using AutomationFramework.UI_Elements;

namespace AutomationFramework
{
    /* THere will be two methods that will guide us to
     * a log in form via 2 different routs. 
     */
    public static class NavigateTo
    {

        public static void NaviateToThroughTheMenu()
        {
            //using a method that is created in UI Elements
            Menu menu = new Menu();
            //initialise test scenario page
            //create log in element 
            TestScenarioPage tsPage = new TestScenarioPage();
            //calling a method that are stored in Menu.cs
            menu.TestScenarios.Click();
            tsPage.LogInFormScenario.Click();


        }

        public static void LogInFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasePage tsPage = new TestCasePage();

        }
    }
}
