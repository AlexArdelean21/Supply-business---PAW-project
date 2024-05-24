using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_business.Forms
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // reveres this function to hide the sidebar


        bool sidebarExtend = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExtend)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 42)
                {
                    sidebarTransition.Stop();
                    sidebarExtend = false;
                    this.Refresh();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 180)
                {
                    sidebarTransition.Stop();
                    sidebarExtend = true;
                    this.Refresh();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/AlexArdelean21/Supply-business---PAW-project",
                UseShellExecute = true
            });
        }

        private void linkedinButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/alexardelean21/",
                UseShellExecute = true
            });
        }

        private void InstagramButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.instagram.com/alex_ardelean21/?next=%2F",
                UseShellExecute = true
            });
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Info_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Info_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Info_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
