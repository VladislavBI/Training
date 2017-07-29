using System.Collections.Generic;

namespace FetchCurrentWeather
{
    public interface IWeatherCodeGetter
    {
        string GetCodeForCityName(string cityName);
        string GetCodeForCityName(string[] cityNames);
    }
}