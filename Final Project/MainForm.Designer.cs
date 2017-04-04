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
            this.Appointments_ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createContactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customers_ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users_ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Appointments_ViewAll,
            this.customersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 33);
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
            // Appointments_ViewAll
            // 
            this.Appointments_ViewAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem1});
            this.Appointments_ViewAll.Name = "Appointments_ViewAll";
            this.Appointments_ViewAll.Size = new System.Drawing.Size(138, 29);
            this.Appointments_ViewAll.Text = "Appointments";
            // 
            // viewAllToolStripMenuItem1
            // 
            this.viewAllToolStripMenuItem1.Name = "viewAllToolStripMenuItem1";
            this.viewAllToolStripMenuItem1.Size = new System.Drawing.Size(159, 30);
            this.viewAllToolStripMenuItem1.Text = "View All";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createContactListToolStripMenuItem,
            this.Customers_ViewAll});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // createContactListToolStripMenuItem
            // 
            this.createContactListToolStripMenuItem.Name = "createContactListToolStripMenuItem";
            this.createContactListToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.createContactListToolStripMenuItem.Text = "Create Contact List";
            // 
            // Customers_ViewAll
            // 
            this.Customers_ViewAll.Name = "Customers_ViewAll";
            this.Customers_ViewAll.Size = new System.Drawing.Size(244, 30);
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
            this.Users_ViewAll.Size = new System.Drawing.Size(159, 30);
            this.Users_ViewAll.Text = "View All";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(283, 270);
            this.dataGridView1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_Logout;
        private System.Windows.Forms.ToolStripMenuItem File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Appointments_ViewAll;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createContactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Users_ViewAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem Customers_ViewAll;
    }
}