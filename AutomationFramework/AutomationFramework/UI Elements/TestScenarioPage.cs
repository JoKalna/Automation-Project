using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UI_Elements
{
    public class TestScenarioPage
    {
        public TestScenarioPage()
        {
              PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-72.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div.mh-loop-content.clearfix > header > h3 > a")]
        public IWebElement LogInFormScenario { get; set; }
    }

}
