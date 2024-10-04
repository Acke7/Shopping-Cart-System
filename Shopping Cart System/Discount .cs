using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_System
{
    internal class Discount
    {
        public decimal Percentage { get; set; }
        public Discount(decimal percentage)
        {
            Percentage = percentage;
        }

        public decimal Apply(decimal totalPrice)
        {
            return totalPrice - (totalPrice * Percentage / 100);
        }
    }
}
