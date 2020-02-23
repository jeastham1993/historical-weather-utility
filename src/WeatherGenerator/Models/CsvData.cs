// ------------------------------------------------------------
// Copyright (c) JEastham Dev.
// ------------------------------------------------------------

using System;

namespace WeatherGenerator
{
    /// <summary>
    /// Encapsulates data to be read/written from the CSV.
    /// </summary>
    public class CsvData
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public string Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public string Temperature { get; set; }

        /// <summary>
        /// Gets or sets the dew point.
        /// </summary>
        public string DewPoint { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        public string ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the humidity.
        /// </summary>
        public string Humidity { get; set; }

        /// <summary>
        /// Gets or sets the pressure.
        /// </summary>
        public string Pressure { get; set; }

        /// <summary>
        /// Gets or sets the wind speed.
        /// </summary>
        public string WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the wind gust.
        /// </summary>
        public string WindGust { get; set; }

        /// <summary>
        /// Gets or sets the wind bearing.
        /// </summary>
        public string WindBearing { get; set; }

        /// <summary>
        /// Gets or sets the cloud cover.
        /// </summary>
        public string CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the UV Index.
        /// </summary>
        public string UvIndex { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or sets the ozone.
        /// </summary>
        public string Ozone { get; set; }

        /// <summary>
        /// Gets or sets the days moon phase.
        /// </summary>
        public string DayMoonPhase { get; set; }

        /// <summary>
        /// Gets or sets the days sunrise time.
        /// </summary>
        public string DaySunriseTime { get; set; }

        /// <summary>
        /// Gets or sets the sunset time.
        /// </summary>
        public string DaySunsetTime { get; set; }

        /// <summary>
        /// Gets or sets the days precipitation intensity.
        /// </summary>
        public string DayMaxPrecipIntensity { get; set; }

        /// <summary>
        /// Gets or sets the precipitation probability.
        /// </summary>
        public string DayPrecipProbability { get; set; }

        /// <summary>
        /// Gets or sets the days high temperature.
        /// </summary>
        public string DayHighTemperature { get; set; }

        /// <summary>
        /// Gets or sets the days low temperature.
        /// </summary>
        public string DayLowTemperature { get; set; }

        /// <summary>
        /// Gets the datetime offset of the data read from the CSV.
        /// </summary>
        public DateTimeOffset ParsedDate
        {
            get
            {
                return DateTime.Parse($"{this.Date} {this.Time ?? "00:00"}");
            }
        }
    }
}