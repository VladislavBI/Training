using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    class Program
    {
        private static int figureToCalculate;

        static void Main(string[] args)
        {
            Console.WriteLine("input 5 characters separated by whitespace");
            string[] userInputs=Console.ReadLine().Split(' ');
            List<int> dataToCalculate = new List<int>();

            foreach (var userInput in userInputs)
            {
                if (Int32.TryParse(userInput, out figureToCalculate))
                {
                    dataToCalculate.Add(figureToCalculate);
                }
                else
                {
                    throw new WrongInputException(userInput + " is not integer");
                }
            }
        }
    }
    class WrongInputException:Exception
    {
        public WrongInputException()
        {
                
        }
        public WrongInputException(string message):base(message)
        {
            
        }
        public WrongInputException(string message, Exception inner):base(message, inner)
        {

        }  
    }
}
