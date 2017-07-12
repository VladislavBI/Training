using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВDailyTask
{
    class GeoManager
    {
        public IDistanceCalculator distanceCalculator { private get; set; }

        public Double CalculateDistanceBetweenCities(CityModel cityOne, CityModel cityTwo)
        {
            return distanceCalculator.CalculateDistanceBetweenObjects(cityOne, cityTwo);
        }
    }
}
