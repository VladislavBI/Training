namespace FetchCurrentWeather.WeatherInfoFactory
{
    public class WeatherInfoManager
    {
        public IWeatherParser WeatherParser { get; set; }
        public IRegionParser RegionParser { get; set; }
    }
}
