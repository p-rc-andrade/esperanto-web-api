using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using esperanto_web_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace esperanto_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private IPSD2Service _psd2Service;

        public BanksController(IPSD2Service psd2Service)
        {
            _psd2Service = psd2Service;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            return Ok(await _psd2Service.GetBanksAsync());
        }
    }
}
