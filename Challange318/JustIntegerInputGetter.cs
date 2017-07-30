using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    class JustIntegerInputGetter : InputGetter
    {
        public override string GetInputRuleMessage()
        {
            return "input 5 integers separated by whitespaces";
        }
    }
}
