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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lstTravelMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Delclare array to hold prices matching the items
            double[] dblCosts = { 250, 900, 400 };
            // Declare and initialise variables
            uint uintNumberTravellers;
            int intCostIndex;
            double dblTravelCost, dblCharge;

            // Check that the number of travellers has been entered
            if (!uint.TryParse(txtNumberTravellers.Text, out uintNumberTravellers))
            {
                MessageBox.Show("A number must be entered");
                txtNumberTravellers.Clear();
                txtNumberTravellers.Focus();
            }
            else // Calculate the travel cost
            {
                // Get the position (index) in the listbox array of the selectd transport
                intCostIndex = lstTravelMethods.SelectedIndex;
                // Price of transport will be at the same index position in the costs array
                dblCharge = dblCosts[intCostIndex];
                // Calcualate total cost
                dblTravelCost = dblCharge * uintNumberTravellers;
                // Display the calculation as a string
                txtTravelCost.Text = dblTravelCost.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTravelCost.Clear();
            txtNumberTravellers.Clear();
            txtNumberTravellers.Focus();
            // How clear item?
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
