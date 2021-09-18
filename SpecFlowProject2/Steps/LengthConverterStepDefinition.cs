using ClassLibrary1;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class LengthConverterStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;

        public LengthConverterStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the length in feet is (.*)")]
        public void GivenTheLengthInFeetIs(decimal input)
        {
            _scenarioContext["input"] = input;
        }

        [When(@"the length in feet is converted to inches")]
        public void WhenTheLengthInFeetIsConvertedToInches()
        {
            _scenarioContext["Result"] = LengthConverter.FeetToInches((decimal)_scenarioContext["input"]);
        }

        [Then(@"the length in inches should be (.*)")]
        public void ThenTheLengthInInchesShouldBe(int result)
        {
            var actual = (decimal)_scenarioContext["Result"];
            actual.Equals(result);
        }
    }
}