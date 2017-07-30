using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FetchCurrentWeather
{
    public class GismeteoUAWetherParser : IWeatherParser
    {
        private string urlAddress => "https://www.gismeteo.ua/";

        public void GetWeatherForRegion(string regionCode)
        {
            HttpWebRequest request = CreateRequestToSite(regionCode);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string responseString = String.Empty;
                    string parsedString = reader.ReadToEnd();

                    string pattern = @"'value m_temp c'>(\+\d{1,2})";
                    Regex regex = new Regex(pattern);
                    Match match = regex.Match(parsedString);
                    string answer = match.Groups[1].Value;

                }
            }
        }

        private HttpWebRequest CreateRequestToSite(string regionCode)
        {
            string FullRequestString = urlAddress + regionCode;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FullRequestString);
            return request;
        }
    }
}
