namespace A2_Coursework.Forms
{
    partial class frmFoodMenus
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
            this.dataGridFoodMenus = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.lblMenuId = new System.Windows.Forms.Label();
            this.lblMeat = new System.Windows.Forms.Label();
            this.txtMenuMeat = new System.Windows.Forms.TextBox();
            this.lblMenuVeg1 = new System.Windows.Forms.Label();
            this.txtMenuVeg1 = new System.Windows.Forms.TextBox();
            this.lblMenuVeg2 = new System.Windows.Forms.Label();
            this.txtMenuVeg2 = new System.Windows.Forms.TextBox();
            this.txtMenuDrink = new System.Windows.Forms.TextBox();
            this.lblMenuDrink = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.lblEditHeader = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.lblNPrice = new System.Windows.Forms.Label();
            this.txtNMenuPrice = new System.Windows.Forms.TextBox();
            this.lblNDrink = new System.Windows.Forms.Label();
            this.txtNMenuDrink = new System.Windows.Forms.TextBox();
            this.lblNVeg2 = new System.Windows.Forms.Label();
            this.txtNMenuVeg2 = new System.Windows.Forms.TextBox();
            this.lblNVeg1 = new System.Windows.Forms.Label();
            this.txtNMenuVeg1 = new System.Windows.Forms.TextBox();
            this.lblNMeat = new System.Windows.Forms.Label();
            this.txtNMenuMeat = new System.Windows.Forms.TextBox();
            this.lblInfo2Header = new System.Windows.Forms.Label();
            this.lblCreateHeader = new System.Windows.Forms.Label();
            this.lblInfo1Header = new System.Windows.Forms.Label();
            this.btnPopReport = new System.Windows.Forms.Button();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFoodMenus
            // 
            this.dataGridFoodMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFoodMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFoodMenus.Location = new System.Drawing.Point(12, 32);
            this.dataGridFoodMenus.Name = "dataGridFoodMenus";
            this.dataGridFoodMenus.Size = new System.Drawing.Size(795, 262);
            this.dataGridFoodMenus.TabIndex = 8;
            this.dataGridFoodMenus.SelectionChanged += new System.EventHandler(this.dataGridFoodMenus_SelectionChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(8, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(120, 21);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Catering Menus";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(140, 351);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.ReadOnly = true;
            this.txtMenuId.Size = new System.Drawing.Size(32, 22);
            this.txtMenuId.TabIndex = 0;
            // 
            // lblMenuId
            // 
            this.lblMenuId.AutoSize = true;
            this.lblMenuId.Location = new System.Drawing.Point(85, 355);
            this.lblMenuId.Name = "lblMenuId";
            this.lblMenuId.Size = new System.Drawing.Size(54, 13);
            this.lblMenuId.TabIndex = 10;
            this.lblMenuId.Text = "Menu ID:";
            // 
            // lblMeat
            // 
            this.lblMeat.AutoSize = true;
            this.lblMeat.Location = new System.Drawing.Point(85, 380);
            this.lblMeat.Name = "lblMeat";
            this.lblMeat.Size = new System.Drawing.Size(36, 13);
            this.lblMeat.TabIndex = 12;
            this.lblMeat.Text = "Meat:";
            // 
            // txtMenuMeat
            // 
            this.txtMenuMeat.Location = new System.Drawing.Point(125, 377);
            this.txtMenuMeat.Name = "txtMenuMeat";
            this.txtMenuMeat.ReadOnly = true;
            this.txtMenuMeat.Size = new System.Drawing.Size(123, 22);
            this.txtMenuMeat.TabIndex = 1;
            this.txtMenuMeat.Tag = "meat";
            this.txtMenuMeat.Click += new System.EventHandler(this.editFoodMenuItem);
            // 
            // lblMenuVeg1
            // 
            this.lblMenuVeg1.AutoSize = true;
            this.lblMenuVeg1.Location = new System.Drawing.Point(85, 406);
            this.lblMenuVeg1.Name = "lblMenuVeg1";
            this.lblMenuVeg1.Size = new System.Drawing.Size(38, 13);
            this.lblMenuVeg1.TabIndex = 14;
            this.lblMenuVeg1.Text = "Veg 1:";
            // 
            // txtMenuVeg1
            // 
            this.txtMenuVeg1.Location = new System.Drawing.Point(125, 403);
            this.txtMenuVeg1.Name = "txtMenuVeg1";
            this.txtMenuVeg1.ReadOnly = true;
            this.txtMenuVeg1.Size = new System.Drawing.Size(123, 22);
            this.txtMenuVeg1.TabIndex = 2;
            this.txtMenuVeg1.Tag = "veg_1";
            this.txtMenuVeg1.Click += new System.EventHandler(this.editFoodMenuItem);
            // 
            // lblMenuVeg2
            // 
            this.lblMenuVeg2.AutoSize = true;
            this.lblMenuVeg2.Location = new System.Drawing.Point(85, 432);
            this.lblMenuVeg2.Name = "lblMenuVeg2";
            this.lblMenuVeg2.Size = new System.Drawing.Size(38, 13);
            this.lblMenuVeg2.TabIndex = 16;
            this.lblMenuVeg2.Text = "Veg 2:";
            // 
            // txtMenuVeg2
            // 
            this.txtMenuVeg2.Location = new System.Drawing.Point(125, 429);
            this.txtMenuVeg2.Name = "txtMenuVeg2";
            this.txtMenuVeg2.ReadOnly = true;
            this.txtMenuVeg2.Size = new System.Drawing.Size(123, 22);
            this.txtMenuVeg2.TabIndex = 3;
            this.txtMenuVeg2.Tag = "veg_2";
            this.txtMenuVeg2.Click += new System.EventHandler(this.editFoodMenuItem);
            // 
            // txtMenuDrink
            // 
            this.txtMenuDrink.Location = new System.Drawing.Point(125, 455);
            this.txtMenuDrink.Name = "txtMenuDrink";
            this.txtMenuDrink.ReadOnly = true;
            this.txtMenuDrink.Size = new System.Drawing.Size(123, 22);
            this.txtMenuDrink.TabIndex = 4;
            this.txtMenuDrink.Tag = "drink";
            this.txtMenuDrink.Click += new System.EventHandler(this.editFoodMenuItem);
            // 
            // lblMenuDrink
            // 
            this.lblMenuDrink.AutoSize = true;
            this.lblMenuDrink.Location = new System.Drawing.Point(85, 458);
            this.lblMenuDrink.Name = "lblMenuDrink";
            this.lblMenuDrink.Size = new System.Drawing.Size(38, 13);
            this.lblMenuDrink.TabIndex = 16;
            this.lblMenuDrink.Text = "Drink:";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Location = new System.Drawing.Point(85, 484);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(43, 13);
            this.lblMenuPrice.TabIndex = 18;
            this.lblMenuPrice.Text = "Price: £";
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(164, 481);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(84, 22);
            this.txtMenuPrice.TabIndex = 5;
            this.txtMenuPrice.Tag = "";
            // 
            // lblEditHeader
            // 
            this.lblEditHeader.AutoSize = true;
            this.lblEditHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEditHeader.Location = new System.Drawing.Point(12, 302);
            this.lblEditHeader.Name = "lblEditHeader";
            this.lblEditHeader.Size = new System.Drawing.Size(142, 21);
            this.lblEditHeader.TabIndex = 10;
            this.lblEditHeader.Text = "Edit Selected Menu";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(125, 507);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(123, 23);
            this.btnUpdatePrice.TabIndex = 6;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(582, 514);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(74, 23);
            this.btnAddMenu.TabIndex = 12;
            this.btnAddMenu.Text = "Add Menu";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // lblNPrice
            // 
            this.lblNPrice.AutoSize = true;
            this.lblNPrice.Location = new System.Drawing.Point(530, 488);
            this.lblNPrice.Name = "lblNPrice";
            this.lblNPrice.Size = new System.Drawing.Size(67, 13);
            this.lblNPrice.TabIndex = 32;
            this.lblNPrice.Text = "Sale Price: £";
            // 
            // txtNMenuPrice
            // 
            this.txtNMenuPrice.Location = new System.Drawing.Point(615, 485);
            this.txtNMenuPrice.Name = "txtNMenuPrice";
            this.txtNMenuPrice.Size = new System.Drawing.Size(84, 22);
            this.txtNMenuPrice.TabIndex = 11;
            this.txtNMenuPrice.Tag = "";
            // 
            // lblNDrink
            // 
            this.lblNDrink.AutoSize = true;
            this.lblNDrink.Location = new System.Drawing.Point(532, 432);
            this.lblNDrink.Name = "lblNDrink";
            this.lblNDrink.Size = new System.Drawing.Size(38, 13);
            this.lblNDrink.TabIndex = 29;
            this.lblNDrink.Text = "Drink:";
            // 
            // txtNMenuDrink
            // 
            this.txtNMenuDrink.Location = new System.Drawing.Point(576, 429);
            this.txtNMenuDrink.Name = "txtNMenuDrink";
            this.txtNMenuDrink.ReadOnly = true;
            this.txtNMenuDrink.Size = new System.Drawing.Size(123, 22);
            this.txtNMenuDrink.TabIndex = 10;
            this.txtNMenuDrink.Tag = "drink";
            this.txtNMenuDrink.Click += new System.EventHandler(this.pickFoodMenuItem);
            // 
            // lblNVeg2
            // 
            this.lblNVeg2.AutoSize = true;
            this.lblNVeg2.Location = new System.Drawing.Point(532, 406);
            this.lblNVeg2.Name = "lblNVeg2";
            this.lblNVeg2.Size = new System.Drawing.Size(38, 13);
            this.lblNVeg2.TabIndex = 30;
            this.lblNVeg2.Text = "Veg 2:";
            // 
            // txtNMenuVeg2
            // 
            this.txtNMenuVeg2.Location = new System.Drawing.Point(576, 403);
            this.txtNMenuVeg2.Name = "txtNMenuVeg2";
            this.txtNMenuVeg2.ReadOnly = true;
            this.txtNMenuVeg2.Size = new System.Drawing.Size(123, 22);
            this.txtNMenuVeg2.TabIndex = 9;
            this.txtNMenuVeg2.Tag = "veg_2";
            this.txtNMenuVeg2.Click += new System.EventHandler(this.pickFoodMenuItem);
            // 
            // lblNVeg1
            // 
            this.lblNVeg1.AutoSize = true;
            this.lblNVeg1.Location = new System.Drawing.Point(532, 380);
            this.lblNVeg1.Name = "lblNVeg1";
            this.lblNVeg1.Size = new System.Drawing.Size(38, 13);
            this.lblNVeg1.TabIndex = 26;
            this.lblNVeg1.Text = "Veg 1:";
            // 
            // txtNMenuVeg1
            // 
            this.txtNMenuVeg1.Location = new System.Drawing.Point(576, 379);
            this.txtNMenuVeg1.Name = "txtNMenuVeg1";
            this.txtNMenuVeg1.ReadOnly = true;
            this.txtNMenuVeg1.Size = new System.Drawing.Size(123, 22);
            this.txtNMenuVeg1.TabIndex = 8;
            this.txtNMenuVeg1.Tag = "veg_1";
            this.txtNMenuVeg1.Click += new System.EventHandler(this.pickFoodMenuItem);
            // 
            // lblNMeat
            // 
            this.lblNMeat.AutoSize = true;
            this.lblNMeat.Location = new System.Drawing.Point(532, 354);
            this.lblNMeat.Name = "lblNMeat";
            this.lblNMeat.Size = new System.Drawing.Size(36, 13);
            this.lblNMeat.TabIndex = 24;
            this.lblNMeat.Text = "Meat:";
            // 
            // txtNMenuMeat
            // 
            this.txtNMenuMeat.Location = new System.Drawing.Point(576, 354);
            this.txtNMenuMeat.Name = "txtNMenuMeat";
            this.txtNMenuMeat.ReadOnly = true;
            this.txtNMenuMeat.Size = new System.Drawing.Size(123, 22);
            this.txtNMenuMeat.TabIndex = 7;
            this.txtNMenuMeat.Tag = "meat";
            this.txtNMenuMeat.Click += new System.EventHandler(this.pickFoodMenuItem);
            // 
            // lblInfo2Header
            // 
            this.lblInfo2Header.AutoSize = true;
            this.lblInfo2Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo2Header.Location = new System.Drawing.Point(463, 325);
            this.lblInfo2Header.Name = "lblInfo2Header";
            this.lblInfo2Header.Size = new System.Drawing.Size(326, 20);
            this.lblInfo2Header.TabIndex = 22;
            this.lblInfo2Header.Text = "Click on a field to assign an item from the stock.";
            // 
            // lblCreateHeader
            // 
            this.lblCreateHeader.AutoSize = true;
            this.lblCreateHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateHeader.Location = new System.Drawing.Point(459, 302);
            this.lblCreateHeader.Name = "lblCreateHeader";
            this.lblCreateHeader.Size = new System.Drawing.Size(147, 21);
            this.lblCreateHeader.TabIndex = 21;
            this.lblCreateHeader.Text = "Create a New Menu";
            // 
            // lblInfo1Header
            // 
            this.lblInfo1Header.AutoSize = true;
            this.lblInfo1Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo1Header.Location = new System.Drawing.Point(13, 325);
            this.lblInfo1Header.Name = "lblInfo1Header";
            this.lblInfo1Header.Size = new System.Drawing.Size(326, 20);
            this.lblInfo1Header.TabIndex = 35;
            this.lblInfo1Header.Text = "Click on a field to assign an item from the stock.";
            // 
            // btnPopReport
            // 
            this.btnPopReport.Location = new System.Drawing.Point(535, 543);
            this.btnPopReport.Name = "btnPopReport";
            this.btnPopReport.Size = new System.Drawing.Size(164, 23);
            this.btnPopReport.TabIndex = 36;
            this.btnPopReport.Text = "View Menu Popularity";
            this.btnPopReport.UseVisualStyleBackColor = true;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(530, 464);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(69, 13);
            this.lblCostPrice.TabIndex = 37;
            this.lblCostPrice.Text = "Cost Price: £";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(615, 458);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.ReadOnly = true;
            this.txtCostPrice.Size = new System.Drawing.Size(83, 22);
            this.txtCostPrice.TabIndex = 38;
            this.txtCostPrice.Tag = "";
            // 
            // frmFoodMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 571);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.btnPopReport);
            this.Controls.Add(this.lblInfo1Header);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.lblNPrice);
            this.Controls.Add(this.txtNMenuPrice);
            this.Controls.Add(this.lblNDrink);
            this.Controls.Add(this.txtNMenuDrink);
            this.Controls.Add(this.lblNVeg2);
            this.Controls.Add(this.txtNMenuVeg2);
            this.Controls.Add(this.lblNVeg1);
            this.Controls.Add(this.txtNMenuVeg1);
            this.Controls.Add(this.lblNMeat);
            this.Controls.Add(this.txtNMenuMeat);
            this.Controls.Add(this.lblInfo2Header);
            this.Controls.Add(this.lblCreateHeader);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.lblMenuPrice);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.lblMenuDrink);
            this.Controls.Add(this.txtMenuDrink);
            this.Controls.Add(this.lblMenuVeg2);
            this.Controls.Add(this.txtMenuVeg2);
            this.Controls.Add(this.lblMenuVeg1);
            this.Controls.Add(this.txtMenuVeg1);
            this.Controls.Add(this.lblMeat);
            this.Controls.Add(this.txtMenuMeat);
            this.Controls.Add(this.lblEditHeader);
            this.Controls.Add(this.lblMenuId);
            this.Controls.Add(this.txtMenuId);
            this.Controls.Add(this.dataGridFoodMenus);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFoodMenus";
            this.Text = "Events Unlimited: Catering Menus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodMenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFoodMenus;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.Label lblMenuId;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.TextBox txtMenuMeat;
        private System.Windows.Forms.Label lblMenuVeg1;
        private System.Windows.Forms.TextBox txtMenuVeg1;
        private System.Windows.Forms.Label lblMenuVeg2;
        private System.Windows.Forms.TextBox txtMenuVeg2;
        private System.Windows.Forms.TextBox txtMenuDrink;
        private System.Windows.Forms.Label lblMenuDrink;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.Label lblEditHeader;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Label lblNPrice;
        private System.Windows.Forms.TextBox txtNMenuPrice;
        private System.Windows.Forms.Label lblNDrink;
        private System.Windows.Forms.TextBox txtNMenuDrink;
        private System.Windows.Forms.Label lblNVeg2;
        private System.Windows.Forms.TextBox txtNMenuVeg2;
        private System.Windows.Forms.Label lblNVeg1;
        private System.Windows.Forms.TextBox txtNMenuVeg1;
        private System.Windows.Forms.Label lblNMeat;
        private System.Windows.Forms.TextBox txtNMenuMeat;
        private System.Windows.Forms.Label lblInfo2Header;
        private System.Windows.Forms.Label lblCreateHeader;
        private System.Windows.Forms.Label lblInfo1Header;
        private System.Windows.Forms.Button btnPopReport;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.TextBox txtCostPrice;
    }
}