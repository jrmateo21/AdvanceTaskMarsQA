using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.ProfileDetails
{
    public class SkillsTab
    {
        public static IWebElement navToSkillsTab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        public static IWebElement addNewSkilssButton => Driver.driver.FindElement(By.CssSelector("div[class='ui teal button']"));
        public static IWebElement skillsTextbox => Driver.driver.FindElement(By.CssSelector("input[placeholder='Add Skill']"));
        public static IWebElement levelDropdown => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        public static IWebElement addButton => Driver.driver.FindElement(By.CssSelector("input[value='Add']"));

        
        public static IWebElement lastAddedSkill => Driver.driver.FindElement(By.XPath("//*[@data-tab='second']//tbody[last()]/tr/td[1]"));
        public static IWebElement lastAddedSkillLevel => Driver.driver.FindElement(By.XPath("//*[@data-tab='second']//tbody[last()]/tr/td[2]"));



        public void SelectSkillsTab()
        {

            navToSkillsTab.Click();
            

        }

        public void AddSkills(string skill, string level )
        {
            addNewSkilssButton.Click();
            skillsTextbox.SendKeys(skill);
            levelDropdown.SendKeys(level);
            addButton.Click();


        }

        public string GetLastAddedSkill()
        {
            Thread.Sleep(1000);
            return lastAddedSkill.Text;         

        }

        public string GetLastAddedSkillLevel()
        {
            Thread.Sleep(1000);
            return lastAddedSkillLevel.Text;            

        }





    }
}
