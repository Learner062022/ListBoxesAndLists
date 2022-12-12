using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaEx7List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<string> products = new List<string>();
        List<double> prices = new List<double>();
        double dblPrice = 0;
        
        private void btnProductsAbove_Click(object sender, EventArgs e)
        {
            if (products.Count() > 0 | prices.Count() > 0)
            {
                lstProductsPrices.Items.Add("Products\tPrices");
                for (int intsubscript = 0; intsubscript < prices.Count; intsubscript++)
                {
                    if (prices[intsubscript] > 10)
                    {
                        lstProductsPrices.Items.Add(products[intsubscript] + "\t" + prices[intsubscript].ToString("C"));
                    }
                }
            }
            else 
            {
                MessageBox.Show("The product and the price both need to be provided");
            }
        }

        private void btnAcceptProduct_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Length > 0 && txtPrice.Text.Length > 0)
            {
                products.Add(txtProduct.Text);
                dblPrice = double.Parse(txtPrice.Text);
                prices.Add(dblPrice);

            }
            else if (txtProduct.Text.Length == 0 | txtPrice.Text.Length == 0)
            {
                MessageBox.Show("The product and the price both need to be provided");
            }
        }
    }
}
