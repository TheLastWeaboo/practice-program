namespace Classwork6
{
    partial class frmPayment
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
            this.lsbProducts = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceList = new System.Windows.Forms.ListBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.ListBox();
            this.lblGrandTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbProducts
            // 
            this.lsbProducts.FormattingEnabled = true;
            this.lsbProducts.ItemHeight = 20;
            this.lsbProducts.Items.AddRange(new object[] {
            "Rusty Sword",
            "Worn Helmet",
            "Bloody Chainmail",
            "Health Potion",
            "Mana Potion"});
            this.lsbProducts.Location = new System.Drawing.Point(51, 47);
            this.lsbProducts.Name = "lsbProducts";
            this.lsbProducts.Size = new System.Drawing.Size(120, 84);
            this.lsbProducts.TabIndex = 0;
            this.lsbProducts.SelectedIndexChanged += new System.EventHandler(this.lsbProducts_SelectedIndexChanged);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(26, 24);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(93, 20);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "List of Products";
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.BackColor = System.Drawing.Color.White;
            this.lblSelectedProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedProduct.Location = new System.Drawing.Point(95, 146);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(112, 25);
            this.lblSelectedProduct.TabIndex = 2;
            this.lblSelectedProduct.Click += new System.EventHandler(this.lblSelectedProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Price:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BackColor = System.Drawing.Color.White;
            this.lblItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemPrice.Location = new System.Drawing.Point(95, 175);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(112, 25);
            this.lblItemPrice.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "List of Ordered Products:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "List of Ordered Prices:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "List of Ordered Total Price:";
            // 
            // PriceList
            // 
            this.PriceList.FormattingEnabled = true;
            this.PriceList.ItemHeight = 20;
            this.PriceList.Location = new System.Drawing.Point(164, 302);
            this.PriceList.Name = "PriceList";
            this.PriceList.Size = new System.Drawing.Size(113, 24);
            this.PriceList.TabIndex = 11;
            this.PriceList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 20;
            this.ProductList.Location = new System.Drawing.Point(164, 267);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(113, 24);
            this.ProductList.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Grand Total Price:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.FormattingEnabled = true;
            this.TotalPrice.ItemHeight = 20;
            this.TotalPrice.Location = new System.Drawing.Point(164, 332);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(113, 24);
            this.TotalPrice.TabIndex = 14;
            // 
            // lblGrandTotalPrice
            // 
            this.lblGrandTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblGrandTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotalPrice.Location = new System.Drawing.Point(163, 363);
            this.lblGrandTotalPrice.Name = "lblGrandTotalPrice";
            this.lblGrandTotalPrice.Size = new System.Drawing.Size(112, 25);
            this.lblGrandTotalPrice.TabIndex = 15;
            this.lblGrandTotalPrice.Text = "0";
            this.lblGrandTotalPrice.Click += new System.EventHandler(this.lblGrandTotalPrice_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.lblGrandTotalPrice);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.PriceList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectedProduct);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lsbProducts);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lsbProducts;
        private Label lblProducts;
        private Label lblSelectedProduct;
        private Label label1;
        private Label label2;
        private Label lblItemPrice;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private ListBox PriceList;
        private ListBox ProductList;
        private Label label7;
        private ListBox TotalPrice;
        private Label lblGrandTotalPrice;
    }
}