﻿using Newtonsoft.Json;

namespace Kraken.WebSockets.Messages
{
    /// <summary>
    /// System status.
    /// </summary>
    public class SystemStatus : IKrakenMessage
    {
        /// <summary>
        /// The name of the event.
        /// </summary>
        public const string EventName = "systemStatus";

        [JsonProperty("connectionID")]
        public decimal ConnectionId { get; internal set; }

        [JsonProperty("event")]
        public string Event { get; internal set; }

        [JsonProperty("status")]
        public string Status { get; internal set; }

        [JsonProperty("version")]
        public string Version { get; internal set; }
    }
}