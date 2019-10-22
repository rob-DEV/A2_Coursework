namespace A2_Coursework.Forms
{
    partial class frmAddFoodMenuAttribute
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
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchLimter = new System.Windows.Forms.Timer(this.components);
            this.btnUpdateMenuAttrib = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(38, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Edit:";
            // 
            // txtStockSearch
            // 
            this.txtStockSearch.Location = new System.Drawing.Point(343, 32);
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.Size = new System.Drawing.Size(256, 22);
            this.txtStockSearch.TabIndex = 1;
            this.txtStockSearch.TextChanged += new System.EventHandler(this.txtStockSearch_TextChanged);
            // 
            // dataGridStock
            // 
            this.dataGridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(12, 58);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.Size = new System.Drawing.Size(587, 242);
            this.dataGridStock.TabIndex = 9;
            this.dataGridStock.SelectionChanged += new System.EventHandler(this.dataGridStock_SelectionChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(291, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search:";
            // 
            // searchLimter
            // 
            this.searchLimter.Interval = 500;
            this.searchLimter.Tick += new System.EventHandler(this.searchLimter_Tick);
            // 
            // btnUpdateMenuAttrib
            // 
            this.btnUpdateMenuAttrib.Location = new System.Drawing.Point(206, 306);
            this.btnUpdateMenuAttrib.Name = "btnUpdateMenuAttrib";
            this.btnUpdateMenuAttrib.Size = new System.Drawing.Size(87, 23);
            this.btnUpdateMenuAttrib.TabIndex = 11;
            this.btnUpdateMenuAttrib.Text = "Choose Item";
            this.btnUpdateMenuAttrib.UseVisualStyleBackColor = true;
            this.btnUpdateMenuAttrib.Click += new System.EventHandler(this.btnUpdateMenuAttrib_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose);
            // 
            // frmAddFoodMenuAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateMenuAttrib);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridStock);
            this.Controls.Add(this.txtStockSearch);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddFoodMenuAttribute";
            this.Text = "Edit Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtStockSearch;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Timer searchLimter;
        private System.Windows.Forms.Button btnUpdateMenuAttrib;
        private System.Windows.Forms.Button button1;
    }
}