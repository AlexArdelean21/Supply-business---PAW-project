using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supply_business.Classes;
using Supply_business.Entities;

namespace Supply_business.Forms
{
    public partial class AddEditContract : Form
    {   
        public Good thisGood { get; set; }
        public AddEditContract()
        {
            InitializeComponent();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            if(thisGood != null)
            {
                thisGood.Name = txtName.Text;
                thisGood.Description = txtDescription.Text;
                thisGood.Price =(decimal)numPrice.Value;
                thisGood.Quantity = (int)numQuantity.Value;

            }
        }

        private void AddEditContract_Load(object sender, EventArgs e)
        {
            if (thisGood != null)
            {
                txtName.Text = thisGood.Name;
                txtDescription.Text = thisGood.Description;
                numPrice.Value = thisGood.Price;
                numQuantity.Value = thisGood.Quantity;

            }
        }

        private void txtGood_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Good is required");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Description is required");
            }
        }
    }
}
