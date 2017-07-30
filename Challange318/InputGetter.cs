using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    public abstract class InputGetter
    {
        public abstract string GetInputRuleMessage();
        public virtual string GetUserInput()
        {
            return Console.ReadLine();
        } 
    }
}
