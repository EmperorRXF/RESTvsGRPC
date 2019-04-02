using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Data;
using ModelLibrary.REST;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeteoriteLandingsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "API Version 1.0";
        }

        // GET api/values/LargePayload
        [HttpGet]
        [Route("LargePayload")]
        public ActionResult<IEnumerable<MeteoriteLanding>> GetLargePayloadAsync()
        {
            return MeteoriteLandingData.RestMeteoriteLandings;
        }

        // POST api/values/LargePayload
        [HttpPost]
        [Route("LargePayload")]
        public string PostLargePayload([FromBody] IEnumerable<MeteoriteLanding> meteoriteLandings)
        {
            return "SUCCESS";
        }
    }
}
