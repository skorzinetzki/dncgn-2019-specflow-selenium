namespace specflow_livedemo
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public CalculationResult CalculationResult { get; set; }

        public void Add()
        {
            CalculationResult = new CalculationResult {Result = FirstNumber + SecondNumber};
        }

        public void Subtract()
        {
            CalculationResult = new CalculationResult { Result = FirstNumber - SecondNumber };
        }
    }
}
