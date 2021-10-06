using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class CurrencyConverterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Currency());
        }
        [HttpPost]
        public IActionResult Index(Currency model)
        {
            if(ModelState.IsValid)
            {
                model.Result = model.USD * model.Rate;
                return View("~/Views/CurrencyConverter/Index.cshtml", model);
            }    
            return View("~/Views/CurrencyConverter/Index.cshtml", model);
        }

    }
}
