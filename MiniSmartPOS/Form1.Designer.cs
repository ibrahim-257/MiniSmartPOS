namespace MiniSmartPOS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.ctrProductCard4 = new MiniSmartPOS.ctrProductCard();
            this.ctrProductCard3 = new MiniSmartPOS.ctrProductCard();
            this.ctrProductCard2 = new MiniSmartPOS.ctrProductCard();
            this.ctrProductCard1 = new MiniSmartPOS.ctrProductCard();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.lstLogs);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnCheckout);
            this.guna2Panel1.Controls.Add(this.lblFinalTotal);
            this.guna2Panel1.Controls.Add(this.lblSubTotal);
            this.guna2Panel1.Controls.Add(this.cbCustomerType);
            this.guna2Panel1.Controls.Add(this.lstCart);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(496, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(390, 410);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(15, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Receipt Logs";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BorderRadius = 8;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(255, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.BorderRadius = 8;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(15, 300);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(230, 38);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.BackColor = System.Drawing.Color.White;
            this.lblFinalTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblFinalTotal.Location = new System.Drawing.Point(15, 265);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(159, 21);
            this.lblFinalTotal.TabIndex = 4;
            this.lblFinalTotal.Text = "Final Total:  0.00  JD";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.White;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSubTotal.Location = new System.Drawing.Point(15, 240);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(115, 17);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "SubTotal:  0.00  JD";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Items.AddRange(new object[] {
            "Regular (0%)",
            "Student (15%)",
            "VIP (25%)"});
            this.cbCustomerType.Location = new System.Drawing.Point(15, 199);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(360, 25);
            this.cbCustomerType.TabIndex = 2;
            this.cbCustomerType.SelectedIndexChanged += new System.EventHandler(this.CbCustomerType_SelectedIndexChanged);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lstCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 17;
            this.lstCart.Location = new System.Drawing.Point(15, 36);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(360, 136);
            this.lstCart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Cart";
            // 
            // lstLogs
            // 
            this.lstLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lstLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLogs.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.IntegralHeight = false;
            this.lstLogs.Location = new System.Drawing.Point(15, 368);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(360, 40);
            this.lstLogs.TabIndex = 8;
            // 
            // ctrProductCard4
            // 
            this.ctrProductCard4.BackColor = System.Drawing.Color.Transparent;
            this.ctrProductCard4.ItemName = "Club Sandwich";
            this.ctrProductCard4.Location = new System.Drawing.Point(260, 230);
            this.ctrProductCard4.Name = "ctrProductCard4";
            this.ctrProductCard4.Size = new System.Drawing.Size(230, 200);
            this.ctrProductCard4.TabIndex = 3;
            this.ctrProductCard4.UnitPrice = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ctrProductCard4.OnItemAdded += new System.EventHandler<MiniSmartPOS.ctrProductCard.OrderItemEventArgs>(this.ProductCard_OnItemAdded);
            // 
            // ctrProductCard3
            // 
            this.ctrProductCard3.BackColor = System.Drawing.Color.Transparent;
            this.ctrProductCard3.ItemName = "Orange Juice";
            this.ctrProductCard3.Location = new System.Drawing.Point(260, 20);
            this.ctrProductCard3.Name = "ctrProductCard3";
            this.ctrProductCard3.Size = new System.Drawing.Size(230, 200);
            this.ctrProductCard3.TabIndex = 2;
            this.ctrProductCard3.UnitPrice = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            this.ctrProductCard3.OnItemAdded += new System.EventHandler<MiniSmartPOS.ctrProductCard.OrderItemEventArgs>(this.ProductCard_OnItemAdded);
            // 
            // ctrProductCard2
            // 
            this.ctrProductCard2.BackColor = System.Drawing.Color.Transparent;
            this.ctrProductCard2.ItemName = "Iced Latte";
            this.ctrProductCard2.Location = new System.Drawing.Point(20, 230);
            this.ctrProductCard2.Name = "ctrProductCard2";
            this.ctrProductCard2.Size = new System.Drawing.Size(230, 200);
            this.ctrProductCard2.TabIndex = 1;
            this.ctrProductCard2.UnitPrice = new decimal(new int[] {
            350,
            0,
            0,
            131072});
            this.ctrProductCard2.OnItemAdded += new System.EventHandler<MiniSmartPOS.ctrProductCard.OrderItemEventArgs>(this.ProductCard_OnItemAdded);
            // 
            // ctrProductCard1
            // 
            this.ctrProductCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrProductCard1.ItemName = "Espresso";
            this.ctrProductCard1.Location = new System.Drawing.Point(20, 20);
            this.ctrProductCard1.Name = "ctrProductCard1";
            this.ctrProductCard1.Size = new System.Drawing.Size(230, 200);
            this.ctrProductCard1.TabIndex = 0;
            this.ctrProductCard1.UnitPrice = new decimal(new int[] {
            250,
            0,
            0,
            131072});
            this.ctrProductCard1.OnItemAdded += new System.EventHandler<MiniSmartPOS.ctrProductCard.OrderItemEventArgs>(this.ProductCard_OnItemAdded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(899, 460);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ctrProductCard4);
            this.Controls.Add(this.ctrProductCard3);
            this.Controls.Add(this.ctrProductCard2);
            this.Controls.Add(this.ctrProductCard1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Smart POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrProductCard ctrProductCard1;
        private ctrProductCard ctrProductCard2;
        private ctrProductCard ctrProductCard3;
        private ctrProductCard ctrProductCard4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLogs;
    }
}

