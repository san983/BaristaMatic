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
namespace BaristaMatic.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Stock calculation")]
    public partial class StockCalculationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StockCalculation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Stock calculation", "In order to know the ingredients stock\r\nAs a user\r\nI want the machine to calculat" +
                    "e it", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Initial Stock")]
        public virtual void InitialStock()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Initial Stock", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("a full loaded barista matic coffee machine");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units",
                        "UnitCost"});
            table1.AddRow(new string[] {
                        "Coffee",
                        "10",
                        "0.75"});
            table1.AddRow(new string[] {
                        "Decaf Coffee",
                        "10",
                        "0.75"});
            table1.AddRow(new string[] {
                        "Sugar",
                        "10",
                        "0.25"});
            table1.AddRow(new string[] {
                        "Cream",
                        "10",
                        "0.25"});
            table1.AddRow(new string[] {
                        "Steamed Milk",
                        "10",
                        "0.35"});
            table1.AddRow(new string[] {
                        "Foamed Milk",
                        "10",
                        "0.35"});
            table1.AddRow(new string[] {
                        "Espresso",
                        "10",
                        "1.10"});
            table1.AddRow(new string[] {
                        "Cocoa",
                        "10",
                        "0.90"});
            table1.AddRow(new string[] {
                        "Whipped Cream",
                        "10",
                        "1.00"});
