using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic12Assigment
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            string item;
            int quantity;
            double price, totalPrice;
            item = txtItem.Text;
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(updQuantity.Value);
            totalPrice = (price * quantity) + (price * 0.13);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Text = "Total for " + quantity + " " + item + "(s): " + totalPrice.ToString("C");
            
        }


    }
}
