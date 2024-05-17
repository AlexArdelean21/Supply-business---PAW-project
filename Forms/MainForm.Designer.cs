namespace Supply_business.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn1 = new System.Windows.Forms.Button();
            this.EditBtn1 = new System.Windows.Forms.Button();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lsview1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsview2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteBtn2 = new System.Windows.Forms.Button();
            this.EditBtn2 = new System.Windows.Forms.Button();
            this.AddBtn2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteBtn1);
            this.groupBox1.Controls.Add(this.EditBtn1);
            this.groupBox1.Controls.Add(this.AddBtn1);
            this.groupBox1.Location = new System.Drawing.Point(56, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goods Management";
            // 
            // deleteBtn1
            // 
            this.deleteBtn1.Location = new System.Drawing.Point(236, 35);
            this.deleteBtn1.Name = "deleteBtn1";
            this.deleteBtn1.Size = new System.Drawing.Size(109, 32);
            this.deleteBtn1.TabIndex = 0;
            this.deleteBtn1.Text = "Delete";
            this.deleteBtn1.UseVisualStyleBackColor = true;
            this.deleteBtn1.Click += new System.EventHandler(this.deleteBtn1_Click);
            // 
            // EditBtn1
            // 
            this.EditBtn1.Location = new System.Drawing.Point(121, 35);
            this.EditBtn1.Name = "EditBtn1";
            this.EditBtn1.Size = new System.Drawing.Size(109, 32);
            this.EditBtn1.TabIndex = 0;
            this.EditBtn1.Text = "Edit";
            this.EditBtn1.UseVisualStyleBackColor = true;
            this.EditBtn1.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn1
            // 
            this.AddBtn1.Location = new System.Drawing.Point(6, 35);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(109, 32);
            this.AddBtn1.TabIndex = 0;
            this.AddBtn1.Text = "Add";
            this.AddBtn1.UseVisualStyleBackColor = true;
            this.AddBtn1.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(478, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lsview1
            // 
            this.lsview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsview1.HideSelection = false;
            this.lsview1.Location = new System.Drawing.Point(12, 491);
            this.lsview1.Name = "lsview1";
            this.lsview1.Size = new System.Drawing.Size(451, 196);
            this.lsview1.TabIndex = 3;
            this.lsview1.UseCompatibleStateImageBehavior = false;
            this.lsview1.View = System.Windows.Forms.View.Details;
            this.lsview1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsview1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price/ Unit";
            this.columnHeader4.Width = 90;
            // 
            // lsview2
            // 
            this.lsview2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lsview2.HideSelection = false;
            this.lsview2.Location = new System.Drawing.Point(12, 259);
            this.lsview2.Name = "lsview2";
            this.lsview2.Size = new System.Drawing.Size(451, 210);
            this.lsview2.TabIndex = 5;
            this.lsview2.UseCompatibleStateImageBehavior = false;
            this.lsview2.View = System.Windows.Forms.View.Details;
            this.lsview2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsview2_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Supplier Name";
            this.columnHeader5.Width = 154;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Supplier email";
            this.columnHeader6.Width = 273;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteBtn2);
            this.groupBox2.Controls.Add(this.EditBtn2);
            this.groupBox2.Controls.Add(this.AddBtn2);
            this.groupBox2.Location = new System.Drawing.Point(56, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier Management";
            // 
            // deleteBtn2
            // 
            this.deleteBtn2.Location = new System.Drawing.Point(236, 35);
            this.deleteBtn2.Name = "deleteBtn2";
            this.deleteBtn2.Size = new System.Drawing.Size(109, 32);
            this.deleteBtn2.TabIndex = 0;
            this.deleteBtn2.Text = "Delete";
            this.deleteBtn2.UseVisualStyleBackColor = true;
            this.deleteBtn2.Click += new System.EventHandler(this.deleteBtn2_Click);
            // 
            // EditBtn2
            // 
            this.EditBtn2.Location = new System.Drawing.Point(121, 35);
            this.EditBtn2.Name = "EditBtn2";
            this.EditBtn2.Size = new System.Drawing.Size(109, 32);
            this.EditBtn2.TabIndex = 0;
            this.EditBtn2.Text = "Edit";
            this.EditBtn2.UseVisualStyleBackColor = true;
            this.EditBtn2.Click += new System.EventHandler(this.EditBtn2_Click);
            // 
            // AddBtn2
            // 
            this.AddBtn2.Location = new System.Drawing.Point(6, 35);
            this.AddBtn2.Name = "AddBtn2";
            this.AddBtn2.Size = new System.Drawing.Size(109, 32);
            this.AddBtn2.TabIndex = 0;
            this.AddBtn2.Text = "Add";
            this.AddBtn2.UseVisualStyleBackColor = true;
            this.AddBtn2.Click += new System.EventHandler(this.AddBtn2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(478, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lsview2);
            this.Controls.Add(this.lsview1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBtn1;
        private System.Windows.Forms.Button EditBtn1;
        private System.Windows.Forms.Button AddBtn1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView lsview1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lsview2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteBtn2;
        private System.Windows.Forms.Button EditBtn2;
        private System.Windows.Forms.Button AddBtn2;
    }
}