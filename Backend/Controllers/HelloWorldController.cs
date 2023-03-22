﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace project.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AngularTestController : ControllerBase
    {
        private readonly ILogger _logger;

        public AngularTestController(ILogger<AngularTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var world = new
            {
                hello = "world"
            };

            return new JsonResult(world);
        }

        [HttpPost("new")]
        public JsonResult PostNewAngularTest([FromBody] Dictionary<string, object> request)
        {
            _logger.LogInformation(string.Join(Environment.NewLine, request));

            var response = new Dictionary<string, object>();
            response["request"] = request;
            return new JsonResult(response);
        }
    }
}


