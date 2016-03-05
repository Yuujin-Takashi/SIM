namespace SIM
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.lstSupplier = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpSupplierDetails = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtSupplierFirstName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierLastName = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpSupplierDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSupplier
            // 
            this.lstSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSupplier.FullRowSelect = true;
            this.lstSupplier.GridLines = true;
            this.lstSupplier.Location = new System.Drawing.Point(451, 12);
            this.lstSupplier.Name = "lstSupplier";
            this.lstSupplier.Size = new System.Drawing.Size(937, 688);
            this.lstSupplier.TabIndex = 61;
            this.lstSupplier.UseCompatibleStateImageBehavior = false;
            this.lstSupplier.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SupplierID";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company Name";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last Name";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.Width = 142;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phone Number";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fax";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Email";
            this.columnHeader9.Width = 91;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Payment Method";
            this.columnHeader10.Width = 154;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Discount";
            this.columnHeader11.Width = 87;
            // 
            // grpSupplierDetails
            // 
            this.grpSupplierDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpSupplierDetails.Controls.Add(this.label5);
            this.grpSupplierDetails.Controls.Add(this.txtDiscount);
            this.grpSupplierDetails.Controls.Add(this.label4);
            this.grpSupplierDetails.Controls.Add(this.txtPaymentMethod);
            this.grpSupplierDetails.Controls.Add(this.label3);
            this.grpSupplierDetails.Controls.Add(this.txtEmail);
            this.grpSupplierDetails.Controls.Add(this.label2);
            this.grpSupplierDetails.Controls.Add(this.label23);
            this.grpSupplierDetails.Controls.Add(this.label1);
            this.grpSupplierDetails.Controls.Add(this.txtFax);
            this.grpSupplierDetails.Controls.Add(this.label29);
            this.grpSupplierDetails.Controls.Add(this.txtSupplierFirstName);
            this.grpSupplierDetails.Controls.Add(this.label28);
            this.grpSupplierDetails.Controls.Add(this.btnClearAll);
            this.grpSupplierDetails.Controls.Add(this.label27);
            this.grpSupplierDetails.Controls.Add(this.btnUpdateDetails);
            this.grpSupplierDetails.Controls.Add(this.label25);
            this.grpSupplierDetails.Controls.Add(this.btnDeleteSupplier);
            this.grpSupplierDetails.Controls.Add(this.label24);
            this.grpSupplierDetails.Controls.Add(this.btnAddSupplier);
            this.grpSupplierDetails.Controls.Add(this.txtCompanyName);
            this.grpSupplierDetails.Controls.Add(this.txtPhone);
            this.grpSupplierDetails.Controls.Add(this.txtSupplierLastName);
            this.grpSupplierDetails.Controls.Add(this.txtSupplierID);
            this.grpSupplierDetails.Controls.Add(this.txtSupplierTitle);
            this.grpSupplierDetails.Controls.Add(this.txtAddress);
            this.grpSupplierDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSupplierDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSupplierDetails.Location = new System.Drawing.Point(28, 28);
            this.grpSupplierDetails.Name = "grpSupplierDetails";
            this.grpSupplierDetails.Size = new System.Drawing.Size(377, 638);
            this.grpSupplierDetails.TabIndex = 60;
            this.grpSupplierDetails.TabStop = false;
            this.grpSupplierDetails.Text = "Supplier Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Discount:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(171, 482);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(168, 27);
            this.txtDiscount.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(37, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Payment Method:";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(171, 437);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(168, 27);
            this.txtPaymentMethod.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 394);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 27);
            this.txtEmail.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fax:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(35, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 16);
            this.label23.TabIndex = 45;
            this.label23.Text = "Supplier ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "First Name:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(171, 350);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(168, 27);
            this.txtFax.TabIndex = 59;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = new System.Drawing.Point(36, 94);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 16);
            this.label29.TabIndex = 40;
            this.label29.Text = "Company Name:";
            // 
            // txtSupplierFirstName
            // 
            this.txtSupplierFirstName.Location = new System.Drawing.Point(170, 131);
            this.txtSupplierFirstName.Name = "txtSupplierFirstName";
            this.txtSupplierFirstName.Size = new System.Drawing.Size(168, 27);
            this.txtSupplierFirstName.TabIndex = 56;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = new System.Drawing.Point(36, 184);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "Last Name:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearAll.Location = new System.Drawing.Point(209, 570);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(128, 27);
            this.btnClearAll.TabIndex = 55;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(35, 313);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 16);
            this.label27.TabIndex = 42;
            this.label27.Text = "Phone Number:";
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateDetails.Location = new System.Drawing.Point(38, 570);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(128, 27);
            this.btnUpdateDetails.TabIndex = 54;
            this.btnUpdateDetails.Text = "Update";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(36, 267);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 16);
            this.label25.TabIndex = 43;
            this.label25.Text = "Address:";
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(209, 537);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(128, 27);
            this.btnDeleteSupplier.TabIndex = 53;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(37, 234);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 16);
            this.label24.TabIndex = 44;
            this.label24.Text = "Title:";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSupplier.Location = new System.Drawing.Point(38, 537);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(128, 27);
            this.btnAddSupplier.TabIndex = 52;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(170, 88);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(168, 27);
            this.txtCompanyName.TabIndex = 46;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(169, 307);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 27);
            this.txtPhone.TabIndex = 51;
            // 
            // txtSupplierLastName
            // 
            this.txtSupplierLastName.Location = new System.Drawing.Point(171, 178);
            this.txtSupplierLastName.Name = "txtSupplierLastName";
            this.txtSupplierLastName.Size = new System.Drawing.Size(168, 27);
            this.txtSupplierLastName.TabIndex = 47;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(170, 50);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(168, 27);
            this.txtSupplierID.TabIndex = 50;
            // 
            // txtSupplierTitle
            // 
            this.txtSupplierTitle.Location = new System.Drawing.Point(170, 223);
            this.txtSupplierTitle.Name = "txtSupplierTitle";
            this.txtSupplierTitle.Size = new System.Drawing.Size(168, 27);
            this.txtSupplierTitle.TabIndex = 48;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(170, 265);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 27);
            this.txtAddress.TabIndex = 49;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM.Properties.Resources.Blue_bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1416, 712);
            this.Controls.Add(this.lstSupplier);
            this.Controls.Add(this.grpSupplierDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.grpSupplierDetails.ResumeLayout(false);
            this.grpSupplierDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSupplier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox grpSupplierDetails;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtSupplierFirstName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSupplierLastName;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtSupplierTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}