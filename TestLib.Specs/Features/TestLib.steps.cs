using FluentAssertions;
using TechTalk.SpecFlow;

namespace TestLib.Specs.Features
{
    [Binding]
    public class TestLibStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private string _first;
        private string _second;
        private string _resultString;

        public TestLibStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I chose (.*) as first number")]
        public void GivenIChoseAsFirstNumber(int num)
        {
            _calculator.FirstNumber = num;
        }

        [Given(@"I chose (.*) as second number")]
        public void GivenIChoseAsSecondNumber(int num)
        {
            _calculator.SecondNumber = num;
        }

        [When(@"I call AddNumbers")]
        public void WhenICallAddNumbers()
        {
            _result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int num)
        {
            _result.Should().Be(num);
        }
        
        [Given(@"First string (.*)")]
        public void GivenFirstString(string firstString)
        {
            _first = firstString;
        }
        
        [Given(@"Second string (.*)")]
        public void GivenSecondString(string secondString)
        {
            _second = secondString;
        }
        
        [When(@"StringCat is called")]
        public void WhenStringCatIsCalled()
        {
            _resultString = _calculator.StringCat(_first, _second);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string concatenatedString)
        {
            _resultString.Should().Be(concatenatedString);
        }
    }
}