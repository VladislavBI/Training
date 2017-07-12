using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВDailyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoManager m = new GeoManager();
            m.distanceCalculator = new CityDistanceCalculator();

            CityModelBuilder builder = new CityModelBuilder();
            CityModel firstCity = builder.CreateCityModel("New york");
            CityModel secondCity = builder.CreateCityModel("Kharkiv");

            Console.WriteLine("distance between cities is " + m.CalculateDistanceBetweenCities(firstCity, secondCity));
            Console.ReadLine();
        }
    }
}
