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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNumberNames_Click(object sender, EventArgs e)
        {
            if (lstNames.Items.Count > 0)
            {
                MessageBox.Show(lstNames.Items.Count.ToString());
            }
            else if (lstNames.Items.Count == 0)
            {
                MessageBox.Show("0");
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Enter a name");
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                lstNames.Items.Remove(txtName.Text);
            }
            else
            {
                MessageBox.Show("Enter a name");
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex == -1)
            {
                MessageBox.Show("Select a name");
            }
            else
            {
                lstNames.Items.RemoveAt(lstNames.SelectedIndex);
            }
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            lstNames.Sorted = true;
        }
    }
}
