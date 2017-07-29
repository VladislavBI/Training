namespace FetchCurrentWeather.WeatherInfoFactory
{

    public class UAZipNetGismeteoAbstractFactory: IRegionWeatherAbstractFactory
    {
        

        public WeatherInfoManager GetNewWeatherInfoManagerInstance()
        {
            WeatherInfoManager manager = new WeatherInfoManager();

            manager.RegionParser = new UazipnetRegionParser();
            manager.WeatherParser =new GismeteoUAWetherParser();

            return manager;
        }
    }
}
