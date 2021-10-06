﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EVDictionary.Models;

namespace EVDictionary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Index()
        {
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
      
        [HttpPost]
        public IActionResult Index(string word)
        {
            Dictionary<string, string> libs = new Dictionary<string, string>();
            libs.Add("hello", "Xin Chào");
            libs.Add("book", "quyển sách");
            libs.Add("school", "trường học");
            libs.Add("employee", "nhân viên");

            ViewData["result"] = "Find not found!";

            foreach (var item in libs)
            {
                if (item.Key == word)
                {
                    ViewData["result"] = "English: " + item.Key + "_________" + "Việt Nam: " + item.Value;
                }
            }
            return View();
        }
    }
}
