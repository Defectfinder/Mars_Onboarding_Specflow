using Mars_Onboarding_Specflow.Pages;
using Mars_Onboarding_Specflow.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Onboarding_Specflow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinition : CommonDriver
    {


        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Then(@"I should be redirected to the homepage")]
        public void ThenIShouldBeRedirectedToTheHomepage()
        {
            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }


        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
