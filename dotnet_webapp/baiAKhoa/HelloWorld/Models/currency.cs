using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Currency
    {
        [Required]
        public double USD { get; set; }
        [Required]
        public double Rate { get; set; }
        public double Result { get; set; }
    }
}
