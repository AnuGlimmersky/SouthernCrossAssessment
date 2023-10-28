using OpenQA.Selenium;

namespace SouthernCrossAssessment.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        By UsernameField = By.LinkText("Register");

        public void ClickRegisterButton()
        {
            driver.FindElement(UsernameField).Click();
        }

    }
}
