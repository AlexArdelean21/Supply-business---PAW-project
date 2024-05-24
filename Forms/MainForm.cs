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

        #region Displaying data
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            Contract.Goods.Clear();
            lsview1.Items.Clear();
            dt.Clear();

            string query = "SELECT * FROM Contracts";
            dBAccess.readDatathroughAdapter(query, dt);

            foreach (DataRow row in dt.Rows)
            {
                Good good = new Good(row);
                Contract.Goods.Add(good);
            }
            DisplayContent1();
        }
        private void DisplayContent1()
        {
            lsview1.Items.Clear();

            Contract.Goods.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (var good in Contract.Goods)
            {
                ListViewItem lvi = new ListViewItem(good.Name);
                lvi.SubItems.Add(good.Description);
                lvi.SubItems.Add(good.Quantity.ToString());
                lvi.SubItems.Add(good.Price.ToString("C")); // Format price as currency 


                // Assuming SupplierName and DeliveryService are enums or strings
                lvi.SubItems.Add(good.supplier.SupplierName.ToString());
                lvi.SubItems.Add(good.supplier.DeliveryService.ToString());

                lvi.Tag = good;
                lsview1.Items.Add(lvi);
            }
            TotalContracts.Text = "Total Contracts: " + Contract.Goods.Count;
        }
        #endregion

        #region Add, edit, delete contracts


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
            if (lsview1.SelectedItems.Count == 1)
            {
                Good good = (Good)lsview1.SelectedItems[0].Tag;
                AddEditContract addEditContract = new AddEditContract
                {
                    thisGood = good
                };

                if (addEditContract.ShowDialog() == DialogResult.OK)
                {
                    DisplayContent1();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            if (lsview1.SelectedItems.Count == 1)
            {
                Good good = (Good)lsview1.SelectedItems[0].Tag;
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Contract.Goods.Remove(good);
                    DisplayContent1();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
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
            try
            {
                // Clear existing data in the database
                string deleteQuery = "DELETE FROM Contracts";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, dBAccess.connection);
                dBAccess.createConn();
                deleteCommand.ExecuteNonQuery();
                dBAccess.closeConn();

                // Insert current data from ListView
                foreach (var good in Contract.Goods)
                {
                    string currentName = good.Name;
                    string currentDescription = good.Description;
                    decimal currentPrice = good.Price;
                    int currentQuantity = good.Quantity;
                    _SupplierName currentSupplirt = good.supplier.SupplierName;
                    _DeliveryService currentDelivery = good.supplier.DeliveryService;

                    string insertQuery = "INSERT INTO Contracts (Name, Description, Price, Quantity, Supplier, Delivery) VALUES (@Name, @Description, @Price, @Quantity, @Supplier, @Delivery)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, dBAccess.connection);

                    insertCommand.Parameters.AddWithValue("@Name", good.Name);
                    insertCommand.Parameters.AddWithValue("@Description", good.Description);
                    insertCommand.Parameters.AddWithValue("@Price", good.Price);
                    insertCommand.Parameters.AddWithValue("@Quantity", good.Quantity);
                    insertCommand.Parameters.AddWithValue("@Supplier", good.supplier.SupplierName.ToString());
                    insertCommand.Parameters.AddWithValue("@Delivery", good.supplier.DeliveryService.ToString());

                    dBAccess.createConn();
                    insertCommand.ExecuteNonQuery();
                    dBAccess.closeConn();
                }

                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }


        #endregion

        #region Context menu
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayContent1();
        }
        private void addContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBtn_Click(sender, e);
        }
        private void editContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBtn_Click(sender, e);
        }
        private void deleteContractToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            deleteBtn1_Click(sender, e);
        }

        #endregion

        #region serialization and export reports
        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Serialize the goods to a file
                SerializationHelper.SerializeGoods(Contract.Goods, "goods.dat");
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Deserialize the goods from a file
                Contract.Goods = SerializationHelper.DeserializeGoods("goods.dat");
                DisplayContent1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private string GenerateReportContent()
        {
            StringBuilder reportContent = new StringBuilder();
            reportContent.AppendLine("Goods Report");
            reportContent.AppendLine("=============");
            reportContent.AppendLine();

            foreach (var good in Contract.Goods)
            {
                reportContent.AppendLine($"Name: {good.Name}");
                reportContent.AppendLine($"Description: {good.Description}");
                reportContent.AppendLine($"Price: {good.Price:C}");
                reportContent.AppendLine($"Quantity: {good.Quantity}");
                reportContent.AppendLine($"Supplier Name: {good.supplier.SupplierName}");
                reportContent.AppendLine($"Delivery Service: {good.supplier.DeliveryService}");
                reportContent.AppendLine("-------------------------------");
            }

            return reportContent.ToString();
        }

        private void ExportReportToFile(string reportContent)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, reportContent);
                        MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportReport_Click(object sender, EventArgs e)
        {
            string reportContent = GenerateReportContent();
            ExportReportToFile(reportContent);
        }

        #endregion

        #region random
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm();
            statsForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void MainForm_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
    }
}
