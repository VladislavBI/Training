namespace FetchCurrentWeather.WeatherInfoFactory
{
    public interface IRegionWeatherAbstractFactory
    {
        WeatherInfoManager GetNewWeatherInfoManagerInstance();
    }
}
