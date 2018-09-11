using specflow_livedemo;
using TechTalk.SpecFlow;

namespace specflow_livedemo_specs
{
    [Binding]
    public class CalculatorOperationSteps
    {
        private readonly Calculator _calculator;

        public CalculatorOperationSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _calculator.Subtract();
        }
    }
}
