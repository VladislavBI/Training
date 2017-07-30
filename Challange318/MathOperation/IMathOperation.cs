using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318.MathOperation
{
    interface IMathOperation
    {
        char GetSign();
        double GetResult(double op1, double op2);
    }

}
