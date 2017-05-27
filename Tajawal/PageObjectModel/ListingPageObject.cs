using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajawal.PageObjectModel
{
    class ListingPageObject
    {
        public ListingPageObject(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);

        }

       
        [FindsBy(How = How.XPath, Using = "//*[@id='flight-search-summary-modify-wrapper']/div/div/div[2]/div/div[2]/div[1]/p[1]/span/airport-code")]
        public IWebElement Fromairporttext
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='flight-search-summary-modify-wrapper']/div/div/div[2]/div/div[2]/div[1]/p[3]/span/airport-code")]
        public IWebElement Toairporttext
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flight-search-summary-modify-wrapper']/div/div/div[2]/div/div[2]/div[2]/p[1]/span")]
        public IWebElement DepartureDateText
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flight-search-summary-modify-wrapper']/div/div/div[2]/div/div[2]/div[2]/p[3]/span")]
        public IWebElement ArrivalDateText
        {
            get;
            set;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='flight-search-summary-modify-wrapper']/div/div/div[2]/div/div[2]/div[3]/p/span")]
        public IWebElement cabintypetext
        {
            get;
            set;
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='flight-search-summary-modify-wrapper']/div/div/div[2]/div/div[2]/div[4]/p/span")]
        public IWebElement numberofpassengertext
        {
            get;
            set;
        }
        [FindsBy(How=How.XPath,Using ="//*[@id='flights-filters-airline-leg-0-check-exclude-0']")]
        public IWebElement Selectcarrierbuttonarrival
        {
            get;
            set;
        }
     
        [FindsBy(How = How.XPath, Using = "//*[@id='flights-filters-airline-leg-1-check-exclude-0']")]
        public IWebElement Selectcarrierbuttondeparture
        {
            get;
            set;
        }
    }
}
