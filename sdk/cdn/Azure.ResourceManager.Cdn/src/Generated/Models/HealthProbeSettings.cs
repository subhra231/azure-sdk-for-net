// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties to send health probes to origin. </summary>
    public partial class HealthProbeSettings
    {
        /// <summary> Initializes a new instance of HealthProbeSettings. </summary>
        public HealthProbeSettings()
        {
        }

        /// <summary> Initializes a new instance of HealthProbeSettings. </summary>
        /// <param name="probePath"> The path relative to the origin that is used to determine the health of the origin. </param>
        /// <param name="probeRequestType"> The type of health probe request that is made. </param>
        /// <param name="probeProtocol"> Protocol to use for health probe. </param>
        /// <param name="probeIntervalInSeconds"> The number of seconds between health probes.Default is 240sec. </param>
        internal HealthProbeSettings(string probePath, HealthProbeRequestType? probeRequestType, HealthProbeProtocol? probeProtocol, int? probeIntervalInSeconds)
        {
            ProbePath = probePath;
            ProbeRequestType = probeRequestType;
            ProbeProtocol = probeProtocol;
            ProbeIntervalInSeconds = probeIntervalInSeconds;
        }

        /// <summary> The path relative to the origin that is used to determine the health of the origin. </summary>
        public string ProbePath { get; set; }
        /// <summary> The type of health probe request that is made. </summary>
        public HealthProbeRequestType? ProbeRequestType { get; set; }
        /// <summary> Protocol to use for health probe. </summary>
        public HealthProbeProtocol? ProbeProtocol { get; set; }
        /// <summary> The number of seconds between health probes.Default is 240sec. </summary>
        public int? ProbeIntervalInSeconds { get; set; }
    }
}
