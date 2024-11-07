using Mars_Onboarding_Specflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Onboarding_Specflow.Pages
{
    public class SkillTab : CommonDriver
    {
        private static IWebElement skillTabSelect => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement addSkillButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement skillTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement selectSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement editSkillIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private static IWebElement editTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        private static IWebElement editSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
        private static IWebElement updateSkillButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        private static IWebElement selectSkillTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement deleteSkillIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

        public void AddSkill(string skill, string skillLevel)
        {
            // Select the Skill Tab
            skillTabSelect.Click();
            Thread.Sleep(2000);
            //Add the Skill
            addSkillButton.Click();
            //Skill add in the Textbox
            skillTextbox.SendKeys(skill);
            //Select the level 
            selectSkillLevel.Click();
            Thread.Sleep(4000);
            skillTextbox.SendKeys(skillLevel);
            Thread.Sleep(3000);
            // Add the Skill entered
            addButton.Click();
        }
        public void EditSkill(string skills,string skillLevel)
        {
            skillTabSelect.Click();
            //select the update button
            editSkillIcon.Click();
            editTextbox.Clear();
            editTextbox.SendKeys(skills);
            Thread.Sleep(2000);
            //select the level 
            editSkillLevel.Click();
            Thread.Sleep(3000);
            editSkillLevel.SendKeys(skillLevel);
            Thread.Sleep(5000);
            updateSkillButton.Click();


        }
        public void DeleteSkill(IWebDriver driver)
        {
            
            selectSkillTab.Click();
            Thread.Sleep(3000);

            deleteSkillIcon.Click();
        }
    }
}
