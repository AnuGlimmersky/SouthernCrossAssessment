using NUnit.Framework;
using OpenQA.Selenium;
using SouthernCrossAssessment.PageObjects;

namespace SouthernCrossAssessment.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        HomePage homePage;
        RegistrationPage registrationPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"that I have navigated to Buggy Cars website")]
        public void GivenThatIAmInRegistrationPage()
        {
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");
        }

        [Given(@"I have clicked on Register button")]
        public void GivenIClickOnRegisterButton()
        {
            homePage = new HomePage(driver);
            homePage.ClickRegisterButton();
        }

        [Given(@"I have filled username as '([^']*)', First name as'([^']*)' and Last name as '([^']*)'")]
        public void GivenIHaveFilledUsernameAsFirstNameAsAndLastNameAs(string username, string firstName, string lastName)
        {
            registrationPage = new RegistrationPage(driver);
            registrationPage.EnterUsername(username);
            registrationPage.EnterFirstName(firstName);
            registrationPage.EnterLastName(lastName);
        }

        [When(@"I enter valid password and confirm password as '([^']*)'")]
        public void WhenIEnterValidPasswordAndConfirmPasswordAs(string password)
        {
            registrationPage = new RegistrationPage(driver);
            registrationPage.EnterPassword(password);
            registrationPage.EnterConfirmPassword(password);
            Thread.Sleep(2000);
        }

        [When(@"I click Register button")]
        public void WhenIClickRegisterButton()
        {
            registrationPage = new RegistrationPage(driver);
            registrationPage.ClickSubmitButton();
            Thread.Sleep(2000);
        }

        [Then(@"I should see a registration successful message")]
        public void ThenIShouldSeeARegistrationSuccessfulMessage()
        {
            registrationPage = new RegistrationPage(driver);
            Assert.AreEqual(true, registrationPage.VerifyRegistrationSuccessfulMessage());
        }







    }
}