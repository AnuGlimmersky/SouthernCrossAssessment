using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SouthernCrossAssessment.Helper;

namespace SouthernCrossAssessment.PageObjects
{
    public class RegistrationPage
    {
        private IWebDriver driver;
        UtilityHelper utilities;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            utilities = new UtilityHelper(driver);
        }

        By UsernameField = By.Id("username");
        By FirstNameField = By.Id("firstName");
        By LastNameField = By.Id("lastName");
        By PasswordField = By.Id("password");
        By ConfirmPasswordField = By.Id("confirmPassword");
        By SubmitButton = By.CssSelector(".btn-default[type=submit]");
        By SuccessfulMessage = By.CssSelector(".alert-success");
        By ValidationErrorMessage = By.CssSelector(".result.alert-danger");

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
                utilities.WaitForElement(SuccessfulMessage);
                return driver.FindElement(SuccessfulMessage).Displayed;
            }
            catch {
                return false;
            }
        }

        public bool VerifyInvalidRegistrationErrorIsDisplayed()
        {
            try
            {
                utilities.WaitForElement(ValidationErrorMessage);
                return driver.FindElement(ValidationErrorMessage).Displayed;
            }
            catch{
                return false;
            }
        }
        public string? ReturnInvalidRegistrationErrorMessage()
        {
            try
            {
                utilities.WaitForElement(ValidationErrorMessage);
                return driver.FindElement(ValidationErrorMessage).Text.ToString();
            }
            catch{
                return null;
            }
        }
    }
}