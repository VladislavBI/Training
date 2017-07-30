using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318.MathOperation
{
    class MultiplicationMathOperation : IMathOperation
    {
        public double GetResult(double op1, double op2)
        {
            return op1 * op2;
        }

        public char GetSign()
        {
            return '*';
        }
    }
}
