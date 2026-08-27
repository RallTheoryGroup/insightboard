namespace InsightBoard.Core
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        public double Percentage(double value, double total)
        {
            if (total == 0) throw new DivideByZeroException();
            return (value / total) * 100;
        }
    }
}
