namespace Challange318.MathOperation
{
    class AddMathOperation : IMathOperation
    {
        public double GetResult(double op1, double op2)
        {
            return op1 + op2;
        }

        public char GetSign()
        {
            return '+';
        }
    }
}
