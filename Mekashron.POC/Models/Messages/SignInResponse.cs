using System.Text.Json.Serialization;

namespace Mekashron.POC.Models.Messages
{
    public class SignInResponse
    {
        [JsonPropertyName("EntityId")]
        public int EntityId { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("Company")]
        public string Company { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("City")]
        public string City { get; set; }

        [JsonPropertyName("Country")]
        public string Country { get; set; }

        [JsonPropertyName("Zip")]
        public string Zip { get; set; }

        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("Mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("EmailConfirm")]
        public int EmailConfirm { get; set; }

        [JsonPropertyName("MobileConfirm")]
        public int MobileConfirm { get; set; }

        [JsonPropertyName("CountryID")]
        public int CountryID { get; set; }

        [JsonPropertyName("Status")]
        public int Status { get; set; }

        [JsonPropertyName("lid")]
        public string Lid { get; set; }

        [JsonPropertyName("FTPHost")]
        public string FTPHost { get; set; }

        [JsonPropertyName("FTPPort")]
        public int FTPPort { get; set; }
    }


}

