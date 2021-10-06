using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;


namespace HelloWorld.Controllers
{
    public class DictionaryController : Controller
    {
        public Dictionary<string, string> libs = new Dictionary<string, string>()
        {
            { "hello", "Xin Chào" },
            { "book", "quyển sách"},
            { "school", "trường học"},
            {"employee", "nhân viên"}
        };
        [HttpGet]
 
        public IActionResult Index()
        {

            return View(new Translate());
        }
        [HttpPost]
        public IActionResult Translate(Translate model)
        {
            if (ModelState.IsValid)
            {   
                model.Result = "";
                foreach (KeyValuePair<string, string> item in libs)
                {
                    if (item.Key.ToLower() == model.Keyword.ToLower())
                    {
                        model.Result = item.Value;
                        break;
                    }
                }
                return View("~/Views/Dictionary/Index.cshtml",model);

            }
            return View("~/Views/Dictionary/Index.cshtml", model);
        }
    }
}
