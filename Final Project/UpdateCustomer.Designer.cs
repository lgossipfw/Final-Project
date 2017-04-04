namespace Final_Project
{


    partial class UpdateCustomerForm
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.MaskedTextBox();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(566, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 26);
            this.txtEmail.TabIndex = 37;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(566, 145);
            this.txtZipCode.Mask = "00000";
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(53, 26);
            this.txtZipCode.TabIndex = 36;
            this.txtZipCode.ValidatingType = typeof(int);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(567, 25);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(240, 26);
            this.txtCity.TabIndex = 35;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(566, 87);
            this.txtState.Mask = "AA";
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(36, 26);
            this.txtState.TabIndex = 34;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(124, 145);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(124, 26);
            this.txtPhoneNumber.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 199);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 26);
            this.txtAddress.TabIndex = 32;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(241, 26);
            this.txtLastName.TabIndex = 31;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(123, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 26);
            this.txtFirstName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Showing Results for Customer With ID:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(959, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(547, 357);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(117, 39);
            this.txtUpdate.TabIndex = 41;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(327, 357);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(115, 39);
            this.txtCancel.TabIndex = 42;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.txtFirstName);
            this.grpInfo.Controls.Add(this.txtLastName);
            this.grpInfo.Controls.Add(this.txtAddress);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.txtPhoneNumber);
            this.grpInfo.Controls.Add(this.txtZipCode);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.txtCity);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.txtState);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Location = new System.Drawing.Point(12, 85);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(935, 249);
            this.grpInfo.TabIndex = 44;
            this.grpInfo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 33);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(449, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 46;
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 430);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.UpdateCustomerForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox txtState;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblID;
    }
}