using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions
    {
        SkillsTab skillsTabPageObj = new SkillsTab();

        [When(@"I navigate to Skills Tab")]
        public void WhenINavigateToSkillsTab()
        {
            skillsTabPageObj.SelectSkillsTab();
        }

        [When(@"I add a new skills , '([^']*)' , '([^']*)'")]
        public void WhenIAddANewSkills(string p0, string p1)
        {
            skillsTabPageObj.AddSkills(p0,p1);           
        }

        [Then(@"The Skill should be added successfully, '([^']*)' , '([^']*)'")]
        public void ThenTheSkillShouldBeAddedSuccessfully(string p0, string p1)
        {
            string  newSkill = skillsTabPageObj.GetLastAddedSkill();
            string newSkillLevel = skillsTabPageObj.GetLastAddedSkillLevel();
            //Console.WriteLine(newSkill);
            //Console.WriteLine(newSkillLevel);
            Assert.That(newSkill, Is.EqualTo(p0));
            Assert.That(newSkillLevel, Is.EqualTo(p1));   
        }
    }
}
