using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace HelloWorld.Models
{
    public class Calculate
    {
            [Required(ErrorMessage = "This field is required")]
            public double Weight { get; set; }
            [Required(ErrorMessage = "This field is required")]
            public double Height { get; set; }
            public string Result { get; set; }
    }
}
