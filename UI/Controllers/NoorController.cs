using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UI.Controllers
{
    [Route("[controller]")]
    public class NoorController : Controller
    {
        private readonly ILogger<NoorController> _logger;

        public NoorController(ILogger<NoorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("opera")]
        public IActionResult opera()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        
        [HttpGet("mc")]
        public IActionResult mc()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}