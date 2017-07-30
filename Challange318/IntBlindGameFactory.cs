using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange318
{
    /// <summary>
    /// USer inputs only integers separated by whitespaces. Mathematical signs are set random
    /// </summary>
    public class IntBlindGameFactory : GameFactory
    {
        public override IResultCalculator CreateResultCalculator()
        {
            return new RandomIntResultCalculator();
        }

        public override InputGetter CreateInputGetter()
        {
            return new JustIntegerInputGetter();
        }

        public override IInputParser CreateInputParser()
        {
            return new IntWhiteSpaceInputParser();
        }
    }
}
