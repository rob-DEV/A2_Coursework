namespace A2_Coursework.Forms
{
    partial class frmMain
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnEditFoodMenus = new System.Windows.Forms.Button();
            this.dataGridLowStock = new System.Windows.Forms.DataGridView();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.btnEditBookings = new System.Windows.Forms.Button();
            this.lblStockHeader = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserHeader = new System.Windows.Forms.Label();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnEditSuppliers = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLowStock)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(11, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(333, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Events Unlimited Management System";
            // 
            // btnEditFoodMenus
            // 
            this.btnEditFoodMenus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFoodMenus.Location = new System.Drawing.Point(259, 71);
            this.btnEditFoodMenus.Name = "btnEditFoodMenus";
            this.btnEditFoodMenus.Size = new System.Drawing.Size(94, 71);
            this.btnEditFoodMenus.TabIndex = 2;
            this.btnEditFoodMenus.Text = "Menu Editor";
            this.btnEditFoodMenus.UseVisualStyleBackColor = true;
            this.btnEditFoodMenus.Click += new System.EventHandler(this.btnEditFoodMenus_Click);
            // 
            // dataGridLowStock
            // 
            this.dataGridLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLowStock.Location = new System.Drawing.Point(0, 342);
            this.dataGridLowStock.Name = "dataGridLowStock";
            this.dataGridLowStock.Size = new System.Drawing.Size(819, 229);
            this.dataGridLowStock.TabIndex = 2;
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomers.Location = new System.Drawing.Point(17, 71);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(94, 71);
            this.btnEditCustomers.TabIndex = 0;
            this.btnEditCustomers.Text = "Customers";
            this.btnEditCustomers.UseVisualStyleBackColor = true;
            this.btnEditCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEditBookings
            // 
            this.btnEditBookings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBookings.Location = new System.Drawing.Point(138, 71);
            this.btnEditBookings.Name = "btnEditBookings";
            this.btnEditBookings.Size = new System.Drawing.Size(94, 71);
            this.btnEditBookings.TabIndex = 1;
            this.btnEditBookings.Text = "Bookings";
            this.btnEditBookings.UseVisualStyleBackColor = true;
            this.btnEditBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // lblStockHeader
            // 
            this.lblStockHeader.AutoSize = true;
            this.lblStockHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHeader.Location = new System.Drawing.Point(10, 318);
            this.lblStockHeader.Name = "lblStockHeader";
            this.lblStockHeader.Size = new System.Drawing.Size(80, 21);
            this.lblStockHeader.TabIndex = 0;
            this.lblStockHeader.Text = "Low Stock";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(746, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 29);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserHeader
            // 
            this.lblUserHeader.AutoSize = true;
            this.lblUserHeader.Location = new System.Drawing.Point(638, 38);
            this.lblUserHeader.Name = "lblUserHeader";
            this.lblUserHeader.Size = new System.Drawing.Size(63, 13);
            this.lblUserHeader.TabIndex = 3;
            this.lblUserHeader.Text = "Hello, User";
            // 
            // btnEditStock
            // 
            this.btnEditStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStock.Location = new System.Drawing.Point(380, 71);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(94, 71);
            this.btnEditStock.TabIndex = 3;
            this.btnEditStock.Text = "Stock";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnEditSuppliers
            // 
            this.btnEditSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSuppliers.Location = new System.Drawing.Point(503, 71);
            this.btnEditSuppliers.Name = "btnEditSuppliers";
            this.btnEditSuppliers.Size = new System.Drawing.Size(94, 71);
            this.btnEditSuppliers.TabIndex = 4;
            this.btnEditSuppliers.Text = "Suppliers";
            this.btnEditSuppliers.UseVisualStyleBackColor = true;
            this.btnEditSuppliers.Click += new System.EventHandler(this.btnEditSuppliers_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(819, 24);
            this.menuMain.TabIndex = 6;
            this.menuMain.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 571);
            this.Controls.Add(this.btnEditSuppliers);
            this.Controls.Add(this.btnEditStock);
            this.Controls.Add(this.lblUserHeader);
            this.Controls.Add(this.dataGridLowStock);
            this.Controls.Add(this.btnEditBookings);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditCustomers);
            this.Controls.Add(this.btnEditFoodMenus);
            this.Controls.Add(this.lblStockHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Events Unlimted: Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLowStock)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnEditFoodMenus;
        private System.Windows.Forms.DataGridView dataGridLowStock;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.Button btnEditBookings;
        private System.Windows.Forms.Label lblStockHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserHeader;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnEditSuppliers;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}