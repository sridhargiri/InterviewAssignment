using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRuleRepository _ruleRepository;

        public HomeController(ILogger<HomeController> logger, IRuleRepository ruleRepository)
        {
            _logger = logger; _ruleRepository = ruleRepository;
        }

        public IActionResult Index()
        {
            ViewBag.ListofCountry = _ruleRepository.GetRules(); return View();
        }
        [HttpPost("Home/Demo")]
        public IActionResult Index(RuleItem ruleItem)
        {
            string rule = _ruleRepository.GetRuleByPaymentType(ruleItem.Id);
            ViewBag.ListofCountry = _ruleRepository.GetRules();

            ViewBag.SelectedValue = rule == null ? "invalid selection" : rule;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
