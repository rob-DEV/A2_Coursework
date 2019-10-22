namespace A2_Coursework.Forms
{
    partial class frmStock
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtUStockName = new System.Windows.Forms.TextBox();
            this.lblUStockName = new System.Windows.Forms.Label();
            this.lblUCat = new System.Windows.Forms.Label();
            this.lblUQty = new System.Windows.Forms.Label();
            this.lblUReorder = new System.Windows.Forms.Label();
            this.txtUPrice = new System.Windows.Forms.TextBox();
            this.lblUPrice = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.searchLimterTimer = new System.Windows.Forms.Timer(this.components);
            this.comboUStockCategory = new System.Windows.Forms.ComboBox();
            this.numUStockQty = new System.Windows.Forms.NumericUpDown();
            this.numUReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.lblUSup = new System.Windows.Forms.Label();
            this.comboUSupplier = new System.Windows.Forms.ComboBox();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSup = new System.Windows.Forms.Label();
            this.numReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.numStockQty = new System.Windows.Forms.NumericUpDown();
            this.comboStockCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblReorder = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUStockQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(148, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Stock Management";
            // 
            // txtUStockName
            // 
            this.txtUStockName.Location = new System.Drawing.Point(585, 68);
            this.txtUStockName.Name = "txtUStockName";
            this.txtUStockName.Size = new System.Drawing.Size(120, 20);
            this.txtUStockName.TabIndex = 10;
            // 
            // lblUStockName
            // 
            this.lblUStockName.AutoSize = true;
            this.lblUStockName.Location = new System.Drawing.Point(503, 71);
            this.lblUStockName.Name = "lblUStockName";
            this.lblUStockName.Size = new System.Drawing.Size(69, 13);
            this.lblUStockName.TabIndex = 11;
            this.lblUStockName.Text = "Stock Name:";
            // 
            // lblUCat
            // 
            this.lblUCat.AutoSize = true;
            this.lblUCat.Location = new System.Drawing.Point(503, 98);
            this.lblUCat.Name = "lblUCat";
            this.lblUCat.Size = new System.Drawing.Size(52, 13);
            this.lblUCat.TabIndex = 15;
            this.lblUCat.Text = "Category:";
            // 
            // lblUQty
            // 
            this.lblUQty.AutoSize = true;
            this.lblUQty.Location = new System.Drawing.Point(503, 125);
            this.lblUQty.Name = "lblUQty";
            this.lblUQty.Size = new System.Drawing.Size(23, 13);
            this.lblUQty.TabIndex = 15;
            this.lblUQty.Text = "Qty";
            // 
            // lblUReorder
            // 
            this.lblUReorder.AutoSize = true;
            this.lblUReorder.Location = new System.Drawing.Point(503, 149);
            this.lblUReorder.Name = "lblUReorder";
            this.lblUReorder.Size = new System.Drawing.Size(77, 13);
            this.lblUReorder.TabIndex = 15;
            this.lblUReorder.Text = "Reorder Level:";
            // 
            // txtUPrice
            // 
            this.txtUPrice.Location = new System.Drawing.Point(585, 172);
            this.txtUPrice.Name = "txtUPrice";
            this.txtUPrice.Size = new System.Drawing.Size(120, 20);
            this.txtUPrice.TabIndex = 14;
            // 
            // lblUPrice
            // 
            this.lblUPrice.AutoSize = true;
            this.lblUPrice.Location = new System.Drawing.Point(503, 175);
            this.lblUPrice.Name = "lblUPrice";
            this.lblUPrice.Size = new System.Drawing.Size(79, 13);
            this.lblUPrice.TabIndex = 15;
            this.lblUPrice.Text = "Price:             £";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(513, 265);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Search:";
            // 
            // dataGridStock
            // 
            this.dataGridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(3, 286);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.Size = new System.Drawing.Size(812, 284);
            this.dataGridStock.TabIndex = 22;
            this.dataGridStock.SelectionChanged += new System.EventHandler(this.dataGridStock_SelectionChanged);
            // 
            // txtStockSearch
            // 
            this.txtStockSearch.Location = new System.Drawing.Point(563, 262);
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.Size = new System.Drawing.Size(252, 20);
            this.txtStockSearch.TabIndex = 21;
            this.txtStockSearch.TextChanged += new System.EventHandler(this.txtStockSearch_TextChanged);
            // 
            // searchLimterTimer
            // 
            this.searchLimterTimer.Interval = 500;
            // 
            // comboUStockCategory
            // 
            this.comboUStockCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUStockCategory.FormattingEnabled = true;
            this.comboUStockCategory.Items.AddRange(new object[] {
            "VEG",
            "MEAT",
            "DRINK",
            "CUTLERY"});
            this.comboUStockCategory.Location = new System.Drawing.Point(585, 94);
            this.comboUStockCategory.Name = "comboUStockCategory";
            this.comboUStockCategory.Size = new System.Drawing.Size(120, 21);
            this.comboUStockCategory.TabIndex = 24;
            // 
            // numUStockQty
            // 
            this.numUStockQty.Location = new System.Drawing.Point(586, 120);
            this.numUStockQty.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numUStockQty.Name = "numUStockQty";
            this.numUStockQty.Size = new System.Drawing.Size(120, 20);
            this.numUStockQty.TabIndex = 25;
            // 
            // numUReorderLevel
            // 
            this.numUReorderLevel.Location = new System.Drawing.Point(586, 147);
            this.numUReorderLevel.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numUReorderLevel.Name = "numUReorderLevel";
            this.numUReorderLevel.Size = new System.Drawing.Size(120, 20);
            this.numUReorderLevel.TabIndex = 26;
            // 
            // lblUSup
            // 
            this.lblUSup.AutoSize = true;
            this.lblUSup.Location = new System.Drawing.Point(503, 201);
            this.lblUSup.Name = "lblUSup";
            this.lblUSup.Size = new System.Drawing.Size(48, 13);
            this.lblUSup.TabIndex = 28;
            this.lblUSup.Text = "Supplier:";
            // 
            // comboUSupplier
            // 
            this.comboUSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUSupplier.FormattingEnabled = true;
            this.comboUSupplier.Location = new System.Drawing.Point(585, 199);
            this.comboUSupplier.Name = "comboUSupplier";
            this.comboUSupplier.Size = new System.Drawing.Size(120, 21);
            this.comboUSupplier.TabIndex = 29;
            // 
            // comboSupplier
            // 
            this.comboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.Location = new System.Drawing.Point(195, 199);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(120, 21);
            this.comboSupplier.TabIndex = 41;
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Location = new System.Drawing.Point(113, 201);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(48, 13);
            this.lblSup.TabIndex = 40;
            this.lblSup.Text = "Supplier:";
            // 
            // numReorderLevel
            // 
            this.numReorderLevel.Location = new System.Drawing.Point(195, 147);
            this.numReorderLevel.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numReorderLevel.Name = "numReorderLevel";
            this.numReorderLevel.Size = new System.Drawing.Size(120, 20);
            this.numReorderLevel.TabIndex = 39;
            // 
            // numStockQty
            // 
            this.numStockQty.Location = new System.Drawing.Point(195, 120);
            this.numStockQty.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numStockQty.Name = "numStockQty";
            this.numStockQty.Size = new System.Drawing.Size(120, 20);
            this.numStockQty.TabIndex = 38;
            // 
            // comboStockCategory
            // 
            this.comboStockCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStockCategory.FormattingEnabled = true;
            this.comboStockCategory.Items.AddRange(new object[] {
            "VEG",
            "MEAT",
            "DRINK",
            "CUTLERY"});
            this.comboStockCategory.Location = new System.Drawing.Point(195, 94);
            this.comboStockCategory.Name = "comboStockCategory";
            this.comboStockCategory.Size = new System.Drawing.Size(120, 21);
            this.comboStockCategory.TabIndex = 37;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(113, 175);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 13);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price:             £";
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(113, 149);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(77, 13);
            this.lblReorder.TabIndex = 34;
            this.lblReorder.Text = "Reorder Level:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(113, 124);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 35;
            this.lblQty.Text = "Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(195, 172);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 32;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(113, 98);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 36;
            this.lblCat.Text = "Category:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(113, 71);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(69, 13);
            this.lblStock.TabIndex = 31;
            this.lblStock.Text = "Stock Name:";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(195, 68);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(120, 20);
            this.txtStockName.TabIndex = 30;
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(112, 44);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(98, 16);
            this.lblAddStock.TabIndex = 42;
            this.lblAddStock.Text = "Add Stock Item";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(503, 44);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(118, 16);
            this.lblUpdateStock.TabIndex = 43;
            this.lblUpdateStock.Text = "Update Stock Item";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(548, 227);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateStock.TabIndex = 44;
            this.btnUpdateStock.Text = "Update Stock Item";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(169, 227);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(105, 23);
            this.btnAddStock.TabIndex = 45;
            this.btnAddStock.Text = "Add Stock Item";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 571);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.lblUpdateStock);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.lblSup);
            this.Controls.Add(this.numReorderLevel);
            this.Controls.Add(this.numStockQty);
            this.Controls.Add(this.comboStockCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.comboUSupplier);
            this.Controls.Add(this.lblUSup);
            this.Controls.Add(this.numUReorderLevel);
            this.Controls.Add(this.numUStockQty);
            this.Controls.Add(this.comboUStockCategory);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridStock);
            this.Controls.Add(this.txtStockSearch);
            this.Controls.Add(this.lblUPrice);
            this.Controls.Add(this.lblUReorder);
            this.Controls.Add(this.lblUQty);
            this.Controls.Add(this.txtUPrice);
            this.Controls.Add(this.lblUCat);
            this.Controls.Add(this.lblUStockName);
            this.Controls.Add(this.txtUStockName);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStock";
            this.Text = "Events Unlimited: Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUStockQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtUStockName;
        private System.Windows.Forms.Label lblUStockName;
        private System.Windows.Forms.Label lblUCat;
        private System.Windows.Forms.Label lblUQty;
        private System.Windows.Forms.Label lblUReorder;
        private System.Windows.Forms.TextBox txtUPrice;
        private System.Windows.Forms.Label lblUPrice;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.TextBox txtStockSearch;
        private System.Windows.Forms.Timer searchLimterTimer;
        private System.Windows.Forms.ComboBox comboUStockCategory;
        private System.Windows.Forms.NumericUpDown numUStockQty;
        private System.Windows.Forms.NumericUpDown numUReorderLevel;
        private System.Windows.Forms.Label lblUSup;
        private System.Windows.Forms.ComboBox comboUSupplier;
        private System.Windows.Forms.ComboBox comboSupplier;
        private System.Windows.Forms.Label lblSup;
        private System.Windows.Forms.NumericUpDown numReorderLevel;
        private System.Windows.Forms.NumericUpDown numStockQty;
        private System.Windows.Forms.ComboBox comboStockCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnAddStock;
    }
}