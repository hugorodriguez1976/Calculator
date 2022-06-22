namespace CalculatorTest.Repository
{
    public interface ICalculatorRepository
    {
        int Sum(int a, int b);
        int Sub(int a, int b);
        int Multiply(int a, int b);
        double Divide(double a, double b);
    }
    
}
