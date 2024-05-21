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

            // Optional: Sort the goods if necessary.
            // Contract.Goods.Sort((x, y) => x.Name.CompareTo(y.Name));

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

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
