using System;
using System.Collections.Generic;

namespace Challange318
{
    public interface IInputParser
    {
        List<double> GetParsedUserInput(string userInput);
    }

    class WrongInputException : Exception
    {
        public WrongInputException()
        {

        }
        public WrongInputException(string message) : base(message)
        {

        }
        public WrongInputException(string message, Exception inner) : base(message, inner)
        {

        }
    }

}