﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BaristaMatic.Specflow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Inventory And Menu Display")]
    public partial class InventoryAndMenuDisplayFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "InventoryAndMenuDisplay.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Inventory And Menu Display", "In order to show inventory and available drinks\r\nAs a client\r\nI want to be told t" +
                    "he inventory of ingredients and available drinks with each correspondent cost", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inventory Display at Startup")]
        public virtual void InventoryDisplayAtStartup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inventory Display at Startup", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("a full loaded barista matic coffee machine");
#line 8
 testRunner.When("I start the machine");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "OutputLine"});
            table1.AddRow(new string[] {
                        "Inventory:"});
            table1.AddRow(new string[] {
                        "Cocoa,10"});
            table1.AddRow(new string[] {
                        "Coffee,10"});
            table1.AddRow(new string[] {
                        "Cream,10"});
            table1.AddRow(new string[] {
                        "Decaf Coffee,10"});
            table1.AddRow(new string[] {
                        "Espresso,10"});
            table1.AddRow(new string[] {
                        "Foamed Milk,10"});
            table1.AddRow(new string[] {
                        "Steamed Milk,10"});
            table1.AddRow(new string[] {
                        "Sugar,10"});
            table1.AddRow(new string[] {
                        "Whipped Cream,10"});
            table1.AddRow(new string[] {
                        "Menu:"});
            table1.AddRow(new string[] {
                        "1,Caffe Americano,$3.30,true"});
            table1.AddRow(new string[] {
                        "2,Caffe Latte,$2.55,true"});
            table1.AddRow(new string[] {
                        "3,Caffe Mocha,$3.35,true"});
            table1.AddRow(new string[] {
                        "4,Cappuccino,$2.90,true"});
            table1.AddRow(new string[] {
                        "5,Coffee,$2.75,true"});
            table1.AddRow(new string[] {
                        "6,Decaf Coffee,$2.75,true"});
#line 9
 testRunner.Then("the console output should read like this", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
