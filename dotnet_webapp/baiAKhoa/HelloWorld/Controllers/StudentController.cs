using HelloWorld.Models;
using HelloWorld.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class StudentController : Controller

    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public IActionResult Index()
        {
            //ViewBag.StudentId = id;
            //ViewData["StudentId"] = id;

            return View("~/Views/Student/Student.cshtml", studentService.Gets());
        }

        //Attribute routing
        //[Route("/Student/Detail/{stdId}/{fn}")]
        public IActionResult Detail(int stdId, string fn)
        {
            var studentDetail = new StudentDetail()
            {
                Fullname = fn,
                StudentId = stdId
            };
            return View(studentDetail);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                studentService.Create(student);
                return RedirectToAction("Index");
            }
            return View();
        }
    }

    public class StudentDetail
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
    }
}
