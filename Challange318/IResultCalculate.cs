using System.Collections.Generic;

namespace Challange318
{
    public interface IResultCalculator
    {
        string GetCalculationFullExpresion(List<double> dataForProceed);
        double GetCalculationResult(List<double> dataForProcee);
    }
}