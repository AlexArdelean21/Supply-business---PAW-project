namespace Supply_business.Forms
{
    partial class AddEditContract
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Okbtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbGood = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BoxSupplier = new System.Windows.Forms.ComboBox();
            this.BoxDelivery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtGood_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(174, 73);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // Okbtn
            // 
            this.Okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Okbtn.Location = new System.Drawing.Point(12, 339);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(85, 33);
            this.Okbtn.TabIndex = 4;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(313, 339);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(174, 160);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 22);
            this.numQuantity.TabIndex = 3;
            // 
            // lbGood
            // 
            this.lbGood.AutoSize = true;
            this.lbGood.Location = new System.Drawing.Point(17, 37);
            this.lbGood.Name = "lbGood";
            this.lbGood.Size = new System.Drawing.Size(90, 16);
            this.lbGood.TabIndex = 6;
            this.lbGood.Text = "Product name";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(17, 79);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(75, 16);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Description";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(17, 123);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(84, 16);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price per unit";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(174, 117);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(200, 22);
            this.numPrice.TabIndex = 3;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(17, 166);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(55, 16);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // BoxSupplier
            // 
            this.BoxSupplier.FormattingEnabled = true;
            this.BoxSupplier.Location = new System.Drawing.Point(174, 203);
            this.BoxSupplier.Name = "BoxSupplier";
            this.BoxSupplier.Size = new System.Drawing.Size(200, 24);
            this.BoxSupplier.TabIndex = 7;
            // 
            // BoxDelivery
            // 
            this.BoxDelivery.FormattingEnabled = true;
            this.BoxDelivery.Location = new System.Drawing.Point(174, 246);
            this.BoxDelivery.Name = "BoxDelivery";
            this.BoxDelivery.Size = new System.Drawing.Size(200, 24);
            this.BoxDelivery.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delivery Service";
            // 
            // AddEditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(400, 384);
            this.Controls.Add(this.BoxDelivery);
            this.Controls.Add(this.BoxSupplier);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbGood);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Name = "AddEditContract";
            this.Text = "Add/ Edit Contract";
            this.Load += new System.EventHandler(this.AddEditContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lbGood;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ComboBox BoxDelivery;
        private System.Windows.Forms.ComboBox BoxSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}