using ClassLibrary1;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class SubtractionStepsDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SubtractionStepsDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the minuend is (.*)")]
        public void GivenTheMinuendIs(int minuend)
        {
            _scenarioContext["Calculator"] = new Calculator { FirstNumber = minuend };
        }

        [Given("the subtrahend is (.*)")]
        public void GivenTheSecondNumberIs(int subtrahend)
        {
            var calculator = (Calculator)_scenarioContext["Calculator"];
            calculator.SecondNumber = subtrahend;
        }

        [When(@"the subtrahend is subtracted from the minuend")]
        public void WhenTheSubtrahendIsSubtractedFromTheMinuend()
        {
            var calculator = (Calculator)_scenarioContext["Calculator"];
            _scenarioContext["Result"] = calculator.Subtract();
        }

        [Then(@"the subtraction result should be (.*)")]
        public void ThenTheSubtractionResultShouldBe(int result)
        {
            var actual = (int)_scenarioContext["Result"];
            actual.Equals(result);
        }
    }
}
