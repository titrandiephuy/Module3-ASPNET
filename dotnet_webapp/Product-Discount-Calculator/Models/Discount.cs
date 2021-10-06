using System;
namespace Product_Discount_Calculator.Models
{
    public class Discount
    {
        public string ProductDes { get; set; }
        public double ListPrice { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountPrice { get; set; }
    }
}
