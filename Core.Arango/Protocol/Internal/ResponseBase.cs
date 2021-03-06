using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Core.Arango.Protocol.Internal
{
    /// <summary>
    ///     Base response model
    /// </summary>
    internal abstract class ResponseBase
    {
        [JsonPropertyName("code")]
        [JsonProperty(PropertyName = "code")] 
        public short Code { get; set; }

        [JsonPropertyName("error")]
        [JsonProperty(PropertyName = "error")] 
        public bool Error { get; set; }

        [JsonPropertyName("errorMessage")]
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("errorNum")]
        [JsonProperty(PropertyName = "errorNum")]
        public int ErrorNum { get; set; }
    }
}