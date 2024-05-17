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
using DatabaseProject;
using System.Data.SqlClient;

namespace Supply_business.Forms
{
    public partial class MainForm : Form
    {
        public Contracts Contract;
        DBAccess dBAccess = new DBAccess();
        public MainForm()
        {
            Contract = new Contracts();
            InitializeComponent();
        }

        #region Add, edit, delete goods
        private void DisplayContent1()
        {
            lsview1.Items.Clear();
            //Contract.Goods.Sort();
            
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
        private void lsview1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddEditContract addEditContract = new AddEditContract();
            if (lsview1.SelectedItems.Count == 1)
            {

                Good good = (Good)lsview1.SelectedItems[0].Tag as Good;
                addEditContract.thisGood = good;

                if (addEditContract.ShowDialog() == DialogResult.OK)
                {
                    DisplayContent1();
                }
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
            if (lsview1.SelectedItems.Count == 1)
            {

                Good good = (Good)lsview1.SelectedItems[0].Tag as Good;
                addEditContract.thisGood = good;

                if (addEditContract.ShowDialog() == DialogResult.OK)
                {
                    DisplayContent1();
                }
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
        #endregion

        #region Add, edit, delete suppliers
        private void DisplayContent2()
        {
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
        private void lsview2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddEditSuppliercs addEditSuppliercs = new AddEditSuppliercs();
            if (lsview2.SelectedItems.Count == 1)
            {
                Supplier supplier = (Supplier)lsview2.SelectedItems[0].Tag as Supplier;
                addEditSuppliercs.thisSupplier = supplier;

                if (addEditSuppliercs.ShowDialog() == DialogResult.OK)
                {
                    DisplayContent2();
                }
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
            Supplier supplier = (Supplier)lsview2.SelectedItems[0].Tag as Supplier;
            addEditSuppliercs.thisSupplier = supplier;

            if (addEditSuppliercs.ShowDialog() == DialogResult.OK)
            {
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
        #endregion

        #region Key shortcuts
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control && e.KeyCode == Keys.A) // Add good
            {
                AddBtn_Click(sender, e);
                return;
            }

            if (e.Alt && e.Control && e.KeyCode == Keys.E) // Edit good
            {
                EditBtn_Click(sender, e);
                return;
            }

            if (e.Alt && e.Control && e.KeyCode == Keys.D)
            {
                deleteBtn1_Click(sender, e); // Delete good
                return;
            }

            if (e.Alt && e.KeyCode == Keys.A)
            {
                AddBtn2_Click(sender, e); // Add supplier
                return;
            }

            if (e.Alt && e.KeyCode == Keys.E)
            {
                EditBtn2_Click(sender, e); // Edit supplier
                return;
            }

            if (e.Alt && e.KeyCode == Keys.D)
            {
                deleteBtn2_Click(sender, e); // Delete supplier
                return;
            }
        }


        #endregion

        #region Save and Load to DataBase
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var good in Contract.Goods)
            {
                string currentName = good.Name;
                string currentDescription = good.Description;
                decimal currentPrice = good.Price;
                int currentQuantity = good.Quantity;

                SqlCommand sqlCommand = new SqlCommand("insert into Goods(Name,Description,Price,Quantity) values(@currentName,@currentDescription,@currentPrice,@currentQuantity)");

                sqlCommand.Parameters.AddWithValue("@currentName", currentName);
                sqlCommand.Parameters.AddWithValue("@currentDescription", currentDescription);
                sqlCommand.Parameters.AddWithValue("@currentPrice", currentPrice);
                sqlCommand.Parameters.AddWithValue("@currentQuantity", currentQuantity);

                int row = dBAccess.executeQuery(sqlCommand);
                if (row == 1)
                {
                    MessageBox.Show("Good added successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                } 
            }
            #endregion

            // i could make the supplier an enum(amazon, alibalba, shein, etc) and add a field
            // to the good class that would be the supplier, and then i could add a combobox to the form
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
