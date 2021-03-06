﻿using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Infrastructure.Models
{
    /// <summary>
    /// A model that represents a Device's telemetry recording.
    /// </summary>
    public class DeviceTelemetryModel
    {
    
        /// <summary>
        /// Gets or sets the ID of the Device for which telemetry applies.
        /// </summary>
        public string DeviceId
        {
            get;
            set;
        }

        public IDictionary<string, double> Values { get; set; } = new Dictionary<string, double>();

        /// <summary>
        /// Gets or sets the time of record for the represented telemetry 
        /// recording.
        /// </summary>
        public DateTime? Timestamp
        {
            get;
            set;
        }
    }
}
