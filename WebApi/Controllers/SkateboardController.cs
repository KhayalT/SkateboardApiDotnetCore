using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    public class SkateboardController : ControllerBase
    {
        ISkateboardService _skateboardService;

        public SkateboardController(ISkateboardService skateboardService)
        {
            _skateboardService = skateboardService;
        }

        /// <summary>
        /// Listed All Skateboards with relation
        /// </summary>
        /// <returns></returns>
        [Route("api/products")]
        public IActionResult Get()
        {
            var result = _skateboardService.GetAllSkateboardDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
