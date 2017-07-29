using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FetchCurrentWeather
{
    public static class RequestStringParserHelper
    {
        public static string ParseUTF8EscapeSequenceToUTF8Char(string stringWithEscapeSequences, IFormatProvider provider)
        {
            Int32 charCode;
            return Regex.Replace(stringWithEscapeSequences,
                @"\\u([0-9a-f]{4})",
                match => int.TryParse(match.Groups[1].Value,
                    NumberStyles.HexNumber, null, out charCode)
                        ? Convert.ToChar(charCode, provider).ToString()
                        : match.Value);
        }
        //public static string ParseUTF8JSONLikeRequest(string stringToParse, char separator)
        //{
        //    string[] separatedObjects = GetSeparatedJSONObjects(stringToParse, separator);

        //    StringBuilder stringForReturn = new StringBuilder();
        //    EncodeUnicodeObject(separator, separatedObjects, stringForReturn);
        //    stringForReturn.Remove(stringForReturn.Length - 1, 1);
        //    return ReturnTrimSymbols(stringForReturn);
        //}

        //private static string ReturnTrimSymbols(StringBuilder stringForReturn)
        //{
        //    stringForReturn.Append(']');
        //    return '[' + stringForReturn.ToString();
        //}

        //private static void EncodeUnicodeObject(char separator, string[] separatedObjects, StringBuilder stringForReturn)
        //{
        //    foreach (var sentence in separatedObjects)
        //    {
        //        EncodeUnicodeLetter(stringForReturn, sentence);
        //        stringForReturn.Append(separator);
        //    }
        //}

        //private static void EncodeUnicodeLetter(StringBuilder stringForReturn, string sentence)
        //{
        //    foreach (var item in sentence.Split('\\'))
        //    {
        //        string decodedLetter = item;
        //        if (item.StartsWith("u"))
        //        {
        //            decodedLetter = decodedLetter.TrimStart('u');
        //            decodedLetter = decodedLetter.TrimEnd('\"');
        //            decodedLetter = "&#x" + decodedLetter + ";";
        //            decodedLetter = System.Net.WebUtility.HtmlDecode(decodedLetter);
        //        }

        //        stringForReturn.Append(decodedLetter);
        //    }
        //}

        //private static string[] GetSeparatedJSONObjects(string stringToParse, char separator)
        //{
        //    string trimedString = stringToParse.TrimStart('[');
        //    trimedString = trimedString.TrimEnd(']');
        //    var separatedObjects = trimedString.Split(separator);
        //    return separatedObjects;
        //}

        //public static string DecodeFromUtf8(this string utf8String)
        //{
        //    // copy the string as UTF-8 bytes.
        //    byte[] utf8Bytes = new byte[utf8String.Length];
        //    for (int i = 0; i < utf8String.Length; ++i)
        //    {
        //        //Debug.Assert( 0 <= utf8String[i] && utf8String[i] <= 255, "the char must be in byte's range");
        //        utf8Bytes[i] = (byte)utf8String[i];
        //    }

        //    return Encoding.UTF8.GetString(utf8Bytes, 0, utf8Bytes.Length);
        //}


    }

}
