using System;
using System.Collections.Generic;
using HelloWorld.Models;

namespace HelloWorld.Services
{
    public interface IStudentService
    {
        List<Student> Gets();
        bool Create(Student student);
    }
}
