﻿using Newtonsoft.Json;

namespace ShuftiPro.Models
{
    public class ShuftiProVerificationResult
    {
        [JsonProperty("face")]
        public bool? Face { get; set; }

        [JsonProperty("background_checks")]
        public bool? BackgroundChecks { get; set; }

        [JsonProperty("consent")]
        public ShuftiProVerificationConsentResult Consent { get; set; }

        [JsonProperty("address")]
        public ShuftiProVerificationAddressResult Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProVerificationDocumentResult Document { get; set; }
    }
}
