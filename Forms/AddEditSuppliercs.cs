using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supply_business.Entities;

namespace Supply_business.Forms
{
    public partial class AddEditSuppliercs : Form
    {
        public Supplier thisSupplier { get; set; }
        public AddEditSuppliercs()
        {
            InitializeComponent();
        }

        private void AddEditSuppliercs_Load(object sender, EventArgs e)
        {
            if (thisSupplier != null)
            {
                txtName.Text = thisSupplier.Name;
                txtEmail.Text = thisSupplier.Email;
                Close();
            }
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (thisSupplier != null)
            {
                thisSupplier.Name = txtName.Text;
                thisSupplier.Email = txtEmail.Text;
                Close();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Name is required");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Email is required");
            }
        }
    }
}
