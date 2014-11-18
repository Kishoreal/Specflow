// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Bowling.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ScoreCalculationAlternativeFormsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScoreCalculationAlternatives.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Score Calculation (alternative forms)", "In order to know my performance\r\nAs a player\r\nI want the system to calculate my t" +
                    "otal score", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("One single spare")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation (alternative forms)")]
        public virtual void OneSingleSpare()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("One single spare", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("a new bowling game");
#line 9
testRunner.When("I roll the following series:\t3,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1");
#line 10
testRunner.Then("my total score should be 29");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All spares")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation (alternative forms)")]
        public virtual void AllSpares()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All spares", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
testRunner.Given("a new bowling game");
#line 14
testRunner.When("I roll 10 times 1 and 9");
#line 15
testRunner.And("I roll 1");
#line 16
testRunner.Then("my total score should be 110");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Yet another beginners game")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation (alternative forms)")]
        public virtual void YetAnotherBeginnersGame()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Yet another beginners game", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
testRunner.Given("a new bowling game");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Pins"});
            table1.AddRow(new string[] {
                        "2"});
            table1.AddRow(new string[] {
                        "7"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "5"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "3"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "4"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "8"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
#line 20
testRunner.When("I roll", ((string)(null)), table1);
#line 42
testRunner.Then("my total score should be 43");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
