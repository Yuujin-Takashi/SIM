namespace SIM
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.grpRoleDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoleDesc = new System.Windows.Forms.TextBox();
            this.grpRoleDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRoleDetails
            // 
            this.grpRoleDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpRoleDetails.Controls.Add(this.label2);
            this.grpRoleDetails.Controls.Add(this.label3);
            this.grpRoleDetails.Controls.Add(this.txtRoleName);
            this.grpRoleDetails.Controls.Add(this.txtRoleID);
            this.grpRoleDetails.Controls.Add(this.label4);
            this.grpRoleDetails.Controls.Add(this.txtRoleDesc);
            this.grpRoleDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoleDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpRoleDetails.Location = new System.Drawing.Point(29, 25);
            this.grpRoleDetails.Name = "grpRoleDetails";
            this.grpRoleDetails.Size = new System.Drawing.Size(377, 230);
            this.grpRoleDetails.TabIndex = 1;
            this.grpRoleDetails.TabStop = false;
            this.grpRoleDetails.Text = "Role Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Role ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Role Description:";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(175, 89);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(168, 27);
            this.txtRoleName.TabIndex = 74;
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(175, 49);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(168, 27);
            this.txtRoleID.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Role Name:";
            // 
            // txtRoleDesc
            // 
            this.txtRoleDesc.Location = new System.Drawing.Point(175, 129);
            this.txtRoleDesc.Name = "txtRoleDesc";
            this.txtRoleDesc.Size = new System.Drawing.Size(168, 27);
            this.txtRoleDesc.TabIndex = 76;
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM.Properties.Resources.Blue_bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 527);
            this.Controls.Add(this.grpRoleDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserAccount";
            this.Text = "UserAccount";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.grpRoleDetails.ResumeLayout(false);
            this.grpRoleDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoleDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoleDesc;
    }
}