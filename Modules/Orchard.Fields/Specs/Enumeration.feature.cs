﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Fields.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Enumeration Field")]
    public partial class EnumerationFieldFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Enumeration.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Enumeration Field", "  In order to add a list of elements to my types\r\nAs an administrator\r\n  I want t" +
                    "o create, edit and publish Enumeration fields", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Creating and using Enumeration fields")]
        public virtual void CreatingAndUsingEnumerationFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using Enumeration fields", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have installed Orchard");
#line 10
  testRunner.And("I have installed \"Orchard.Fields\"");
#line 11
    testRunner.When("I go to \"Admin/ContentTypes\"");
#line 12
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"");
#line 13
    testRunner.When("I go to \"Admin/ContentTypes/Create\"");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table1.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 14
        testRunner.And("I fill in", ((string)(null)), table1);
#line 18
        testRunner.And("I hit \"Create\"");
#line 19
        testRunner.And("I go to \"Admin/ContentTypes/\"");
#line 20
    testRunner.Then("I should see \"Event\"");
#line 23
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line 24
  testRunner.And("I follow \"Add Field\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "DisplayName",
                        "Location"});
            table2.AddRow(new string[] {
                        "Name",
                        "Location"});
            table2.AddRow(new string[] {
                        "FieldTypeName",
                        "EnumerationField"});
#line 25
  testRunner.And("I fill in", ((string)(null)), table2);
#line 30
  testRunner.And("I hit \"Save\"");
#line 31
  testRunner.And("I am redirected");
#line 32
 testRunner.Then("I should see \"The \\\"Location\\\" field has been added.\"");
#line 35
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.Options",
                        "Seattle"});
#line 36
  testRunner.And("I fill in", ((string)(null)), table3);
#line 39
  testRunner.And("I hit \"Save\"");
#line 40
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 41
 testRunner.Then("I should see \"<option>Seattle</option>\"");
#line 44
 testRunner.When("I go to \"Admin/Contents/Create/Event\"");
#line 45
 testRunner.Then("I should see \"Location\"");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Event.Location.Value",
                        "Seattle"});
#line 46
 testRunner.When("I fill in", ((string)(null)), table4);
#line 49
  testRunner.And("I hit \"Save\"");
#line 50
  testRunner.And("I am redirected");
#line 51
 testRunner.Then("I should see \"Your Event has been created.\"");
#line 52
 testRunner.When("I go to \"Admin/Contents/List\"");
#line 53
 testRunner.Then("I should see \"Location:\"");
#line 54
  testRunner.And("I should see \"Seattle\"");
#line 57
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.Hint",
                        "Please select a location"});
#line 58
  testRunner.And("I fill in", ((string)(null)), table5);
#line 61
  testRunner.And("I hit \"Save\"");
#line 62
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 63
 testRunner.Then("I should see \"Please select a location\"");
#line 66
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.ListMode",
                        "Dropdown"});
#line 67
  testRunner.And("I fill in", ((string)(null)), table6);
#line 70
  testRunner.And("I hit \"Save\"");
#line 71
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 72
 testRunner.Then("I should see \"select id=\\\"Event_Location_Value\\\" name=\\\"Event.Location.Value\\\"\"");
#line 75
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.ListMode",
                        "Radiobutton"});
#line 76
  testRunner.And("I fill in", ((string)(null)), table7);
#line 79
  testRunner.And("I hit \"Save\"");
#line 80
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 81
 testRunner.Then("I should see \"input id=\\\"Event_Location_Value\\\" name=\\\"Event.Location.Value\\\" typ" +
                    "e=\\\"radio\\\"\"");
#line 84
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.ListMode",
                        "Listbox"});
#line 85
  testRunner.And("I fill in", ((string)(null)), table8);
#line 88
  testRunner.And("I hit \"Save\"");
#line 89
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 90
 testRunner.Then("I should see \"select id=\\\"Event_Location_SelectedValues\\\" multiple=\\\"multiple\\\" n" +
                    "ame=\\\"Event.Location.SelectedValues\\\"\"");
#line 93
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.ListMode",
                        "Checkbox"});
#line 94
  testRunner.And("I fill in", ((string)(null)), table9);
#line 97
  testRunner.And("I hit \"Save\"");
#line 98
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 99
 testRunner.Then("I should see \"input type=\\\"checkbox\\\" name=\\\"Event.Location.SelectedValues\\\"\"");
#line 102
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Fields[0].EnumerationFieldSettings.Required",
                        "true"});
#line 103
  testRunner.And("I fill in", ((string)(null)), table10);
#line 106
  testRunner.And("I hit \"Save\"");
#line 107
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 108
  testRunner.And("I hit \"Save\"");
#line 109
 testRunner.Then("I should see \"The field Location is mandatory.\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
