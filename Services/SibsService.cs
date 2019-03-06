
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using esperanto_web_api.ServiceResponses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace esperanto_web_api.Services
{
    public class SIBSService : IPSD2Service
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public SIBSService(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = GetClient();
        }

        public async Task<string> GetBanksAsync()
        {
            var url = _configuration["Sibs:AvailableASPSPEndpoint"];
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(url));
            request.Headers.Add("TPP-Transaction-ID", Guid.NewGuid().ToString());
            request.Headers.Add("TPP-Request-ID", Guid.NewGuid().ToString());
            request.Headers.Add("Signature", Guid.NewGuid().ToString());
            //request.Headers.Add("Digest", Guid.NewGuid().ToString());
            request.Headers.Add("TPP-Certificate", Guid.NewGuid().ToString());
            
            var response = await _client.SendAsync(request).ConfigureAwait(false);
            
            var responseBody = await response.Content.ReadAsStringAsync();
            //var parsedResponse = JsonConvert.DeserializeObject<AspspList>(responseBody);
            return responseBody;
        }

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            var clientId = _configuration["Sibs:ClientId"];
            client.DefaultRequestHeaders.Add("X-IBM-Client-Id", clientId);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}