/* J.K
 * This class is only used for the drivers
 *  Makes it possible to access and change/add in one place
 *  You prevent instantiation without needing a private constructor just to suppress the default public one
 *  Instantiation meaning - process of creating an object from a class
 *  Because object is an instance of a class. 
 */

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace AutomationFramework
{
    /* Creating a static class will perform a particular action that needs to be performed once
     * As we need to run multiple classess, it uses its port and second class creats its own driver
     * we need to initialise it in action class
     *  Create new property data type - Webdriver 
     */
    public static class Driver
    {
        public static IWebDriver driver { get; set; }  
    }
}
