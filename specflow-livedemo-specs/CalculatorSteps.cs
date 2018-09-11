using NUnit.Framework;
using TechTalk.SpecFlow;
using specflow_livedemo;

namespace specflow_livedemo_specs
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calculator;
        private int _result;

        [BeforeScenario()]
        public void BeforeEachScenario()
        {
            _calculator = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            _calculator.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }
    }
}
