using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSmartPOS
{
    public class OrderItem
    {
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;

        public OrderItem(string ItemName, decimal UnitPrice, int quantity)
        {
            this.ItemName = ItemName;
            this.UnitPrice = UnitPrice;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{ItemName}  x{Quantity}  =  {TotalPrice:0.00} JD";
        }
    }
}
