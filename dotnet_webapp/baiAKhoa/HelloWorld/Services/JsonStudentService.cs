using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HelloWorld.Helper;
using HelloWorld.Models;
using Microsoft.AspNetCore.Hosting;

namespace HelloWorld.Services
{
    public class JsonStudentService: BaseService, IStudentService
    {
        private string filename = "student.json";
        private static List<Student> students = new List<Student>();
        public JsonStudentService (IWebHostEnvironment webHostEnviroment): base(webHostEnviroment)
        {
            students = FileHelper.ReadFile<List<Student>>(Path.Combine(path, filename));

        }
        

        public bool Create(Student student)
        {
            try
            {
                student.StudentId = students.Count > 0 ? students.Max(s => s.StudentId) + 1 : 1;
                students.Add(student);
                FileHelper.WriteFile<List<Student>>(Path.Combine(path, filename), students);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Student> Gets()
        {
            return students;
        }
    }
}
