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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deleteBtn1 = new System.Windows.Forms.Button();
            this.EditBtn1 = new System.Windows.Forms.Button();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.lsview1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TotalContracts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExportReport = new System.Windows.Forms.ToolStripButton();
            this.btnStatistics = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn1
            // 
            this.deleteBtn1.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn1.Location = new System.Drawing.Point(411, 36);
            this.deleteBtn1.Name = "deleteBtn1";
            this.deleteBtn1.Size = new System.Drawing.Size(109, 32);
            this.deleteBtn1.TabIndex = 0;
            this.deleteBtn1.Text = "Delete";
            this.deleteBtn1.UseVisualStyleBackColor = false;
            this.deleteBtn1.Click += new System.EventHandler(this.deleteBtn1_Click);
            // 
            // EditBtn1
            // 
            this.EditBtn1.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn1.Location = new System.Drawing.Point(268, 36);
            this.EditBtn1.Name = "EditBtn1";
            this.EditBtn1.Size = new System.Drawing.Size(109, 32);
            this.EditBtn1.TabIndex = 0;
            this.EditBtn1.Text = "Edit";
            this.EditBtn1.UseVisualStyleBackColor = false;
            this.EditBtn1.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn1
            // 
            this.AddBtn1.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn1.Location = new System.Drawing.Point(124, 36);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(109, 32);
            this.AddBtn1.TabIndex = 0;
            this.AddBtn1.Text = "Add";
            this.AddBtn1.UseVisualStyleBackColor = false;
            this.AddBtn1.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // lsview1
            // 
            this.lsview1.BackColor = System.Drawing.Color.White;
            this.lsview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsview1.HideSelection = false;
            this.lsview1.Location = new System.Drawing.Point(12, 91);
            this.lsview1.Name = "lsview1";
            this.lsview1.Size = new System.Drawing.Size(616, 225);
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Supplier";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Delivery Service";
            this.columnHeader6.Width = 182;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(90)))), ((int)(((byte)(191)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.infoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripMenuItem.Image")));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.infoToolStripMenuItem.Text = "Serialization";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(79)))), ((int)(((byte)(214)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalContracts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TotalContracts
            // 
            this.TotalContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(79)))), ((int)(((byte)(214)))));
            this.TotalContracts.LinkColor = System.Drawing.Color.White;
            this.TotalContracts.Name = "TotalContracts";
            this.TotalContracts.Size = new System.Drawing.Size(104, 20);
            this.TotalContracts.Text = "TotalContracts";
            this.TotalContracts.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(79)))), ((int)(((byte)(214)))));
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(90)))), ((int)(((byte)(191)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportReport,
            this.btnStatistics,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(640, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ExportReport
            // 
            this.ExportReport.Image = ((System.Drawing.Image)(resources.GetObject("ExportReport.Image")));
            this.ExportReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportReport.Name = "ExportReport";
            this.ExportReport.Size = new System.Drawing.Size(125, 24);
            this.ExportReport.Text = "Export Report";
            this.ExportReport.Click += new System.EventHandler(this.ExportReport_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(91, 24);
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContractToolStripMenuItem,
            this.editContractToolStripMenuItem,
            this.deleteContractToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 108);
            // 
            // addContractToolStripMenuItem
            // 
            this.addContractToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addContractToolStripMenuItem.Image")));
            this.addContractToolStripMenuItem.Name = "addContractToolStripMenuItem";
            this.addContractToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addContractToolStripMenuItem.Text = "Add contract";
            this.addContractToolStripMenuItem.Click += new System.EventHandler(this.addContractToolStripMenuItem_Click);
            // 
            // editContractToolStripMenuItem
            // 
            this.editContractToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editContractToolStripMenuItem.Image")));
            this.editContractToolStripMenuItem.Name = "editContractToolStripMenuItem";
            this.editContractToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.editContractToolStripMenuItem.Text = "Edit contract";
            this.editContractToolStripMenuItem.Click += new System.EventHandler(this.editContractToolStripMenuItem_Click);
            // 
            // deleteContractToolStripMenuItem
            // 
            this.deleteContractToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteContractToolStripMenuItem.Image")));
            this.deleteContractToolStripMenuItem.Name = "deleteContractToolStripMenuItem";
            this.deleteContractToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deleteContractToolStripMenuItem.Text = "Delete contract";
            this.deleteContractToolStripMenuItem.Click += new System.EventHandler(this.deleteContractToolStripMenuItem_Click_1);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.reloadToolStripMenuItem.Text = "Reload ";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.deleteBtn1);
            this.bunifuGradientPanel1.Controls.Add(this.EditBtn1);
            this.bunifuGradientPanel1.Controls.Add(this.lsview1);
            this.bunifuGradientPanel1.Controls.Add(this.AddBtn1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(77)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 55);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(640, 348);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(640, 429);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn1;
        private System.Windows.Forms.Button EditBtn1;
        private System.Windows.Forms.Button AddBtn1;
        private System.Windows.Forms.ListView lsview1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TotalContracts;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportReport;
        private System.Windows.Forms.ToolStripButton btnStatistics;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
    }
}