using OpenQA.Selenium;

namespace SouthernCrossAssessment.PageObjects
{
    public class RegistrationPage
    {
        private IWebDriver driver;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By UsernameField = By.Id("username");
        By FirstNameField = By.Id("firstName");
        By LastNameField = By.Id("lastName");
        By PasswordField = By.Id("password");
        By ConfirmPasswordField = By.Id("confirmPassword");
        By SubmitButton = By.CssSelector(".btn-default[type=submit]");
        By SuccessfulMessage = By.CssSelector(".alert-success");


        public void EnterUsername(string username)
        {
            driver.FindElement(UsernameField).SendKeys(username);

        }
        public void EnterFirstName(string firstname)
        {
            driver.FindElement(FirstNameField).SendKeys(firstname);
        }
        public void EnterLastName(string lastName)
        {
            driver.FindElement(LastNameField).SendKeys(lastName);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(PasswordField).SendKeys(password);
        }
        public void EnterConfirmPassword(string password)
        {
            driver.FindElement(ConfirmPasswordField).SendKeys(password);
        }
        public void ClickSubmitButton()
        {
            driver.FindElement(SubmitButton).Click();
        }
        public bool VerifyRegistrationSuccessfulMessage()
        {
            try
            {
                return driver.FindElement(SuccessfulMessage).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}