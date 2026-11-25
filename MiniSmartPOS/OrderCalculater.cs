using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSmartPOS
{
    public class OrderCalculater
    {
        public delegate decimal DiscountDelegate(decimal subTotal);

        public decimal CalculateSubTotal(List<OrderItem> cart)
        {
            decimal total = 0;
            foreach (OrderItem item in cart)
            {
                total += item.TotalPrice;
            }
            return total;
        }

        public decimal CalculateFinalTotal(decimal subTotal, DiscountDelegate applyDiscount)
        {
            if (applyDiscount == null)
                return subTotal;

            return applyDiscount(subTotal);
        }
    }
}
