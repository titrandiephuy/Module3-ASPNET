using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HelloWorld.Services
{
    public class BaseService
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        protected string path;
        public BaseService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            path = Path.Combine(webHostEnvironment.ContentRootPath, "wwwroot", "json");
        }
    }
}
