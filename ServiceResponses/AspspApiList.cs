using System.Collections.Generic;
using Newtonsoft.Json;

namespace esperanto_web_api.ServiceResponses
{
   
    public class AspspApiList
    {
        [JsonProperty("consents")]
        public List<string> Consents { get; set; }
        [JsonProperty("payments")]
        public List<string> Payments { get; set; }
        [JsonProperty("accounts")]
        public List<string> Accounts { get; set; }
        [JsonProperty("funds-confirmations")]
        public List<string> FundsConfirmations { get; set; }
    }
}