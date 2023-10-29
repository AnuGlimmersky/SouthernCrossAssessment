using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SouthernCrossAssessment.Helper
{
    public class UtilityHelper
    {
        private IWebDriver driver;

        public UtilityHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForElement(By element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));

        }

    }

}
