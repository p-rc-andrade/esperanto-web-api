using System.Collections.Generic;
using Newtonsoft.Json;

namespace esperanto_web_api.ServiceResponses
{

    [JsonArray]
    public class AspspList
    {
        [JsonProperty("aspsp-list")]
        public List<Aspsp> AspspItems { get; set; }
    }
}