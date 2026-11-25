using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSmartPOS
{

    public partial class ctrProductCard : UserControl
    {
        public ctrProductCard()
        {
            InitializeComponent();
        }
    public class OrderItemEventArgs : EventArgs
    {
        public string ProductName { get; }
        public decimal UnitPrice { get; }
        public int Quantity { get; }
        public decimal TotalPrice { get; }

        public OrderItemEventArgs(string productName, decimal unitPrice, int quantity)
        {
            this.ProductName = productName;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.TotalPrice = UnitPrice * Quantity;
        }
    }

        [Category("POS Events")]
        public event EventHandler<OrderItemEventArgs> OnItemAdded;

        private string _productName = "Espresso";
        private decimal _unitPrice = 2.50m;

        [Category("Product Info")]
        public string ItemName
        {
            get { return _productName; }
            set {
                _productName = value;
                lblProductName.Text = value;
            }
        }

        [Category("Product Info")]
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                _unitPrice = value;
                lblPrice.Text = $"{value:0.00} JD";
            }
        }

        private void RaiseOnItemAdded(string ProductName, decimal UnitPrice, int Quantity)
        {
            RaiseOnItemAdded(new OrderItemEventArgs(ProductName, UnitPrice, Quantity));
        }

        protected virtual void RaiseOnItemAdded(OrderItemEventArgs e)
        {
            OnItemAdded?.Invoke(this, e);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (OnItemAdded != null)
                RaiseOnItemAdded(_productName, UnitPrice, (int)numQuantity.Value);
            numQuantity.Value = 1;
        }
    }
}
