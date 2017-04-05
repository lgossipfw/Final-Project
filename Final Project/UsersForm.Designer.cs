namespace Final_Project
{
    partial class UsersForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.btnSearchFor = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Username To:";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Location = new System.Drawing.Point(855, 229);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(100, 26);
            this.txtAppointmentID.TabIndex = 27;
            // 
            // btnSearchFor
            // 
            this.btnSearchFor.Location = new System.Drawing.Point(734, 135);
            this.btnSearchFor.Name = "btnSearchFor";
            this.btnSearchFor.Size = new System.Drawing.Size(221, 33);
            this.btnSearchFor.TabIndex = 26;
            this.btnSearchFor.Text = "Search For";
            this.btnSearchFor.UseVisualStyleBackColor = true;
            this.btnSearchFor.Click += new System.EventHandler(this.btnSearchFor_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(734, 290);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(221, 34);
            this.btnUpdateAppointment.TabIndex = 25;
            this.btnUpdateAppointment.Text = "Update Existing";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(734, 346);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(221, 36);
            this.btnDeleteAppointment.TabIndex = 24;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.Location = new System.Drawing.Point(734, 78);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(221, 30);
            this.btnAddNewAppointment.TabIndex = 23;
            this.btnAddNewAppointment.Text = "Add New";
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(635, 340);
            this.dataGridView1.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 33);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Home,
            this.File_Logout,
            this.File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // File_Home
            // 
            this.File_Home.Name = "File_Home";
            this.File_Home.Size = new System.Drawing.Size(154, 30);
            this.File_Home.Text = "Home";
            this.File_Home.Click += new System.EventHandler(this.File_Home_Click);
            // 
            // File_Logout
            // 
            this.File_Logout.Name = "File_Logout";
            this.File_Logout.Size = new System.Drawing.Size(154, 30);
            this.File_Logout.Text = "Logout";
            this.File_Logout.Click += new System.EventHandler(this.File_Logout_Click);
            // 
            // File_Exit
            // 
            this.File_Exit.Name = "File_Exit";
            this.File_Exit.Size = new System.Drawing.Size(154, 30);
            this.File_Exit.Text = "Exit";
            this.File_Exit.Click += new System.EventHandler(this.File_Exit_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 479);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.btnSearchFor);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Button btnSearchFor;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_Home;
        private System.Windows.Forms.ToolStripMenuItem File_Logout;
        private System.Windows.Forms.ToolStripMenuItem File_Exit;
    }
}