using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk7ExListComboBoxes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lstTravelMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the charge
            txtCharge.Clear();
            lstTravelMethods.SelectedIndex = -1;
        }

        private void btnShowCost_Click(object sender, EventArgs e)
        {
            //  Delclare array to hold prices matching the items
            double[] dblPrices = { 250, 900, 400 };
            double dbl_travel_cost, dbl_charge;
            int intPrices_index, int_num_travellers;

            // Check that a travel method has been selected
            if (lstTravelMethods.SelectedIndex < 0) 
            {
                MessageBox.Show("No travel method has been selected");
            }
            // Check that the number of travellers has been entered
            else if (!int.TryParse(txtNumberTravellers.Text, out int_num_travellers))
            {
                MessageBox.Show("The amount of travellers has not been entered or is not a number", "Invalid Entry");

                txtNumberTravellers.Clear();
                txtNumberTravellers.Focus();
            }
            else   // Calculate the travel cost
            {
                //  Get the position (index) in the list box array of the selected transport
                intPrices_index = lstTravelMethods.SelectedIndex;
                //   Price of transportation will be at the same index position in the prices array
                dbl_travel_cost = dblPrices[intPrices_index];
                //  Calculate charge
                dbl_charge = dbl_travel_cost * int_num_travellers;
                // Convert the charge to a string
                txtCharge.Text = dbl_charge.ToString("c");
            }
        }
    }
}       