using ClassLibrary1;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _scenarioContext["Calculator"] = new Calculator { FirstNumber = firstNumber };
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            var calculator = (Calculator)_scenarioContext["Calculator"];
            calculator.SecondNumber = secondNumber;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var calculator = (Calculator)_scenarioContext["Calculator"];
            _scenarioContext["Result"] = calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            var actual = (int)_scenarioContext["Result"];
            actual.Should().Be(result);
        }
    }
}
