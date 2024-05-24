using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject;
using Supply_business.Classes;

namespace Supply_business.Forms
{
    public partial class StatisticsForm : Form
    {
        public Contracts Contract;
        DBAccess dBAccess = new DBAccess();
        DataTable dt = new DataTable();
        public StatisticsForm()
        {
            Contract = new Contracts();
            InitializeComponent();
        }

        private void ChartPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawChart(e.Graphics);
        }

        private void LoadDataFromDatabase()
        {
            Contract.Goods.Clear();
            string query = "SELECT * FROM Contracts";
            dBAccess.readDatathroughAdapter(query, dt);

            foreach (DataRow row in dt.Rows)
            {
                Good good = new Good(row);
                Contract.Goods.Add(good);
            }
        }

        private void DrawChart(Graphics g)
        {

            LoadDataFromDatabase();
            string[] categories = { "Amazon", "eBay", "Shein" };
            int[] values = new int[categories.Length];

            foreach (var good in Contract.Goods)
            {
                for (int i = 0; i < categories.Length; i++)
                {
                    if (good.supplier.SupplierName.ToString() == categories[i])
                    {
                        values[i]++;
                        break;
                    }
                }
            }

            // Chart settings
            int chartWidth = chartPanel.Width;
            int chartHeight = chartPanel.Height;
            int barWidth = chartWidth / categories.Length;
            int maxBarHeight = chartHeight - 50;

            // Find the maximum value for scaling
            int maxValue = values.Length > 0 ? values[0] : 1;
            if (maxValue == 0)
            {
                maxValue = 1; // Prevent division by zero
            }
            foreach (var value in values)
            {
                if (value > maxValue) maxValue = value;
            }

            string color = "131, 77, 155";
            // Draw bars
            for (int i = 0; i < values.Length; i++)
            { 
                int barHeight = (values[i] * maxBarHeight) / maxValue;
                g.FillRectangle(Brushes.Purple, i * barWidth, chartHeight - barHeight, barWidth - 10, barHeight);
                g.DrawString(values[i].ToString(), this.Font, Brushes.Black, i * barWidth, chartHeight - barHeight - 20);
                g.DrawString(categories[i], this.Font, Brushes.Black, i * barWidth, chartHeight - 20);
            }

            // Draw axes
            g.DrawLine(Pens.Black, 0, chartHeight - 1, chartWidth, chartHeight - 1); // X-axis
            g.DrawLine(Pens.Black, 0, 0, 0, chartHeight); // Y-axis
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
