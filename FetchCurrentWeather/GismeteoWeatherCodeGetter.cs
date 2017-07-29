using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchCurrentWeather
{
    class GismeteoWeatherCodeGetter : IWeatherCodeGetter
    {
        List<CityDictionaryModel> _codeDictionary = new List<CityDictionaryModel>();
        public GismeteoWeatherCodeGetter()
        {
            _codeDictionary.Add(new CityDictionaryModel()
            {
                CityCode = "weather-kharkiv-5053",
                CityVariants = new List<string>() { "Харків" }
            });
        }


        public string GetCodeForCityName(string cityName)
        {
            foreach (var code in _codeDictionary)
            {
                if (code.Equals(cityName))
                {
                    return code.CityCode;
                }
            }
            throw new CodeNotFoundException("there is no " + nameof(cityName) + " " + cityName + " in dictionary");
        }

        public string GetCodeForCityName(string[] cityNames)
        {
            foreach (var name in cityNames)
            {
                string cityCode = GetCodeForCityNameWithoutException(name);
                if (!String.IsNullOrEmpty(cityCode))
                {
                    return cityCode;
                }
            }
                
            throw new CodeNotFoundException("there is no such names in dictionary");

        }
        public string GetCodeForCityNameWithoutException(string cityName)
        {
            foreach (var code in _codeDictionary)
            {
                if (code.CompareTo(cityName)==0)
                {
                    return code.CityCode;
                }
            }
            return String.Empty;
        }
    }
    class CityDictionaryModel : IComparable<string>
    {
        public string CityCode { get; set; }
        public List<string> CityVariants { get; set; }

        public int CompareTo(string other)
        {
            if (CityVariants.Contains(other.Trim('"')))
            {
                return 0;
            }
            return -1;
        }
    }

    class CodeNotFoundException : Exception
    {
        public CodeNotFoundException()
        {

        }

        public CodeNotFoundException(string message)
        : base(message)
        {
        }

        public CodeNotFoundException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
