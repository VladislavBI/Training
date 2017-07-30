using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    public abstract class GameFactory
    {
        public abstract InputGetter CreateInputGetter();
        public abstract IInputParser CreateInputParser();
        public abstract IResultCalculator CreateResultCalculator();

    }
}
