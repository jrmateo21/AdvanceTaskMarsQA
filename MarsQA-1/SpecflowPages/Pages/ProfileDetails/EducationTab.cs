using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class EducationTab
    {

        private static IWebElement navToEducationTab => Driver.driver.FindElement(By.CssSelector("a[data-tab='third']"));
        private static IWebElement addNewButton => Driver.driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button')][normalize-space()='Add New'])[3]"));
        private static IWebElement collegeTextBox => Driver.driver.FindElement(By.CssSelector("input[placeholder='College/University Name']"));
        private static IWebElement countryDropDown => Driver.driver.FindElement(By.CssSelector("select[name='country']"));
        private static IWebElement titleDropDown => Driver.driver.FindElement(By.CssSelector("select[name='title']"));
        private static IWebElement degreeTextBox => Driver.driver.FindElement(By.CssSelector("input[placeholder='Degree']"));
        private static IWebElement yearDropDown => Driver.driver.FindElement(By.CssSelector("select[name='yearOfGraduation']"));
        private static IWebElement addButton => Driver.driver.FindElement(By.CssSelector("input[value='Add']"));

        private static IWebElement getLastAddedCountry => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[last()]/tr/td[1]"));
        private static IWebElement getLastAddedUni => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[last()]/tr/td[2]"));
        private static IWebElement getLastAddedTitle => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[last()]/tr/td[3]"));
        private static IWebElement getLastAddedDegree => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[last()]/tr/td[4]"));
        private static IWebElement getLastAddedGradYr => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[last()]/tr/td[5]"));


        //Modify Entry

        private static IWebElement updateIconButton => Driver.driver.FindElement(By.XPath(" //*[@class = 'ui fixed table']/tbody[1]/tr/td[6]/span[1]/i"));
        private static IWebElement updateButton => Driver.driver.FindElement(By.XPath("(//input[@value='Update'])[last()]"));


        private static IWebElement getLastUpdatedCountry => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]/tr/td[1]"));
        private static IWebElement getLastUpdatedUni => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]/tr/td[2]"));
        private static IWebElement getLastUpdatedTitle => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]/tr/td[3]"));
        private static IWebElement getLastUpdatedDegree => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]/tr/td[4]"));
        private static IWebElement getLastUpdatedGradYr => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]/tr/td[5]"));



        public void SelectEducationTab()
        {

            navToEducationTab.Click();

        }

        public void AddEducation(string College, string Country, string Title, string Degree, string GraduationYear)
        {
            addNewButton.Click();
            collegeTextBox.SendKeys(College);
            countryDropDown.SendKeys(Country);
            titleDropDown.SendKeys(Title);
            degreeTextBox.SendKeys(Degree);
            yearDropDown.SendKeys(GraduationYear);
            addButton.Click();


        }


        public string GetLastAddedCountry()
        {
            Thread.Sleep(3000);
            return getLastAddedCountry.Text;
        }

        public string GetLastAddedUni()
        {
            Thread.Sleep(1000);
            return getLastAddedUni.Text;
        }

        public string GetLastAddedTitle()
        {
            Thread.Sleep(1000);
            return getLastAddedTitle.Text;
        }

        public string GetLastAddedDegree()
        {
            Thread.Sleep(1000);
            return getLastAddedDegree.Text;
        }

        public string GetLastAddedGradYr()
        {
            Thread.Sleep(1000);
            return getLastAddedGradYr.Text;
        }


        //Modify Entry


        public string GetLastUpdatedCountry()
        {
            Thread.Sleep(3000);
            return getLastUpdatedCountry.Text;
        }

        public string GetLastUpdatedUni()
        {
            Thread.Sleep(1000);
            return getLastUpdatedUni.Text;
        }

        public string GetLastUpdatedTitle()
        {
            Thread.Sleep(1000);
            return getLastUpdatedTitle.Text;
        }

        public string GetLastUpdatedDegree()
        {
            Thread.Sleep(1000);
            return getLastUpdatedDegree.Text;
        }

        public string GetLastUpdatedGradYr()
        {
            Thread.Sleep(1000);
            return getLastUpdatedGradYr.Text;
        }

        public void UpdateEducationpublic(string College, string Country, string Title, string Degree, string GraduationYear)
        {
            Thread.Sleep(1000);
            updateIconButton.Click();
            //clear all the textbox 
            collegeTextBox.Clear();            
            degreeTextBox.Clear();
            //update             
            collegeTextBox.SendKeys(College);            
            countryDropDown.SendKeys(Country);            
            titleDropDown.SendKeys(Title);            
            degreeTextBox.SendKeys(Degree);            
            yearDropDown.SendKeys(GraduationYear);
            updateButton.Click();

        }

    }
}
