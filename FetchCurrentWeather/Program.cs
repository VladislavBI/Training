using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchCurrentWeather
{
    class Program
    {
        static void Main(string[] args)
        {           
            UazipnetRegionParser p = new UazipnetRegionParser();
            IWeatherCodeGetter weatherCodeGenerator = new GismeteoWeatherCodeGetter();
            var weatherCode = weatherCodeGenerator.GetCodeForCityName(p.GetParsedRegion("61105"));
        }
    }
}
