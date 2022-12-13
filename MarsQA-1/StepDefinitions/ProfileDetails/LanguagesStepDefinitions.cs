using MarsQA_1.SpecflowPages.Pages.Profile;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]

    public class LanguagesStepDefinitions

       
    {
        LanguagesTab languagesTabPageObj = new LanguagesTab();

        [When(@"I navigate to Languages")]
        public void WhenINavigateToLanguages()
        {
            languagesTabPageObj.SelectLanguagesTab();  
        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {
            languagesTabPageObj.AddLanguages();
        }

        [Then(@"The language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
           string newAddedLanguage = languagesTabPageObj.GetAddedLanguage();
           Console.WriteLine(newAddedLanguage);

           Assert.That(newAddedLanguage =="English", "Actual Language and expected language do not match");


        }
    }
}
