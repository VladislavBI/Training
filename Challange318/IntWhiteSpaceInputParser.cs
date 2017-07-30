using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    class IntWhiteSpaceInputParser : IInputParser
    {
        private double figureToCalculate;

        public List<double> GetParsedUserInput(string userInput)
        {
            string[] userInputs = userInput.Split(' ');
            List<double> dataToCalculate = new List<double>();

            foreach (var input in userInputs)
            {
                if (Double.TryParse(input, out figureToCalculate))
                {
                    dataToCalculate.Add(figureToCalculate);
                }
                else
                {
                    throw new WrongInputException(userInput + " is not integer");
                }
            }
            return dataToCalculate;
        }
    }
}
