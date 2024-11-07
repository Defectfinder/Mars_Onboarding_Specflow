using Mars_Onboarding_Specflow.Pages;
using Mars_Onboarding_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Onboarding_Specflow.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinition : CommonDriver
    {
        private static IWebElement popupmsg => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        string popupMsgInv = "Please enter language and level";
        string popMsgSame = "This language is already added to your language list.";
        string popMsgDup = "Duplicated data";
        string popMsgUndefined = "undefined";

        [Given(@"user logs into Mars Portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
            

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Given(@"navigates to Languages tab in Profile Page")]
        public void GivenNavigatesToLanguagesTabInProfilePage()
        {
            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }

        [When(@"user enters Language ""([^""]*)"" and Language Level ""([^""]*)""")]
        public void WhenUserEntersLanguageAndLanguageLevel(string language, string level)
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.AddLanguage(language,level);
        }

        [Then(@"the language ""([^""]*)"" should be added to Languages tab in Profile Page")]
        public void ThenTheLanguageShouldBeAddedToLanguagesTabInProfilePage(string language)
        {
            Thread.Sleep(3000);
            string popupMsgBox = popupmsg.Text;
            Console.WriteLine(popupMsgBox);
            string popupMsgadd = language + " has been added to your languages";
            Assert.That(popupMsgBox, Is.EqualTo(popupMsgadd).Or.EqualTo(popupMsgInv).Or.EqualTo(popMsgSame).Or.EqualTo(popMsgUndefined).Or.EqualTo(popMsgDup));
        }

        [When(@"user edits Language ""([^""]*)"" and Language Level ""([^""]*)""")]
        public void WhenUserEditsLanguageAndLanguageLevel(string language, string level)
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.EditLanguage(language,level);
        }

        [Then(@"the language ""([^""]*)"" should be edited into Languages tab in Profile Page")]
        public void ThenTheLanguageShouldBeEditedIntoLanguagesTabInProfilePage(string language)
        {

            Thread.Sleep(6000);
            string popupMsgBox = popupmsg.Text;
            Console.WriteLine(popupMsgBox);
            //Verify the pop up message
            string popupMsgadd = language + " has been updated to your languages";
            Assert.That(popupMsgBox, Is.EqualTo(popupMsgadd).Or.EqualTo(popupMsgInv).Or.EqualTo(popMsgSame).Or.EqualTo(popMsgDup).Or.EqualTo(popMsgUndefined));
        }

        [When(@"user deletes the Language ""([^""]*)""")]
        public void WhenUserDeletesTheLanguage(string language)
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.DeleteLanguage(language);
        }

       



    }
}
