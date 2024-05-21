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
using System.Diagnostics.Contracts;

namespace Supply_business.Forms
{
    public partial class MainForm : Form
    {
        public Contracts Contract;
        DBAccess dBAccess = new DBAccess();
        DataTable dt = new DataTable();
        public MainForm()
        {
            Contract = new Contracts();
            InitializeComponent();
        }

        #region Add, edit, delete goods
        private void DisplayContent1()
        {
            lsview1.Items.Clear();

            Contract.Goods.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (var good in Contract.Goods)
            {
                ListViewItem lvi = new ListViewItem(good.Name);
                lvi.SubItems.Add(good.Description);
                lvi.SubItems.Add(good.Price.ToString("C")); // Format price as currency
                lvi.SubItems.Add(good.Quantity.ToString());

                // Assuming SupplierName and DeliveryService are enums or strings
                lvi.SubItems.Add(good.supplier.SupplierName.ToString());
                lvi.SubItems.Add(good.supplier.DeliveryService.ToString());

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
                Good good = (Good)lsview1.SelectedItems[0].Tag;
                addEditContract.thisGood = good;

                if (addEditContract.ShowDialog() == DialogResult.OK)
                {
                    // Update the database with the new values
                    DBAccess dBAccess = new DBAccess();
                    int rowsAffected = dBAccess.UpdateGood(good);

                    if (rowsAffected > 0)
                    {
                        // Refresh the ListView to reflect changes
                        DisplayContent1();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the database.");
                    }
                }
            }
        }


        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            if (lsview1.SelectedItems.Count == 1)
            {
                Good good = (Good)lsview1.SelectedItems[0].Tag;

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DBAccess dBAccess = new DBAccess();
                    int rowsAffected = dBAccess.DeleteGood(good.GoodId);

                    if (rowsAffected > 0)
                    {
                        // Remove from the in-memory list
                        Contract.Goods.Remove(good);

                        // Refresh the ListView to reflect changes
                        DisplayContent1();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete from the database.");
                    }
                }
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
                _SupplierName currentSupplirt = good.supplier.SupplierName;
                _DeliveryService currentDelivery = good.supplier.DeliveryService;

                string query = "IF NOT EXISTS (SELECT 1 FROM Contracts WHERE Name = @currentName AND Description = @currentDescription)" +
                               "INSERT INTO Contracts(Name, Description, Price, Quantity, Supplier, Delivery) " +
                               "VALUES (@currentName, @currentDescription, @currentPrice, @currentQuantity, @currentSupplier, @currentDelivery)";

                SqlCommand sqlCommand = new SqlCommand(query);
                sqlCommand.Parameters.AddWithValue("@currentName", good.Name);
                sqlCommand.Parameters.AddWithValue("@currentDescription", good.Description);
                sqlCommand.Parameters.AddWithValue("@currentPrice", good.Price);
                sqlCommand.Parameters.AddWithValue("@currentQuantity", good.Quantity);
                sqlCommand.Parameters.AddWithValue("@currentSupplier", good.supplier.SupplierName.ToString());
                sqlCommand.Parameters.AddWithValue("@currentDelivery", good.supplier.DeliveryService.ToString());

                int rowsAffected = dBAccess.executeQuery(sqlCommand);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Good added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding good");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Contract.Goods.Clear();
            lsview1.Items.Clear();

            string query = "select * from Contracts";
            dBAccess.readDatathroughAdapter(query, dt);

            foreach (DataRow row in dt.Rows)
            {
                //var good = new Good(row);

                //ListViewItem lvi = new ListViewItem(good.Name);
                //lvi.SubItems.Add(good.Description);
                //lvi.SubItems.Add(good.Price.ToString("C"));
                //lvi.SubItems.Add(good.Quantity.ToString());

                //lvi.SubItems.Add(good.supplier.SupplierName.ToString());
                //lvi.SubItems.Add(good.supplier.DeliveryService.ToString());

                //lvi.Tag = good;
                //lsview1.Items.Add(lvi);

                Good good = new Good(row);
                Contract.Goods.Add(good);
            }
            DisplayContent1();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
