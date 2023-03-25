using System;
using InternetHerokuapp.Driver;
using InternetHerokuapp.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace InternetHerokuapp.Features
{
   
    [Binding]
    public class Validate_Add_Element_Functionaity
    {

        private readonly Add_Remove_Elements_Page _add_remove_Page;

        public Validate_Add_Element_Functionaity(BrowserDriver browserDriver)
        {
            _add_remove_Page = new Add_Remove_Elements_Page(browserDriver.Current);
        }


        [Given(@"user navigates into ""(.*)""")]
        public void GivenUserNavigatesInto(string URL)
        {
            _add_remove_Page.navigateToURL(URL);
        }

        [When(@"user clicks add element BTN ""(.*)"" times")]
        public void WhenUserClicksAddElementBTNTimes(  int num)
        {
            _add_remove_Page.ClickSeveralTime(_add_remove_Page.FirstNumberElement,num);
        }

       
        [Then(@"Verify user see ""(.*)"" Delete BTN generated")]
        public void ThenVerifyUserSeeDeleteBTNGenerated(int num)
        {

            Assert.AreEqual(_add_remove_Page.DeleteBTNElement.Count, num,"Passed there are:  "+num+" elements");

        }


    }
}
