using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions
    {
        EducationTab educationTabPageObj = new EducationTab();

        [When(@"I navigate to   Education Tab")]
        public void WhenINavigateToEducationTab()
        {
            educationTabPageObj.SelectEducationTab();
        }

        [When(@"I add a new Education , '([^']*)' , '([^']*)', '([^']*)', '([^']*)' , '([^']*)'")]
        public void WhenIAddANewEducation(string p0, string p1, string p2, string p3, string p4)
        {
            educationTabPageObj.AddEducation(p1, p0, p2, p3, p4);
        }

        [Then(@"The Skill should be added successfully, '([^']*)' , '([^']*)', '([^']*)', '([^']*)' , '([^']*)'")]
        public void ThenTheSkillShouldBeAddedSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {
            string newCountry = educationTabPageObj.GetLastAddedCountry();
            string newUni= educationTabPageObj.GetLastAddedUni();
            string newTitle= educationTabPageObj.GetLastAddedTitle();
            string newDegree = educationTabPageObj.GetLastAddedDegree();
            string newGradYr= educationTabPageObj.GetLastAddedGradYr(); 

            Assert.That(newCountry, Is.EqualTo(p0));
            Assert.That(newUni, Is.EqualTo(p1));
            Assert.That(newTitle, Is.EqualTo(p2));
            Assert.That(newDegree, Is.EqualTo(p3));
            Assert.That(newGradYr, Is.EqualTo(p4));
            

        }

        //Update Entry
        [When(@"I  Update   Education entry  , '([^']*)' , '([^']*)', '([^']*)', '([^']*)' , '([^']*)'")]
        public void WhenIUpdateEducationEntry(string p0, string p1, string p2, string p3, string p4)
        {
            educationTabPageObj.UpdateEducationpublic(p1, p0, p2, p3, p4);
        }

        [Then(@"The Skill should be Updated successfully, '([^']*)' , '([^']*)', '([^']*)', '([^']*)' , '([^']*)'")]
        public void ThenTheSkillShouldBeUpdatedSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {
            string updatedCountry = educationTabPageObj.GetLastUpdatedCountry();
            string updatedUni = educationTabPageObj.GetLastUpdatedUni();
            string updatedTitle = educationTabPageObj.GetLastUpdatedTitle();
            string updatedDegree = educationTabPageObj.GetLastUpdatedDegree();
            string updatedGradYr = educationTabPageObj.GetLastUpdatedGradYr();


            Assert.That(updatedCountry, Is.EqualTo(p0));
            Assert.That(updatedUni, Is.EqualTo(p1));
            Assert.That(updatedTitle, Is.EqualTo(p2));
            Assert.That(updatedDegree, Is.EqualTo(p3));
            Assert.That(updatedGradYr, Is.EqualTo(p4));





        }




    }
}
