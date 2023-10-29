using NUnit.Framework;
using OpenQA.Selenium;
using SouthernCrossAssessment.Helpers;
using SouthernCrossAssessment.PageObjects;

namespace SouthernCrossAssessment.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        RegistrationPage registrationPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            registrationPage = new RegistrationPage(driver);
        }

        [Given(@"that I am in the Buggy Cars registration page")]
        public void GivenThatIAmInTheBuggyCarsRegistrationPage()
        {
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/register");
        }

        [When(@"I have filled username as '([^']*)', First name as '([^']*)' and Last name as '([^']*)'")]
        public void WhenIHaveFilledUsernameAsFirstNameAsAndLastNameAs(string username, string firstName, string lastName)
        {
            registrationPage.EnterUsername(username);
            registrationPage.EnterFirstName(firstName);
            registrationPage.EnterLastName(lastName);
        }

        [When(@"I enter password and confirm password as '([^']*)'")]
        public void WhenIEnterPasswordAndConfirmPasswordAs(string password)
        {
            registrationPage.EnterPassword(password);
            registrationPage.EnterConfirmPassword(password);
        }

        [When(@"I click Register button")]
        public void WhenIClickRegisterButton()
        {
            registrationPage.ClickSubmitButton();
        }

        [Then(@"I should see a registration successful message")]
        public void ThenIShouldSeeARegistrationSuccessfulMessage()
        {
            Assert.AreEqual(true, registrationPage.VerifyRegistrationSuccessfulMessage());
        }

        [Then(@"I should see a password validation error for missing uppercase")]
        public void ThenIShouldSeeAPasswordValidationErrorForMissingUppercase()
        {
            Assert.AreEqual(true, registrationPage.VerifyInvalidRegistrationErrorIsDisplayed());
            Assert.AreEqual(Resources.InvalidPasswordMissingUpperCase, registrationPage.ReturnInvalidRegistrationErrorMessage());
        }

        [Then(@"I should see a password validation error for missing special character")]
        public void ThenIShouldSeeAPasswordValidationErrorForMissingSpecialCharacter()
        {
            Assert.AreEqual(true, registrationPage.VerifyInvalidRegistrationErrorIsDisplayed());
            Assert.AreEqual(Resources.InvalidPasswordMissingSymbol, registrationPage.ReturnInvalidRegistrationErrorMessage());
        }

        [Then(@"I should see a password validation error for missing lowercase")]
        public void ThenIShouldSeeAPasswordValidationErrorForMissingLowercase()
        {
            Assert.AreEqual(true, registrationPage.VerifyInvalidRegistrationErrorIsDisplayed());
            Assert.AreEqual(Resources.InvalidPasswordMissingLowerCase, registrationPage.ReturnInvalidRegistrationErrorMessage());
        }

        [Then(@"I should see a password validation error for incorrect length")]
        public void ThenIShouldSeeAPasswordValidationErrorForIncorrectLength()
        {
            Assert.AreEqual(true, registrationPage.VerifyInvalidRegistrationErrorIsDisplayed());
            Assert.AreEqual(Resources.InvalidPasswordlength, registrationPage.ReturnInvalidRegistrationErrorMessage());
        }

        [Then(@"I should see an error message for duplicate username")]
        public void ThenIShouldSeeAnErrorMessageForDuplicateUsername()
        {
            Assert.AreEqual(true, registrationPage.VerifyInvalidRegistrationErrorIsDisplayed());
            Assert.AreEqual(Resources.UserAlreadyExists, registrationPage.ReturnInvalidRegistrationErrorMessage());
        }


    }
}