using Challange318.MathOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    class RandomIntResultCalculator : IResultCalculator
    {
        double summ;
        Random rand;

        public RandomIntResultCalculator()
        {
            summ = 0;
            rand = new Random();
        }

        Dictionary<int, IMathOperation> mathDictionary = new Dictionary<int, IMathOperation>()
        {
            {1, new AddMathOperation()},
            {2, new SubstractMathOperation()},
            {3, new MultiplicationMathOperation()},
            {4, new DivideMathOperation()}
        };
        public string GetCalculationFullExpresion(List<double> dataForProceed)
        {
            StringBuilder fullExpression = new StringBuilder();
            summ = PopFirstOperand(dataForProceed);
            fullExpression.Append(summ);

            for (int i = 0; i < dataForProceed.Count(); i++)
            {
                IMathOperation operation = mathDictionary[rand.Next(1, 4)];
                summ = operation.GetResult(summ, dataForProceed[i]);

                fullExpression.Append(operation.GetSign());
                fullExpression.Append(dataForProceed[i]);

            }
            return fullExpression.Append("=" + summ).ToString();
        }

        private static double PopFirstOperand(List<double> dataForProceed)
        {
            double summ = dataForProceed[0];
            dataForProceed.RemoveAt(0);
            return summ;
        }

        public double GetCalculationResult(List<double> dataForProceed)
        {
            summ = PopFirstOperand(dataForProceed);

            for (int i = 0; i < dataForProceed.Count(); i ++)
            {
                IMathOperation operation = mathDictionary[rand.Next(1, 4)];
                summ = operation.GetResult(summ, dataForProceed[i]);
            }
            return summ;
        }
    }
}
