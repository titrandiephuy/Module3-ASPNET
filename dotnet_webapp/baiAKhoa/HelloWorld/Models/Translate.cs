using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace HelloWorld.Models
{
    public class Translate
    {
        [Required (ErrorMessage = "This field is required")]
        public string Keyword{ get; set; }
        public string Result{ get; set; } 
    }
}
