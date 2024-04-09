using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pricequotation.Models
{
    public class PriceQuotaionModelForCalc
    {
        // validation for subtotal
        [Required(ErrorMessage = "The sales price is required")]
        [Range(11, int.MaxValue, ErrorMessage =
               "the sales price is required and must be a valid number that is greater than 10")]
        public decimal? subtotal { get; set; }

        // validation for Discount percentage.
        [Required(ErrorMessage = "The discount percent is required.")]
        [Range(10, 50, ErrorMessage = "The discount percent is required and must be a valid number from 10 to 50")]
        public decimal? Dispercent { get; set; }

        // this method calculates discount amount from subtotal and discount percentage enetered by user
        public decimal? CalcDisAmt()
        {
            decimal? dis = Dispercent / 100;
            decimal? disamt = subtotal * dis;
            return disamt;
        }

        // // this method calculates total from subtotal and discount percentage enetered by user
        public decimal? CalcTotal()
        {
            decimal? dis = Dispercent / 100;
            decimal? disamt = subtotal * dis;
            decimal? total = subtotal - disamt;
            return total;
        }
    }
}
