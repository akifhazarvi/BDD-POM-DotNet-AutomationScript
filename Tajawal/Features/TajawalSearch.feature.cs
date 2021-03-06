﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tajawal.Features
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search Flight")]
    public partial class SearchFlightFeature
    {
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TajawalSearch.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            this.container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search Flight", "As a flyer I want to search available flight between abc and xyz on specific Date" +
                    " When number of people are 2 and class is economy\nSo that I can see the results " +
                    "for given date.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
            try { System.Threading.Thread.Sleep(50); this.driver.Quit(); } catch (System.Exception) {}
            this.driver = null;
            ScenarioContext.Current.Remove("Driver");
            ScenarioContext.Current.Remove("Container");
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(this.driver != null)
                ScenarioContext.Current.Add("Driver", this.driver);
            if(this.container != null)
                ScenarioContext.Current.Add("Container", this.container);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        private void InitializeSelenium(string browser)
        {
            this.driver = this.container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Flight Search Module")]
        [NUnit.Framework.CategoryAttribute("SmokeTest")]
        [NUnit.Framework.TestCaseAttribute("Chrome", Category="Chrome", TestName="FlightSearchModule on Chrome")]
        public virtual void FlightSearchModule(string browser)
        {
            InitializeSelenium(browser);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Flight Search Module", new string[] {
                        "SmokeTest",
                        "Browser:Chrome"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have naviagted to Tajawal page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "origin"});
            table1.AddRow(new string[] {
                        "LHE Lahore, Pakistan"});
#line 9
 testRunner.And("I have random array of origin as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Destination"});
            table2.AddRow(new string[] {
                        "Dubai, United Arab Emirates"});
#line 13
 testRunner.And("I have random array of Destinations as", ((string)(null)), table2, "And ");
#line 17
 testRunner.And("I have random dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I have choosed Economy class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I have choosed 2 passengers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("I tap on submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I should see the result for Search parem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
