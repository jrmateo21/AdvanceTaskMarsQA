using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.Profile
{
    public class LanguagesTab
    {

        private static IWebElement navToLanguagesTab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));
        private static IWebElement addNewButton => Driver.driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button')][normalize-space()='Add New'])[1]"));
        private static IWebElement addLanguageText => Driver.driver.FindElement(By.CssSelector("input[placeholder='Add Language']"));
        private static IWebElement selectLanguageLevel => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private static IWebElement clickAddButton => Driver.driver.FindElement(By.CssSelector("input[value='Add']"));
        private static IWebElement addedLanguage => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]/tr/td[1]"));


        public void SelectLanguagesTab()
        {

            navToLanguagesTab.Click();

        }

        public void AddLanguages()
        {
            addNewButton.Click();
            addLanguageText.SendKeys("English");
            selectLanguageLevel.SendKeys("Basic");
            clickAddButton.Click();

        }

        public string GetAddedLanguage()
        {

            return addedLanguage.Text;

        }
    }
}
