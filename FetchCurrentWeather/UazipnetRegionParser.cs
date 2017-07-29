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
    public class UazipnetRegionParser : IRegionParser
    {
        private const string urlAddress = "http://ua-zip.net/script/suggest.php";
        private const string prefixParameter = "prefix={0}";
        private const string typeParameter = "type={0}";

        public IWeatherCodeGetter WeatherCodeGetter { private get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string[] GetParsedRegion(string zipCode)
        {
            string siteResponse =  GetResponseFromSite(zipCode);
            return siteResponse.Split(',');
        }

        private static string GetResponseFromSite(string zipCode)
        {
           

            HttpWebRequest request = CreateRequestToSite(zipCode);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string responseString = String.Empty;
                    string parsedString = String.Empty; 
                    while ((responseString = reader.ReadLine()) != null)
                    {
                        parsedString = RequestStringParserHelper.ParseUTF8EscapeSequenceToUTF8Char(responseString, new CultureInfo("uk-UA")); 
                    }
                    return parsedString;
                }
            }
        }

        private static HttpWebRequest CreateRequestToSite(string zipCode)
        {
            string FullRequestString = urlAddress + "?" + string.Format(prefixParameter, zipCode) + "&" + String.Format(typeParameter, "index");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FullRequestString);
            return request;
        }
    }
}
