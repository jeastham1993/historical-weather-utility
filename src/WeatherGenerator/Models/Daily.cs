// ------------------------------------------------------------
// Copyright (c) JEastham Dev.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace WeatherGenerator
{
    /// <summary>
    /// Encapsulates daily weather data.
    /// </summary>
    public class Daily
    {
        /// <summary>
        /// Gets or sets the daily data records.
        /// </summary>
        public IEnumerable<DailyDataRecord> Data { get; set; }
    }
}