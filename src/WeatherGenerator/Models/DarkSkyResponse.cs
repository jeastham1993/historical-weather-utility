// ------------------------------------------------------------
// Copyright (c) JEastham Dev.
// ------------------------------------------------------------

using System;

namespace WeatherGenerator
{
    /// <summary>
    /// Encapsulates response data from Dark Sky.
    /// </summary>
    public class DarkSkyResponse
    {
        /// <summary>
        /// Gets or sets the weather at the time of the request.
        /// </summary>
        public Currently Currently { get; set; }

        /// <summary>
        /// Gets or sets a summary of the weather for the day.
        /// </summary>
        public Daily Daily { get; set; }
    }
}