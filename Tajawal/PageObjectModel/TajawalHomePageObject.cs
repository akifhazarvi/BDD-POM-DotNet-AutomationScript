using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tajawal.PageObjectModel
{
      class TajawalHomePageObject
    {
     
        public static void NaviagtetoUrl()
        {
            Browser.Current.Navigate().GoToUrl("http://www.tajawal.ae");
            PropertiesCollection.driver = Browser.Current;
        }
        public TajawalHomePageObject()
        {
            NaviagtetoUrl();
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }
      
        [FindsBy(How=How.Id,Using= "flights-search-origin-0")]
        public IWebElement OriginInputField
        {
            get;
            set;   
        }
        [FindsBy(How = How.Id, Using = "flights-search-destination-0")]
        public IWebElement DestinationInputField
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[1]/table/tbody/tr[5]/td[4]")]
        public IWebElement DepartureDate
        {
            get;
            set;
        }
      
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/table/tbody/tr[3]/td[4]")]
        public IWebElement ArrivalDate
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flights-search-returnDate-RoundTrip-0']")]
        public IWebElement ArrivalDatepopup
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flights-search-departureDate-RoundTrip-0']")]
        public IWebElement DepartureDatepopup
        {
            get;
            set;

        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flights-search-open-cabin-btn']/ul/li[1]/label")]
        public IWebElement Flighttype
        {
            get;
            set;
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='flights-search-open-cabin-btn']/div/i")]
        public IWebElement Flighttypeinput
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flights-search-open-pax-btn']")]
        public IWebElement Numberofpassengerinput
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='common-pax-counter-add-adult-btn']/i")]
        public IWebElement Numberofpassenger
        {
            get;
            set;
        }
        
        [FindsBy(How = How.Id, Using = "flights-search-cta")]
        public IWebElement SubmitButton
        {
            get;
            set;
        }

       

    }
}
