using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        private List<OrderItem> _cart = new List<OrderItem>();
        private OrderCalculater _Calculater = new OrderCalculater();
        private ReceiptLogger _Logger;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCustomerType.SelectedIndex = 0;


            ReceiptLogger.LogDelegate logActions = LogToListBox;
            logActions += LogToFile;
            _Logger = new ReceiptLogger(logActions);

        }

        private decimal RegularDiscount(decimal total) => total;
        private decimal SrudentDiscount(decimal total) => total * 0.85m;
        private decimal VipDiscount(decimal total) => total * 0.75m;

        private OrderCalculater.DiscountDelegate GetSelectedDiscountStrategy()
        {
            switch (cbCustomerType.SelectedIndex)
            {
                case 1: return SrudentDiscount;
                case 2: return VipDiscount;
                default: return RegularDiscount;
            }
        }



        private void UpdateTotals()
        {
            decimal subTotal = _Calculater.CalculateSubTotal(_cart);

            decimal finalTotal = _Calculater.CalculateFinalTotal(subTotal, GetSelectedDiscountStrategy());

            lblSubTotal.Text = $"SubTotal: {subTotal:0.00} JD";
            lblFinalTotal.Text = $"Final Total: {finalTotal:0.00} JD";
        }


        private void LogToListBox(string message)
        {
            lstLogs.Items.Add(message);
        }

        private void LogToFile(string message)
        {
            using (StreamWriter writer = new StreamWriter("receipts.txt", true))
            {
                writer.WriteLine(message);
            }
        }

        private void RefreshCartList()
        {
            lstCart.Items.Clear();

            foreach (OrderItem item in _cart)
            {
                lstCart.Items.Add(item);
            }
        }

        private void ProductCard_OnItemAdded(object sender, ctrProductCard.OrderItemEventArgs e)
        {
            OrderItem existingItem = null;

            foreach (OrderItem item in _cart)
            {
                if (item.ItemName == e.ProductName)
                {
                    existingItem = item;
                    break;
                }
            }

            if (existingItem != null)
            {
                existingItem.Quantity += e.Quantity;
            }
            else
            {
                _cart.Add(new OrderItem(e.ProductName, e.UnitPrice, e.Quantity));
            }

            RefreshCartList();
           UpdateTotals();
        }

        private void CbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            lstCart.Items.Clear();
            UpdateTotals();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if(_cart.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subTotal = _Calculater.CalculateSubTotal(_cart);
            decimal finalTotal = _Calculater.CalculateFinalTotal(subTotal, GetSelectedDiscountStrategy());

            string receipt = $"[{DateTime.Now::hh::mm:ss}] Items: {_cart.Count} | {cbCustomerType.Text} | Total: {finalTotal:0.00} JD";

            _Logger.Log(receipt);

            MessageBox.Show($"Payment Sussessful!\nTotal Paid: {finalTotal:0.00} JD", "Chechout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _cart.Clear();
            lstCart.Items.Clear();
            UpdateTotals();

        }
    }
}
