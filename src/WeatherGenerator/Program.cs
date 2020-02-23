// ------------------------------------------------------------
// Copyright (c) JEastham Dev.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using CsvHelper;
using Newtonsoft.Json;

namespace WeatherGenerator
{
    /// <summary>
    /// Main Application Entry Point.
    /// </summary>
    public static class Program
    {
        private static string darkSkyApiKey = string.Empty;

        /// <summary>
        /// Main application entry point.
        /// </summary>
        /// <param name="args">Application runtime arguments.</param>
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.Length <= 0)
            {
                throw new ArgumentException("The Dark Sky API Key must be passed in as a runtime argument");
            }

            darkSkyApiKey = args[0];
            Console.WriteLine("Where is the file you wish to process?");
            var inboundFilePath = Console.ReadLine();

            if (File.Exists(inboundFilePath) == false)
            {
                Console.WriteLine("File does not exist, quitting");
                return;
            }

            var csvData = new List<CsvData>();

            using (var reader = new StreamReader(inboundFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.MissingFieldFound = null;

                csvData = csv.GetRecords<CsvData>().ToList();
            }

            using (var client = new HttpClient())
            {
                foreach (var dataPoint in csvData)
                {
                    var getUrl = new Uri($"https://api.darksky.net/forecast/{darkSkyApiKey}/{dataPoint.Lat},{dataPoint.Longitude},{dataPoint.ParsedDate.ToUnixTimeSeconds()}?exclude=hourly,flags");

                    var getResult = client.GetAsync(getUrl).Result;

                    var getResponseContent = getResult.Content.ReadAsStringAsync().Result;

                    var darkSkyResponse = JsonConvert.DeserializeObject<DarkSkyResponse>(getResponseContent);

                    dataPoint.Ozone = darkSkyResponse.Currently.Ozone.ToString();
                    dataPoint.Pressure = darkSkyResponse.Currently.Pressure.ToString();
                    dataPoint.ApparentTemperature = darkSkyResponse.Currently.ApparentTemperature.ToString();
                    dataPoint.CloudCover = darkSkyResponse.Currently.CloudCover.ToString();
                    dataPoint.DewPoint = darkSkyResponse.Currently.DewPoint.ToString();
                    dataPoint.Humidity = darkSkyResponse.Currently.Humidity.ToString();
                    dataPoint.Summary = darkSkyResponse.Currently.Summary.ToString();
                    dataPoint.Temperature = darkSkyResponse.Currently.Temperature.ToString();
                    dataPoint.UvIndex = darkSkyResponse.Currently.UvIndex.ToString();
                    dataPoint.Visibility = darkSkyResponse.Currently.Visibility.ToString();
                    dataPoint.WindBearing = darkSkyResponse.Currently.WindBearing.ToString();
                    dataPoint.WindGust = darkSkyResponse.Currently.WindGust.ToString();
                    dataPoint.WindSpeed = darkSkyResponse.Currently.WindSpeed.ToString();
                    dataPoint.DayHighTemperature = darkSkyResponse.Daily.Data.FirstOrDefault().TemperatureHigh.ToString();
                    dataPoint.DayLowTemperature = darkSkyResponse.Daily.Data.FirstOrDefault().TemperatureLow.ToString();
                    dataPoint.DayMaxPrecipIntensity = darkSkyResponse.Daily.Data.FirstOrDefault().PrecipIntensityMax.ToString();
                    dataPoint.DayMoonPhase = darkSkyResponse.Daily.Data.FirstOrDefault().MoonPhase.ToString();
                    dataPoint.DayPrecipProbability = darkSkyResponse.Daily.Data.FirstOrDefault().PrecipProbability.ToString();
                    dataPoint.DaySunriseTime = darkSkyResponse.Daily.Data.FirstOrDefault().Sunrise.ToString("HH:mm:ss");
                    dataPoint.DaySunsetTime = darkSkyResponse.Daily.Data.FirstOrDefault().Sunset.ToString("HH:mm:ss");
                }
            }

            var outputFilePath = inboundFilePath.Replace(".csv", "-out.csv");

            using (var writer = new StreamWriter(outputFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(csvData);
            }

            Console.WriteLine($"Done, file written to {outputFilePath}");
        }
    }
}
