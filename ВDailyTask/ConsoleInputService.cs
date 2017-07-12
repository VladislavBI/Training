using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВDailyTask
{
    class ConsoleInputService
    {
        public static Double GetUsersDoubleInputValue (string messageToUser, string additionalInfo = "")
        {
            Console.WriteLine(messageToUser);
            if (!String.IsNullOrEmpty(additionalInfo))
            {
                Console.WriteLine(additionalInfo);
            }
            return GetUserDoubleInput();
        }

        private static Double GetUserDoubleInput(int attemptsStartCount = 0)
        {
            Double returnValue;
            if (Double.TryParse(Console.ReadLine(), out returnValue))
            {
                return returnValue;
            }
            else
            {
                return ParseDoubleInputAfterWrongAttemp(attemptsStartCount);
            }
        }

        private static double ParseDoubleInputAfterWrongAttemp(int attemptsCount)
        {
            if (++attemptsCount >= 3)
            {
                Console.WriteLine("To much wrong attempts. Return default value: " + 0);
                return 0;
            }
            Console.WriteLine("Wrong input value, data type should be integer, please write again");
            return GetUserDoubleInput(attemptsCount);
        }
    }
}
