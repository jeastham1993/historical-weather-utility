// ------------------------------------------------------------
// Copyright (c) JEastham Dev.
// ------------------------------------------------------------

using System;

namespace WeatherGenerator
{
    /// <summary>
    /// Encapsulates weather data at the request time.
    /// </summary>
    public class Currently
    {
        /// <summary>
        /// Gets or sets the epoch time.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the weather summary text.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the weather icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the precip intensity.
        /// </summary>
        public string Precipstringensity { get; set; }

        /// <summary>
        /// Gets or sets the probability of precip.
        /// </summary>
        public string PrecipProbability { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public string Temperature { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        public string ApparentTemperature { get; set; }

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
        /// Gets or sets the UV index.
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
    }
}