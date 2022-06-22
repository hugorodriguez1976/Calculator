namespace CalculatorTest.Repository
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public CalculatorRepository() { }

        public double Divide(double a, double b)
        {
            if (b == 0)
                return 0D;
            return (double)(a / b);
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}