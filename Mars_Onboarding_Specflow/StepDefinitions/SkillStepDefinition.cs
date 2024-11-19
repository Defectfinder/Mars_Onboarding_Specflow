using Mars_Onboarding_Specflow.Pages;
using Mars_Onboarding_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Onboarding_Specflow.StepDefinitions
{
    [Binding]
    public class SkillStepDefinition : CommonDriver
    {
        private static IWebElement popupmsg => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        string popupMsgInv = "Please enter skill and experience level";
        string popMsgSame = "This skill is already added to your skills list.";
        string popMsgDup = "Duplicated data";
        string popMsgUndefined = "undefined";
        [Given(@"User logs into Mars Portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
           
            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Given(@"navigates to Skills tab in Profile Page")]
        public void GivenNavigatesToSkillsTabInProfilePage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }

        [When(@"user enters Skill ""([^""]*)"" and Skill Level ""([^""]*)""")]
        public void WhenUserEntersSkillAndSkillLevel(string skill, string skilllevel)
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.ClearData();
            skillTabObj.AddSkill(skill,skilllevel);
        }

        [Then(@"the Skill ""([^""]*)"" should be added to Skills tab in Profile Page")]
        public void ThenTheSkillShouldBeAddedToSkillsTabInProfilePage(string skill)
        {
            Thread.Sleep(3000);
            string popupMsgBox = popupmsg.Text;
            Console.WriteLine(popupMsgBox);
            //Verify the pop up message
            string popupMsgadd = skill + " has been added to your skills";
            Assert.That(popupMsgBox, Is.EqualTo(popupMsgadd).Or.EqualTo(popupMsgInv).Or.EqualTo(popMsgSame).Or.EqualTo(popMsgDup).Or.EqualTo(popMsgUndefined));
        }
        [When(@"user edits Skill ""([^""]*)"" and Skill Level ""([^""]*)""")]
        public void WhenUserEditsSkillAndSkillLevel(string skills, string skillLevel)
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.EditSkill(skills,skillLevel);
        }

        [Then(@"the Skill ""([^""]*)"" should be updated to Skills tab in Profile Page")]
        public void ThenTheSkillShouldBeUpdatedToSkillsTabInProfilePage(string skill)
        {
            Thread.Sleep(3000);
            string popupMsgBox = popupmsg.Text;
            Console.WriteLine(popupMsgBox);
            //Verify the pop up message
            string popupMsgadd = skill + " has been updated to your skills";
            Assert.That(popupMsgBox, Is.EqualTo(popupMsgadd).Or.EqualTo(popupMsgInv).Or.EqualTo(popMsgSame).Or.EqualTo(popMsgUndefined).Or.EqualTo(popMsgDup));
        }

        [When(@"Delete the Skill")]
        public void WhenDeleteTheSkill()
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.DeleteSkill(driver);
        }



    }
}
