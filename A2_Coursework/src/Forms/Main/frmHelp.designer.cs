namespace A2_Coursework.Forms
{
    partial class frmHelp
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
            this.txtAboutBox = new System.Windows.Forms.TextBox();
            this.btnCloseHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAboutBox
            // 
            this.txtAboutBox.Location = new System.Drawing.Point(13, 13);
            this.txtAboutBox.Multiline = true;
            this.txtAboutBox.Name = "txtAboutBox";
            this.txtAboutBox.ReadOnly = true;
            this.txtAboutBox.Size = new System.Drawing.Size(379, 258);
            this.txtAboutBox.TabIndex = 555;
            // 
            // btnCloseHelp
            // 
            this.btnCloseHelp.Location = new System.Drawing.Point(165, 278);
            this.btnCloseHelp.Name = "btnCloseHelp";
            this.btnCloseHelp.Size = new System.Drawing.Size(75, 23);
            this.btnCloseHelp.TabIndex = 1;
            this.btnCloseHelp.Text = "Main Menu";
            this.btnCloseHelp.UseVisualStyleBackColor = true;
            this.btnCloseHelp.Click += new System.EventHandler(this.btnCloseHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseHelp);
            this.Controls.Add(this.txtAboutBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmHelp";
            this.Text = "About the Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAboutBox;
        private System.Windows.Forms.Button btnCloseHelp;
        private System.Windows.Forms.Label label1;
    }
}