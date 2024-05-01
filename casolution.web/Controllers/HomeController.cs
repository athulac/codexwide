using casolution.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace casolution.web.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("Home")]
        [Route("Index")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }


        [Route("services/web-sites-designing")]
        public IActionResult WebSitesDesign()
        {
            return View();
        }
        [Route("services/software-development")]
        public IActionResult SoftwareDevelopment()
        {
            return View();
        }
        [Route("services/search-engine-optimisation")]
        public IActionResult SearchEngineOptimisation()
        {
            return View();
        }
        [Route("services/system-analyze-and-design")]
        public IActionResult SystemAnalyzeDesign()
        {
            return View();
        }
        [Route("services/bussiness-process-re-engineering")]
        public IActionResult BPReEngineering()
        {
            return View();
        }
        [Route("services/case-studying")]
        public IActionResult CaseStudying()
        {
            return View();

        }
        [Route("services/3rd-party-integrations")]
        public IActionResult ThirdPartyIntegrations()
        {
            return View();

        }



        [Route("more-about/{id?}")]
        public IActionResult MoreAbout(int id)
        {
            return View();
        }
    }
}
