using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tajawal.PageObjectModel;
using TechTalk.SpecFlow;

namespace Tajawal.Steps
{
    [Binding]
    class SearchResultSteps
    {
        ListingPageObject listpage = new ListingPageObject(Browser.Current);
        [Given(@"Filter results to (.*) carrier")]
        public void GivenFiltertoEmiratesCarrier(string carriername)
        {

            listpage.Selectcarrierbuttondeparture.Click();
            listpage.Selectcarrierbuttonarrival.Click();

        }
        
       [Then(@"Assert listing results are only the selected carrier")]
        public void Assertresultlistingforselectedcarrier(string carriername)
        {

            listpage.Selectcarrierbuttondeparture.Click();
            listpage.Selectcarrierbuttonarrival.Click();

        }
    }
}
