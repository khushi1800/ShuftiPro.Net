using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProServiceDeclinedCodes
    {
        [JsonProperty("address")]
        string[] Address { get; set; }

        [JsonProperty("document")]
        string[] Document { get; set; }

        [JsonProperty("face")]
        string[] Face { get; set; }

        [JsonProperty("consent")]
        string[] Consent { get; set; }
        
        [JsonProperty("background_checks")]
        string[] BackgroundChecks { get; set; }
    }
}
