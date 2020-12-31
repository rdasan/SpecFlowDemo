using FluentAssertions;
using TechTalk.SpecFlow;

namespace TestLib.Specs.Features
{
    [Binding]
    public class TestLibStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        //private int _result;
        private string _first;
        //private string _second;
        //private string _resultString;
        //private bool _matchHit;

        public TestLibStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Given(@"Firm Name ""(.*)""")]
        public void GivenFirmName(string firmName)
        {
            _first = firmName;
        }
        
        [Then(@"should give a match hit for ""(.*)""")]
        public void ThenShouldGiveAMatchHitFor(string seededFirmName)
        {
            var result = _calculator.FullVerbatimRule(_first, seededFirmName);
            result.Should().BeTrue();
        }
        
        [Then(@"should not give a match hit for ""(.*)""")]
        public void ThenShouldNotGiveAMatchHitFor(string seededFirmName)
        {
            var result = _calculator.FullVerbatimRule(_first, seededFirmName);
            result.Should().BeFalse();
        }

        // [Given(@"I chose (\d+) as first number")]
        // public void GivenIChoseAsFirstNumber(int num)
        // {
        //     _calculator.FirstNumber = num;
        // }
        //
        // [Given(@"I chose (\d+) as second number")]
        // public void GivenIChoseAsSecondNumber(int num)
        // {
        //     _calculator.SecondNumber = num;
        // }
        //
        // [When(@"I call AddNumbers")]
        // public void WhenICallAddNumbers()
        // {
        //     _result = _calculator.Add();
        // }
        //
        // [Then(@"the result should be (\d+) on the screen")]
        // public void ThenTheResultShouldBeOnTheScreen(int num)
        // {
        //     _result.Should().Be(num);
        // }
        //
        // [Given(@"First string (.*)")]
        // public void GivenFirstString(string firstString)
        // {
        //     _first = firstString;
        // }
        //
        // [Given(@"Second string (.*)")]
        // public void GivenSecondString(string secondString)
        // {
        //     _second = secondString;
        // }
        //
        // [When(@"StringCat is called")]
        // public void WhenStringCatIsCalled()
        // {
        //     _resultString = _calculator.StringCat(_first, _second);
        // }
        //
        // [Then(@"the concatenated string should be (.*)")]
        // public void ThenConcatenatedStringShouldBe(string concatenatedString)
        // {
        //     _resultString.Should().Be(concatenatedString);
        // }
    }
}