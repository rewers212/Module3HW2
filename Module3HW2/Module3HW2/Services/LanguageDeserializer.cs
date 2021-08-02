using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Module3HW2
{
    public class LanguageDeserializer
    {
        public static string DownlodAlphabet(CultureInfo cultureInfo)
        {
            string alphabet;
            switch (cultureInfo.ToString())
            {
                case "ru-RU":
                    alphabet = DeserializeAlphabet("RussianAlphabet");
                    break;
                case "en-US":
                default:
                    alphabet = DeserializeAlphabet("EnglishAlphabet");
                    break;
            }

            return alphabet;
        }

        private static string DeserializeAlphabet(string nameAlphabet)
        {
            var configFile = File.ReadAllText($"{nameAlphabet}.json");
            var config = JsonConvert.DeserializeObject<string>(configFile);
            return config;
        }
    }
}
