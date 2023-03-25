using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace InternetHerokuapp.PageObjects
{
    public class Add_Remove_Elements_Page
    {
        //The URL of the calculator to be opened in the browser
        private const string Url = "https://the-internet.herokuapp.com/add_remove_elements/";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;

        public Add_Remove_Elements_Page(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Finding elements by ID
        public IWebElement FirstNumberElement => _webDriver.FindElement(By.XPath("//button[.='Add Element']"));
        

        public IList<IWebElement> DeleteBTNElement =>_webDriver.FindElements(By.XPath("//button[.='Delete']"));

        public void navigateToURL(string URL)
        {
            _webDriver.Navigate().GoToUrl(URL);


        }

        public void ClickSeveralTime(IWebElement element,int num)
        {
            for (int i = 0; i < num; i++)
            {
                element.Click();
            }
        }

    }
}
