namespace Final_Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Appointments = new System.Windows.Forms.ToolStripMenuItem();
            this.Appointments_ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customers_ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users_ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpAppointmentsDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Appointments,
            this.customersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Logout,
            this.File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // File_Logout
            // 
            this.File_Logout.Name = "File_Logout";
            this.File_Logout.Size = new System.Drawing.Size(211, 30);
            this.File_Logout.Text = "Logout";
            this.File_Logout.Click += new System.EventHandler(this.File_Logout_Click);
            // 
            // File_Exit
            // 
            this.File_Exit.Name = "File_Exit";
            this.File_Exit.Size = new System.Drawing.Size(211, 30);
            this.File_Exit.Text = "Exit";
            this.File_Exit.Click += new System.EventHandler(this.File_Exit_Click);
            // 
            // Appointments
            // 
            this.Appointments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Appointments_ViewAll});
            this.Appointments.Name = "Appointments";
            this.Appointments.Size = new System.Drawing.Size(138, 29);
            this.Appointments.Text = "Appointments";
            // 
            // Appointments_ViewAll
            // 
            this.Appointments_ViewAll.Name = "Appointments_ViewAll";
            this.Appointments_ViewAll.Size = new System.Drawing.Size(159, 30);
            this.Appointments_ViewAll.Text = "View All";
            this.Appointments_ViewAll.Click += new System.EventHandler(this.Appointments_ViewAll_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Customers_ViewAll});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // Customers_ViewAll
            // 
            this.Customers_ViewAll.Name = "Customers_ViewAll";
            this.Customers_ViewAll.Size = new System.Drawing.Size(211, 30);
            this.Customers_ViewAll.Text = "View All";
            this.Customers_ViewAll.Click += new System.EventHandler(this.Customers_ViewAll_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Users_ViewAll});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // Users_ViewAll
            // 
            this.Users_ViewAll.Name = "Users_ViewAll";
            this.Users_ViewAll.Size = new System.Drawing.Size(211, 30);
            this.Users_ViewAll.Text = "View All";
            // 
            // dtpAppointmentsDate
            // 
            this.dtpAppointmentsDate.Location = new System.Drawing.Point(669, 129);
            this.dtpAppointmentsDate.Name = "dtpAppointmentsDate";
            this.dtpAppointmentsDate.Size = new System.Drawing.Size(200, 26);
            this.dtpAppointmentsDate.TabIndex = 2;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(12, 89);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.Size = new System.Drawing.Size(590, 378);
            this.dgvSchedule.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Schedule For the Day:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.dtpAppointmentsDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_Logout;
        private System.Windows.Forms.ToolStripMenuItem File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Appointments;
        private System.Windows.Forms.ToolStripMenuItem Appointments_ViewAll;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Users_ViewAll;
        private System.Windows.Forms.DateTimePicker dtpAppointmentsDate;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.ToolStripMenuItem Customers_ViewAll;
        private System.Windows.Forms.Label label1;
    }
}