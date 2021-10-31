

using System.Text.Json.Serialization;

namespace Mekashron.POC.Models.Messages
{
    public class GenericResponse
    {
        [JsonPropertyName("ResultCode")]
        public int? ResultCode { get; set; }

        [JsonPropertyName("ResultMessage")]
        public string ResultMessage { get; set; }
        public bool HasError { get; set; }
    }
}
