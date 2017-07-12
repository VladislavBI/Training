using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВDailyTask
{
    static class AdvanceMathFuctionsService
    {
        public static double GetHypotenuse (double katetOne=0, double katetTwo=0)
        {
            if(double.IsNaN(katetOne) || double.IsNaN(katetTwo))
            {
                return 0;
            }
            return Math.Sqrt(Math.Pow(katetOne, 2) + Math.Pow(katetTwo, 2));
        }
    }
}
