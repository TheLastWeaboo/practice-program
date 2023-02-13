using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork6
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void lblSelectedProduct_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lsbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connect selected label to  listbox products
            lblSelectedProduct.Text = lsbProducts.SelectedIndex.ToString();
            string name = lsbProducts.SelectedItem.ToString();
           
            int price = 0;

            lblProducts.Text = name;         
            if (name.ToLower().Contains("sword")) 
            {
                price = 150;
            }
            else if (name.ToLower().Contains("helmet"))
            {
                price = 50;
            }
            else if (name.ToLower().Contains("chainmail"))
            {
                price = 75;
            }
            else if (name.ToLower().Contains("healt"))
            {
                price = 5;
            }
            else if (name.ToLower().Contains("mana"))
            {
                price = 10;
            }
            else
            {
                price = 0;
            }
            lblItemPrice.Text = price.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGrandTotalPrice_Click(object sender, EventArgs e)
        {
          
        }
    }
}
