using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВDailyTask
{
    class CityModelBuilder
    {
        public CityModel CreateCityModel(string cityName)
        {
            CityModel createdCity = new CityModel();
            createdCity.X = ConsoleInputService.GetUsersDoubleInputValue("Input " + cityName + " data", "X=");
            createdCity.Y = ConsoleInputService.GetUsersDoubleInputValue("Y=");
            return createdCity;
        }
    }
}
