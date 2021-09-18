using ClassLibrary1;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class LengthConverterStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private decimal _input, _output;

        public LengthConverterStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the length is (.*)")]
        public void GivenTheLengthInFeetIs(decimal input)
        {
            _input = input;
        }

        [When(@"the length in feet is converted to inches")]
        public void WhenTheLengthInFeetIsConvertedToInches()
        {
            _output = LengthConverter.FeetToInches(_input);
        }

        [When(@"the length in inches is converted to feet")]
        public void WhenTheLengthInInchesIsConvertedToFeet()
        {
            _output = LengthConverter.InchesToFeet(_input);
        }

        [When(@"the length in meters is converted to feet")]
        public void WhenTheLengthInMetersIsConvertedToFeet()
        {
            _output = LengthConverter.MetersToFeet(_input);
        }

        [When(@"the length in feet is converted to meters")]
        public void WhenTheLengthInFeetIsConvertedToMeters()
        {
            _output = LengthConverter.FeetToMeters(_input);
        }

        [When(@"the length in feet is converted to yards")]
        public void WhenTheLengthInFeetIsConvertedToYards()
        {
            _output = LengthConverter.FeetToYards(_input);
        }

        [When(@"the length in yards is converted to feet")]
        public void WhenTheLengthInYardsIsConvertedToFeet()
        {
            _output = LengthConverter.YardsToFeet(_input);
        }

        [Then(@"the length should be (.*)")]
        public void ThenTheLengthInInchesShouldBe(int result)
        {
            var actual = _output;
            actual.Should().Be(result);
        }
    }
}