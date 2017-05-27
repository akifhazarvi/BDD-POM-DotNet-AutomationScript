using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using Tajawal.PageObjectModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace Tajawal.Steps
{
 [Binding]
    class TajawalSearchSteps
    {
        TajawalHomePageObject pageobject = new TajawalHomePageObject();

        [Given(@"I have naviagted to Tajawal page")]
        public void GivenIhavenavigatedToGooglePage()
        {
           


        }
    
        [Given(@"I have random array of origin as")]
        public void GivenIHaveRandomArrayOfOriginAs(Table table)
        {
            
            dynamic tableDetails = table.CreateDynamicInstance();
            string origin = tableDetails.origin;
            pageobject.OriginInputField.SendKeys(origin);


        }

        [Given(@"I have random array of Destinations as")]
        public void AndIHaveRandomArrayOfDestinationsas(Table table)
        {
            dynamic tableDetails = table.CreateDynamicInstance();
            string destination = tableDetails.Destination;
            pageobject.DestinationInputField.SendKeys(destination);
        }
        [Given(@"I have random dates")]
        public void AndIhaveRandomDatesAs()
        {

            pageobject.DepartureDatepopup.Click();
            Thread.Sleep(2000);
            pageobject.DepartureDate.Click();
            Thread.Sleep(5000);
           
            
        }

        [Given(@"I have choosed (.*) class")]
        public void AndIHaveChoosedEconomyClass(string type)
        {
            pageobject.Flighttypeinput.Click();
            Thread.Sleep(2000);
            pageobject.Flighttype.Click();

        }

        [Given(@"I have choosed (.*) passengers")]
        public void Ihavechoosedpassengers(int passenger_number)
        {
            pageobject.Numberofpassengerinput.Click();
            Thread.Sleep(2000);
            pageobject.Numberofpassenger.Click();
            Thread.Sleep(3000);
        }
        [When(@"I tap on submit button")]
        public void WhenITapOnSubmitButton()
        {
            pageobject.SubmitButton.Click();

        }

        [Then(@"I should see the result for Search parem")]
        public void IShouldSeeTheResultForSearchParem()
        {
          
           Thread.Sleep(30000);
        
            ListingPageObject Listpage= new ListingPageObject(Browser.Current);
            string fromairport=Listpage.Fromairporttext.Text;
            string toairport= Listpage.Toairporttext.Text;
            string departuredate =Listpage.DepartureDateText.Text;
            string arrivaldate =Listpage.ArrivalDateText.Text;
            string cabintype =Listpage.cabintypetext.Text;
            string No_passenger =Listpage.numberofpassengertext.Text;

        }
    }
}
