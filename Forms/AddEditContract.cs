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
            if (thisGood != null)
            {
                thisGood.Name = txtName.Text;
                thisGood.Description = txtDescription.Text;
                thisGood.Price = (decimal)numPrice.Value;
                thisGood.Quantity = (int)numQuantity.Value;

                // Update supplier and delivery service from ComboBox selections
                if (BoxSupplier.SelectedItem != null)
                {
                    thisGood.supplier.SupplierName = (_SupplierName)BoxSupplier.SelectedItem;
                }

                if (BoxDelivery.SelectedItem != null)
                {
                    thisGood.supplier.DeliveryService = (_DeliveryService)BoxDelivery.SelectedItem;
                }
            }
        }
        public void AddEditContract_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with enum values
            BoxSupplier.DataSource = Enum.GetValues(typeof(_SupplierName));
            BoxDelivery.DataSource = Enum.GetValues(typeof(_DeliveryService));

            if (thisGood != null)
            {
                txtName.Text = thisGood.Name;
                txtDescription.Text = thisGood.Description;
                numPrice.Value = thisGood.Price;
                numQuantity.Value = thisGood.Quantity;

                // Set the ComboBox selected index 
                var supplierEnum = (_SupplierName)thisGood.supplier.SupplierName;
                if (Enum.IsDefined(typeof(_SupplierName), supplierEnum))
                {
                    BoxSupplier.SelectedItem = supplierEnum;
                }
                else
                {
                    BoxSupplier.SelectedIndex = -1; 
                }

                var deliveryEnum = (_DeliveryService)thisGood.supplier.DeliveryService;
                if (Enum.IsDefined(typeof(_DeliveryService), deliveryEnum))
                {
                    BoxDelivery.SelectedItem = deliveryEnum;
                }
                else
                {
                    BoxDelivery.SelectedIndex = -1; 
                }
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
