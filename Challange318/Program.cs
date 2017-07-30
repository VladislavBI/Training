using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFactory abstractGameFactory = new IntBlindGameFactory();
            var getter = abstractGameFactory.CreateInputGetter();
            Console.WriteLine(getter.GetInputRuleMessage());
            
            var parser = abstractGameFactory.CreateInputParser();
            var parsedData = parser.GetParsedUserInput(getter.GetUserInput());

            var calculator = abstractGameFactory.CreateResultCalculator();
            Console.WriteLine(calculator.GetCalculationFullExpresion(parsedData));
        }
    }
}
