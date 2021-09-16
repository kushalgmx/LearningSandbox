using ClassLibrary1;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class MultiplicationStepsDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        public MultiplicationStepsDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"the numbers are multiplied")]
        public void WhenTheNumbersAreMultiplied()
        {
            var calculator = (Calculator)_scenarioContext["Calculator"];
            _scenarioContext["Result"] = calculator.Multiply();
        }

        [Then(@"the product end with (.*)")]
        public void ThenTheProductEndWith(int result)
        {
            var actual = (_scenarioContext["Result"]).ToString();
            actual.EndsWith(result.ToString());
        }
    }
}
