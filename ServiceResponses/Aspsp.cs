using System.Collections.Generic;
using Newtonsoft.Json;

namespace esperanto_web_api.ServiceResponses
{
    public class Aspsp
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("bic")]
        public string Bic { get; set; }
        [JsonProperty("bank-code")]
        public string BankCode { get; set; }
        [JsonProperty("aspsp-cde")]
        public string AspspCode { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("logoLocation")]
        public string LogoLocation { get; set; }
        // [JsonProperty("api-list")]
        // public List<AspspApiList> ApiList { get; set; }
    }


}