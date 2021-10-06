using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Calculate());
        }
        [HttpPost]
        public IActionResult Calculate(Calculate model)
        {
            if(ModelState.IsValid)
            {
                model.Result = "";
                var bmi = model.Weight / (model.Height * model.Height);
                if(bmi < 18.5)
                {
                    model.Result = "Underweight";
                 }
                else if(bmi < 24.9)
                {
                    model.Result = "Normal";
                }
                else if(bmi < 29.9)
                {
                    model.Result = "Overweight";
                }
                else if(bmi < 34.9)
                {
                    model.Result = "Obese!";
                } else if (bmi > 35)
                {
                    model.Result = "Extremely obese!";
                }
                return View("~/Views/BMI/Index.cshtml",model);
            }
            return View("~/Views/BMI/Index.cshtml", model);
        }
    }
}
