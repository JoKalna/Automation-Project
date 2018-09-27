using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This initiates driver to go to a test case page 
 * Using driver and find the link using css selector
 */


namespace AutomationFramework.UI_Elements
{
    class TestCasePage
    {
        //method initiates 
        public TestCasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-76.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div.mh-loop-content.clearfix > header > h3 > a")]
        public IWebElement TestCasePageLink { get; set; }
    }

}
