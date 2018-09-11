using NUnit.Framework;
using TechTalk.SpecFlow;
using specflow_livedemo;

namespace specflow_livedemo_specs
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator;

        public CalculatorSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [BeforeScenario()]
        public void BeforeEachScenario()
        {
            Assert.IsNull(_calculator.CalculationResult);
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

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.CalculationResult.Result);
        }
    }
}
