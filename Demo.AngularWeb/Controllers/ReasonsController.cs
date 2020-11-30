using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Demo.AngularWeb.Models;

namespace Demo.AngularWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReasonsController : ControllerBase
    {
        private readonly ILogger<ReasonsController> _logger;

        public ReasonsController(ILogger<ReasonsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Reason> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5)
                .Select(index => new Reason
                {
                    Id=index,
                    Description = "Hello" + index,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow
                })
                .ToArray();
        }

        [HttpPost]
        public bool Post([FromBody]IEnumerable<Reason> reasons)
        {
            return true;
        }
    }
}
