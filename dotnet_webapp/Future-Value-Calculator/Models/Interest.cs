using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Future_Value_Calculator.Models
{
    public class Interest
    {
        public double InvestmentAmount { get; set; }
        public double YearlyInterestRate { get; set; }
        public double NumberOfMonths { get; set; }
        public double Result { get; set; }
    }
}
