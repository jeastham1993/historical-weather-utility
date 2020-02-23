// ------------------------------------------------------------
// Copyright (c) JEastham Dev.
// ------------------------------------------------------------

using System;

namespace WeatherGenerator
{
    /// <summary>
    /// Encapsulates properties of a daily weather record.
    /// </summary>
    public class DailyDataRecord
    {
        /// <summary>
        /// Gets the base epoch time.
        /// </summary>
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Gets or sets the epoch time.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the summary text.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the summary icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the sunrise time in epoch seconds.
        /// </summary>
        public string SunriseTime { get; set; }

        /// <summary>
        /// Gets or sets the sunset time in epoch seconds.
        /// </summary>
        public string SunsetTime { get; set; }

        /// <summary>
        /// Gets the sunrise time.
        /// </summary>
        public DateTime Sunrise
        {
            get
            {
                return FromUnixTime(long.Parse(this.SunriseTime));
            }
        }

        /// <summary>
        /// Gets the sunset time.
        /// </summary>
        public DateTime Sunset
        {
            get
            {
                return FromUnixTime(long.Parse(this.SunsetTime));
            }
        }

        /// <summary>
        /// Gets or sets the Moon Phase.
        /// </summary>
        public string MoonPhase { get; set; }

        /// <summary>
        /// Gets or sets the intensity of precipitation.
        /// </summary>
        public string PrecipIntensity { get; set; }

        /// <summary>
        /// Gets or sets the max precipitation intensity.
        /// </summary>
        public string PrecipIntensityMax { get; set; }

        /// <summary>
        /// Gets or sets the time of the max precipitation.
        /// </summary>
        public string PrecipIntensityMaxTime { get; set; }

        /// <summary>
        /// Gets or sets the probability of precipitation.
        /// </summary>
        public string PrecipProbability { get; set; }

        /// <summary>
        /// Gets or sets the type of precipitation.
        /// </summary>
        public string PrecipType { get; set; }

        /// <summary>
        /// Gets or sets the high temperature.
        /// </summary>
        public string TemperatureHigh { get; set; }

        /// <summary>
        /// Gets or sets the time of the high temperature.
        /// </summary>
        public string TemperatureHighTime { get; set; }

        /// <summary>
        /// Gets or sets the low temperature.
        /// </summary>
        public string TemperatureLow { get; set; }

        /// <summary>
        /// Gets or sets the time of the low temperature.
        /// </summary>
        public string TemperatureLowTime { get; set; }

        /// <summary>
        /// Gets or sets the apparent high temperature.
        /// </summary>
        public string ApparentTemperatureHigh { get; set; }

        /// <summary>
        /// Gets or sets the time of apparent high temperature.
        /// </summary>
        public string ApparentTemperatureHighTime { get; set; }

        /// <summary>
        /// Gets or sets the apparent low temperature.
        /// </summary>
        public string ApparentTemperatureLow { get; set; }

        /// <summary>
        /// Gets or sets the time of the apparent low temperature.
        /// </summary>
        public string ApparentTemperatureLowTime { get; set; }

        /// <summary>
        /// Gets or sets the dew point.
        /// </summary>
        public string DewPoint { get; set; }

        /// <summary>
        /// Gets or sets the humidity.
        /// </summary>
        public string Humidity { get; set; }

        /// <summary>
        /// Gets or sets the pressure.
        /// </summary>
        public string Pressure { get; set; }

        /// <summary>
        /// Gets or sets the wind speec.
        /// </summary>
        public string WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the wind gust.
        /// </summary>
        public string WindGust { get; set; }

        /// <summary>
        /// Gets or sets the time of wind gusts.
        /// </summary>
        public string WindGustTime { get; set; }

        /// <summary>
        /// Gets or sets the wind bearing.
        /// </summary>
        public string WindBearing { get; set; }

        /// <summary>
        /// Gets or sets the cloud cover.
        /// </summary>
        public string CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the UV index.
        /// </summary>
        public string UvIndex { get; set; }

        /// <summary>
        /// Gets or sets the UV index time.
        /// </summary>
        public string UvIndexTime { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or sets the ozone.
        /// </summary>
        public string Ozone { get; set; }

        /// <summary>
        /// Gets or sets the min temperature.
        /// </summary>
        public string TemperatureMin { get; set; }

        /// <summary>
        /// Gets or sets the min temperature time.
        /// </summary>
        public string TemperatureMinTime { get; set; }

        /// <summary>
        /// Gets or sets the max temperature.
        /// </summary>
        public string TemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets the max temperature time.
        /// </summary>
        public string TemperatureMaxTime { get; set; }

        /// <summary>
        /// Gets or sets the min apparent temperature.
        /// </summary>
        public string ApparentTemperatureMin { get; set; }

        /// <summary>
        /// Gets or sets the min apparent temperature time.
        /// </summary>
        public string ApparentTemperatureMinTime { get; set; }

        /// <summary>
        /// Gets or sets the max apparent temperature.
        /// </summary>
        public string ApparentTemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets the max apparent temperature time.
        /// </summary>
        public string ApparentTemperatureMaxTime { get; set; }

        private static DateTime FromUnixTime(long unixTime)
        {
            return Epoch.AddSeconds(unixTime);
        }
    }
}