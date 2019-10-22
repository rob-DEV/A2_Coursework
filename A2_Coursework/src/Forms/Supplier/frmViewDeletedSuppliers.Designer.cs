namespace A2_Coursework.Forms
{
    partial class frmViewDeletedSuppliers
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
            this.dataGridSuppliers = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUndeleted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSuppliers
            // 
            this.dataGridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.Location = new System.Drawing.Point(0, 32);
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.Size = new System.Drawing.Size(753, 280);
            this.dataGridSuppliers.TabIndex = 8;
            this.dataGridSuppliers.SelectionChanged += new System.EventHandler(this.dataGridSuppliers_SelectionChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(135, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Deleted Suppliers";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(94, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUndeleted
            // 
            this.btnUndeleted.Location = new System.Drawing.Point(12, 318);
            this.btnUndeleted.Name = "btnUndeleted";
            this.btnUndeleted.Size = new System.Drawing.Size(75, 23);
            this.btnUndeleted.TabIndex = 9;
            this.btnUndeleted.Text = "Undelete";
            this.btnUndeleted.UseVisualStyleBackColor = true;
            this.btnUndeleted.Click += new System.EventHandler(this.btnUndeleted_Click);
            // 
            // frmViewDeletedSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 350);
            this.Controls.Add(this.btnUndeleted);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridSuppliers);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmViewDeletedSuppliers";
            this.Text = "Events Unlimited: Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSuppliers;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUndeleted;
    }
}