#line 8
 testRunner.Then("the stock and unit cost should be", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Just one coffee")]
        public virtual void JustOneCoffee()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one coffee", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("a full loaded barista matic coffee machine");
#line 22
 testRunner.When("I press 5");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table2.AddRow(new string[] {
                        "Coffee",
                        "7"});
            table2.AddRow(new string[] {
                        "Decaf Coffee",
                        "10"});
            table2.AddRow(new string[] {
                        "Sugar",
                        "9"});
            table2.AddRow(new string[] {
                        "Cream",
                        "9"});
            table2.AddRow(new string[] {
                        "Steamed Milk",
                        "10"});
            table2.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table2.AddRow(new string[] {
                        "Espresso",
                        "10"});
            table2.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table2.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 23
 testRunner.Then("the stock should be", ((string)(null)), table2);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Just one decaf coffee")]
        public virtual void JustOneDecafCoffee()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one decaf coffee", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("a full loaded barista matic coffee machine");
#line 37
 testRunner.When("I press 6");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table3.AddRow(new string[] {
                        "Coffee",
                        "10"});
            table3.AddRow(new string[] {
                        "Decaf Coffee",
                        "7"});
            table3.AddRow(new string[] {
                        "Sugar",
                        "9"});
            table3.AddRow(new string[] {
                        "Cream",
                        "9"});
            table3.AddRow(new string[] {
                        "Steamed Milk",
                        "10"});
            table3.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table3.AddRow(new string[] {
                        "Espresso",
                        "10"});
            table3.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table3.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 38
 testRunner.Then("the stock should be", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Just one Caffe Latte")]
        public virtual void JustOneCaffeLatte()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one Caffe Latte", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
 testRunner.Given("a full loaded barista matic coffee machine");
#line 52
 testRunner.When("I press 2");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table4.AddRow(new string[] {
                        "Coffee",
                        "10"});
            table4.AddRow(new string[] {
                        "Decaf Coffee",
                        "10"});
            table4.AddRow(new string[] {
                        "Sugar",
                        "10"});
            table4.AddRow(new string[] {
                        "Cream",
                        "10"});
            table4.AddRow(new string[] {
                        "Steamed Milk",
                        "9"});
            table4.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table4.AddRow(new string[] {
                        "Espresso",
                        "8"});
            table4.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table4.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 53
 testRunner.Then("the stock should be", ((string)(null)), table4);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Just one Caffe Americano")]
        public virtual void JustOneCaffeAmericano()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one Caffe Americano", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("a full loaded barista matic coffee machine");
#line 67
 testRunner.When("I press 1");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table5.AddRow(new string[] {
                        "Coffee",
                        "10"});
            table5.AddRow(new string[] {
                        "Decaf Coffee",
                        "10"});
            table5.AddRow(new string[] {
                        "Sugar",
                        "10"});
            table5.AddRow(new string[] {
                        "Cream",
                        "10"});
            table5.AddRow(new string[] {
                        "Steamed Milk",
                        "10"});
            table5.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table5.AddRow(new string[] {
                        "Espresso",
                        "7"});
            table5.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table5.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 68
 testRunner.Then("the stock should be", ((string)(null)), table5);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Just one Caffe Mocha")]
        public virtual void JustOneCaffeMocha()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one Caffe Mocha", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
 testRunner.Given("a full loaded barista matic coffee machine");
#line 82
 testRunner.When("I press 3");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table6.AddRow(new string[] {
                        "Coffee",
                        "10"});
            table6.AddRow(new string[] {
                        "Decaf Coffee",
                        "10"});
            table6.AddRow(new string[] {
                        "Sugar",
                        "10"});
            table6.AddRow(new string[] {
                        "Cream",
                        "10"});
            table6.AddRow(new string[] {
                        "Steamed Milk",
                        "9"});
            table6.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table6.AddRow(new string[] {
                        "Espresso",
                        "9"});
            table6.AddRow(new string[] {
                        "Cocoa",
                        "9"});
            table6.AddRow(new string[] {
                        "Whipped Cream",
                        "9"});
#line 83
 testRunner.Then("the stock should be", ((string)(null)), table6);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Just one Cappuccino")]
        public virtual void JustOneCappuccino()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one Cappuccino", ((string[])(null)));
#line 95
this.ScenarioSetup(scenarioInfo);
#line 96
 testRunner.Given("a full loaded barista matic coffee machine");
#line 97
 testRunner.When("I press 4");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table7.AddRow(new string[] {
                        "Coffee",
                        "10"});
            table7.AddRow(new string[] {
                        "Decaf Coffee",
                        "10"});
            table7.AddRow(new string[] {
                        "Sugar",
                        "10"});
            table7.AddRow(new string[] {
                        "Cream",
                        "10"});
            table7.AddRow(new string[] {
                        "Steamed Milk",
                        "9"});
            table7.AddRow(new string[] {
                        "Foamed Milk",
                        "9"});
            table7.AddRow(new string[] {
                        "Espresso",
                        "8"});
            table7.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table7.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 98
 testRunner.Then("the stock should be", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Restock")]
        public virtual void Restock()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Restock", ((string[])(null)));
#line 110
this.ScenarioSetup(scenarioInfo);
#line 111
 testRunner.Given("a full loaded barista matic coffee machine");
#line 112
 testRunner.When("I press 5");
#line 113
 testRunner.And("I press 6");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table8.AddRow(new string[] {
                        "Coffee",
                        "7"});
            table8.AddRow(new string[] {
                        "Decaf Coffee",
                        "7"});
            table8.AddRow(new string[] {
                        "Sugar",
                        "8"});
            table8.AddRow(new string[] {
                        "Cream",
                        "8"});
            table8.AddRow(new string[] {
                        "Steamed Milk",
                        "10"});
            table8.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table8.AddRow(new string[] {
                        "Espresso",
                        "10"});
            table8.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table8.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 114
 testRunner.Then("the stock should be", ((string)(null)), table8);
#line 125
 testRunner.When("I press R");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ingredient",
                        "Units"});
            table9.AddRow(new string[] {
                        "Coffee",
                        "10"});
            table9.AddRow(new string[] {
                        "Decaf Coffee",
                        "10"});
            table9.AddRow(new string[] {
                        "Sugar",
                        "10"});
            table9.AddRow(new string[] {
                        "Cream",
                        "10"});
            table9.AddRow(new string[] {
                        "Steamed Milk",
                        "10"});
            table9.AddRow(new string[] {
                        "Foamed Milk",
                        "10"});
            table9.AddRow(new string[] {
                        "Espresso",
                        "10"});
            table9.AddRow(new string[] {
                        "Cocoa",
                        "10"});
            table9.AddRow(new string[] {
                        "Whipped Cream",
                        "10"});
#line 126
  testRunner.Then("the stock should be", ((string)(null)), table9);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion