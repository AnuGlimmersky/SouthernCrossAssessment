using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SouthernCrossAssessment.Support
{
    public class Utilities
    {
        private IWebDriver driver;

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForElement(By element) {

            var wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));

        }
    }

}
