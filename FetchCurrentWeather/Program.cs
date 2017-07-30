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
            IRegionParser regionParser = new UazipnetRegionParser();
            IWeatherCodeGetter weatherCodeGenerator = new GismeteoWeatherCodeGetter();
            var weatherCode = weatherCodeGenerator.GetCodeForCityName(regionParser.GetParsedRegion("61105"));
            IWeatherParser weatherParser = new GismeteoUAWetherParser();
            weatherParser.GetWeatherForRegion(weatherCode);
        }
    }
}
