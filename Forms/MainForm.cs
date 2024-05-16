using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Supply_business.Classes;
using Supply_business.Entities;

namespace Supply_business.Forms
{
    public partial class MainForm : Form
    {
        public Contracts Contract;
        public MainForm()
        {
            Contract = new Contracts();
            InitializeComponent();
        }
        private void DisplayContent1()
        {
            lsview1.Items.Clear();
            Contract.Goods.Sort();
            
            foreach (var good in Contract.Goods)
            {
                ListViewItem lvi = new ListViewItem(good.Name);
                lvi.SubItems.Add(good.Description);
                lvi.SubItems.Add(good.Price.ToString());
                lvi.SubItems.Add(good.Quantity.ToString());
                lvi.Tag = good;
                lsview1.Items.Add(lvi);
            }
        }
        private void DisplayContent2() {
            lsview2.Items.Clear();
            Contract.Suppliers.Sort();

            foreach (var supplier in Contract.Suppliers)
            {
                ListViewItem lvi = new ListViewItem(supplier.Name);
                lvi.SubItems.Add(supplier.Email);
                lvi.Tag = supplier;
                lsview2.Items.Add(lvi);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditContract addEditContract = new AddEditContract();
            Good good = new Good();
            addEditContract.thisGood = good;

            if (addEditContract.ShowDialog() == DialogResult.OK)
            {
                Contract.Goods.Add(good);
                DisplayContent1();
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
                {
                    AddEditContract addEditContract = new AddEditContract();
                    Good good = (Good)lsview1.SelectedItems[0].Tag;
                    addEditContract.thisGood = good;

                    if (addEditContract.ShowDialog() == DialogResult.OK)
                    {
                        Contract.Goods.Add(good);
                        DisplayContent1();
                    }
                }
        private void lsview1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddEditContract addEditContract = new AddEditContract();
            Good good = (Good)lsview1.SelectedItems[0].Tag;
            addEditContract.thisGood = good;

            if (addEditContract.ShowDialog() == DialogResult.OK)
            {
                Contract.Goods.Add(good);
                DisplayContent1();
            }
        }
        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            if (lsview1.SelectedItems.Count > 0)
            {
                Contract.Goods.Remove((Good)lsview1.SelectedItems[0].Tag);
                DisplayContent1();
            }
        }
        private void AddBtn2_Click(object sender, EventArgs e)
        {
            AddEditSuppliercs addEditSuppliercs = new AddEditSuppliercs();
            Supplier supplier = new Supplier();
            addEditSuppliercs.thisSupplier = supplier;

            if (addEditSuppliercs.ShowDialog() == DialogResult.OK)
            {
                Contract.Suppliers.Add(supplier);
                DisplayContent2();
            }
        }
        private void EditBtn2_Click(object sender, EventArgs e)
        {
            AddEditSuppliercs addEditSuppliercs = new AddEditSuppliercs();
            Supplier supplier = (Supplier)lsview2.SelectedItems[0].Tag;
            addEditSuppliercs.thisSupplier = supplier;

            if (addEditSuppliercs.ShowDialog() == DialogResult.OK)
            {
                Contract.Suppliers.Add(supplier);
                DisplayContent2();
            }
        }
        private void lsview2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddEditSuppliercs addEditSuppliercs = new AddEditSuppliercs();
            Supplier supplier = (Supplier)lsview2.SelectedItems[0].Tag;
            addEditSuppliercs.thisSupplier = supplier;

            if (addEditSuppliercs.ShowDialog() == DialogResult.OK)
            {
                Contract.Suppliers.Add(supplier);
                DisplayContent2();
            }
        }
        private void deleteBtn2_Click(object sender, EventArgs e)
        {
            if (lsview2.SelectedItems.Count > 0)
            {
                Contract.Suppliers.Remove((Supplier)lsview2.SelectedItems[0].Tag);
                DisplayContent2();
            }
        }
    }
}
