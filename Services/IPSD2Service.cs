using System.Collections.Generic;
using System.Threading.Tasks;


namespace esperanto_web_api.Services
{
    public interface IPSD2Service
    {
        Task<string> GetBanksAsync();
    }
}