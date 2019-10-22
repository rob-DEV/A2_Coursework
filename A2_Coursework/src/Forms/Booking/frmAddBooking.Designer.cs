namespace A2_Coursework.Forms
{
    partial class frmAddBooking
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
            this.comboPaid = new System.Windows.Forms.ComboBox();
            this.comboConfirmed = new System.Windows.Forms.ComboBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.numPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.datePickerPlaced = new System.Windows.Forms.DateTimePicker();
            this.datePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblBookingNumberOfPeople = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMenuAllocation = new System.Windows.Forms.Label();
            this.comboMenu1 = new System.Windows.Forms.ComboBox();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.numMenu1Count = new System.Windows.Forms.NumericUpDown();
            this.numMenu2Count = new System.Windows.Forms.NumericUpDown();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.comboMenu2 = new System.Windows.Forms.ComboBox();
            this.numMenu3Count = new System.Windows.Forms.NumericUpDown();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.comboMenu3 = new System.Windows.Forms.ComboBox();
            this.numMenu4Count = new System.Windows.Forms.NumericUpDown();
            this.lblMenu4 = new System.Windows.Forms.Label();
            this.comboMenu4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu1Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu2Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu3Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu4Count)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPaid
            // 
            this.comboPaid.DisplayMember = "ff";
            this.comboPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaid.FormattingEnabled = true;
            this.comboPaid.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboPaid.Location = new System.Drawing.Point(81, 144);
            this.comboPaid.Name = "comboPaid";
            this.comboPaid.Size = new System.Drawing.Size(142, 21);
            this.comboPaid.TabIndex = 35;
            // 
            // comboConfirmed
            // 
            this.comboConfirmed.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboConfirmed.AllowDrop = true;
            this.comboConfirmed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConfirmed.FormattingEnabled = true;
            this.comboConfirmed.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboConfirmed.Location = new System.Drawing.Point(81, 118);
            this.comboConfirmed.Name = "comboConfirmed";
            this.comboConfirmed.Size = new System.Drawing.Size(142, 21);
            this.comboConfirmed.TabIndex = 36;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(12, 9);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(96, 20);
            this.lblBooking.TabIndex = 34;
            this.lblBooking.Text = "Add Booking";
            // 
            // numPeopleUpDown
            // 
            this.numPeopleUpDown.Location = new System.Drawing.Point(163, 41);
            this.numPeopleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeopleUpDown.Name = "numPeopleUpDown";
            this.numPeopleUpDown.Size = new System.Drawing.Size(60, 22);
            this.numPeopleUpDown.TabIndex = 33;
            this.numPeopleUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // datePickerPlaced
            // 
            this.datePickerPlaced.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.datePickerPlaced.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerPlaced.Location = new System.Drawing.Point(81, 66);
            this.datePickerPlaced.Name = "datePickerPlaced";
            this.datePickerPlaced.ShowUpDown = true;
            this.datePickerPlaced.Size = new System.Drawing.Size(142, 22);
            this.datePickerPlaced.TabIndex = 31;
            // 
            // datePickerEvent
            // 
            this.datePickerEvent.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.datePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerEvent.Location = new System.Drawing.Point(81, 94);
            this.datePickerEvent.Name = "datePickerEvent";
            this.datePickerEvent.ShowUpDown = true;
            this.datePickerEvent.Size = new System.Drawing.Size(142, 22);
            this.datePickerEvent.TabIndex = 32;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(212, 187);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(94, 23);
            this.btnAddBooking.TabIndex = 30;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // lblDatePlaced
            // 
            this.lblDatePlaced.AutoSize = true;
            this.lblDatePlaced.Location = new System.Drawing.Point(12, 69);
            this.lblDatePlaced.Name = "lblDatePlaced";
            this.lblDatePlaced.Size = new System.Drawing.Size(43, 13);
            this.lblDatePlaced.TabIndex = 25;
            this.lblDatePlaced.Text = "Placed:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(12, 147);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(32, 13);
            this.lblPaid.TabIndex = 26;
            this.lblPaid.Text = "Paid:";
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Location = new System.Drawing.Point(12, 121);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(64, 13);
            this.lblConfirmed.TabIndex = 27;
            this.lblConfirmed.Text = "Confirmed:";
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(12, 95);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(65, 13);
            this.lblDateEvent.TabIndex = 28;
            this.lblDateEvent.Text = "Event Date:";
            // 
            // lblBookingNumberOfPeople
            // 
            this.lblBookingNumberOfPeople.AutoSize = true;
            this.lblBookingNumberOfPeople.Location = new System.Drawing.Point(12, 43);
            this.lblBookingNumberOfPeople.Name = "lblBookingNumberOfPeople";
            this.lblBookingNumberOfPeople.Size = new System.Drawing.Size(66, 13);
            this.lblBookingNumberOfPeople.TabIndex = 29;
            this.lblBookingNumberOfPeople.Text = "No. People:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(312, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Cancel Booking";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMenuAllocation
            // 
            this.lblMenuAllocation.AutoSize = true;
            this.lblMenuAllocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAllocation.Location = new System.Drawing.Point(237, 9);
            this.lblMenuAllocation.Name = "lblMenuAllocation";
            this.lblMenuAllocation.Size = new System.Drawing.Size(261, 20);
            this.lblMenuAllocation.TabIndex = 37;
            this.lblMenuAllocation.Text = "Meal Allocator (4 menus per Booking)";
            // 
            // comboMenu1
            // 
            this.comboMenu1.FormattingEnabled = true;
            this.comboMenu1.Location = new System.Drawing.Point(299, 43);
            this.comboMenu1.Name = "comboMenu1";
            this.comboMenu1.Size = new System.Drawing.Size(258, 21);
            this.comboMenu1.TabIndex = 38;
            // 
            // lblMenu1
            // 
            this.lblMenu1.AutoSize = true;
            this.lblMenu1.Location = new System.Drawing.Point(240, 47);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(49, 13);
            this.lblMenu1.TabIndex = 39;
            this.lblMenu1.Text = "Menu 1:";
            // 
            // numMenu1Count
            // 
            this.numMenu1Count.Location = new System.Drawing.Point(563, 43);
            this.numMenu1Count.Name = "numMenu1Count";
            this.numMenu1Count.Size = new System.Drawing.Size(43, 22);
            this.numMenu1Count.TabIndex = 40;
            // 
            // numMenu2Count
            // 
            this.numMenu2Count.Location = new System.Drawing.Point(563, 70);
            this.numMenu2Count.Name = "numMenu2Count";
            this.numMenu2Count.Size = new System.Drawing.Size(43, 22);
            this.numMenu2Count.TabIndex = 43;
            // 
            // lblMenu2
            // 
            this.lblMenu2.AutoSize = true;
            this.lblMenu2.Location = new System.Drawing.Point(240, 74);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(49, 13);
            this.lblMenu2.TabIndex = 42;
            this.lblMenu2.Text = "Menu 2:";
            // 
            // comboMenu2
            // 
            this.comboMenu2.FormattingEnabled = true;
            this.comboMenu2.Location = new System.Drawing.Point(299, 70);
            this.comboMenu2.Name = "comboMenu2";
            this.comboMenu2.Size = new System.Drawing.Size(258, 21);
            this.comboMenu2.TabIndex = 41;
            // 
            // numMenu3Count
            // 
            this.numMenu3Count.Location = new System.Drawing.Point(563, 97);
            this.numMenu3Count.Name = "numMenu3Count";
            this.numMenu3Count.Size = new System.Drawing.Size(43, 22);
            this.numMenu3Count.TabIndex = 46;
            // 
            // lblMenu3
            // 
            this.lblMenu3.AutoSize = true;
            this.lblMenu3.Location = new System.Drawing.Point(240, 101);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Size = new System.Drawing.Size(49, 13);
            this.lblMenu3.TabIndex = 45;
            this.lblMenu3.Text = "Menu 3:";
            // 
            // comboMenu3
            // 
            this.comboMenu3.FormattingEnabled = true;
            this.comboMenu3.Location = new System.Drawing.Point(299, 97);
            this.comboMenu3.Name = "comboMenu3";
            this.comboMenu3.Size = new System.Drawing.Size(258, 21);
            this.comboMenu3.TabIndex = 44;
            // 
            // numMenu4Count
            // 
            this.numMenu4Count.Location = new System.Drawing.Point(563, 124);
            this.numMenu4Count.Name = "numMenu4Count";
            this.numMenu4Count.Size = new System.Drawing.Size(43, 22);
            this.numMenu4Count.TabIndex = 49;
            // 
            // lblMenu4
            // 
            this.lblMenu4.AutoSize = true;
            this.lblMenu4.Location = new System.Drawing.Point(240, 128);
            this.lblMenu4.Name = "lblMenu4";
            this.lblMenu4.Size = new System.Drawing.Size(49, 13);
            this.lblMenu4.TabIndex = 48;
            this.lblMenu4.Text = "Menu 4:";
            // 
            // comboMenu4
            // 
            this.comboMenu4.FormattingEnabled = true;
            this.comboMenu4.Location = new System.Drawing.Point(299, 124);
            this.comboMenu4.Name = "comboMenu4";
            this.comboMenu4.Size = new System.Drawing.Size(258, 21);
            this.comboMenu4.TabIndex = 47;
            // 
            // frmAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 221);
            this.Controls.Add(this.numMenu4Count);
            this.Controls.Add(this.lblMenu4);
            this.Controls.Add(this.comboMenu4);
            this.Controls.Add(this.numMenu3Count);
            this.Controls.Add(this.lblMenu3);
            this.Controls.Add(this.comboMenu3);
            this.Controls.Add(this.numMenu2Count);
            this.Controls.Add(this.lblMenu2);
            this.Controls.Add(this.comboMenu2);
            this.Controls.Add(this.numMenu1Count);
            this.Controls.Add(this.lblMenu1);
            this.Controls.Add(this.comboMenu1);
            this.Controls.Add(this.lblMenuAllocation);
            this.Controls.Add(this.comboPaid);
            this.Controls.Add(this.comboConfirmed);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.numPeopleUpDown);
            this.Controls.Add(this.datePickerPlaced);
            this.Controls.Add(this.datePickerEvent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.lblDatePlaced);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(this.lblDateEvent);
            this.Controls.Add(this.lblBookingNumberOfPeople);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmAddBooking";
            this.Text = "Add Booking";
            this.Load += new System.EventHandler(this.frmAddBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu1Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu2Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu3Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenu4Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPaid;
        private System.Windows.Forms.ComboBox comboConfirmed;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.NumericUpDown numPeopleUpDown;
        private System.Windows.Forms.DateTimePicker datePickerPlaced;
        private System.Windows.Forms.DateTimePicker datePickerEvent;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label lblDatePlaced;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.Label lblBookingNumberOfPeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMenuAllocation;
        private System.Windows.Forms.ComboBox comboMenu1;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.NumericUpDown numMenu1Count;
        private System.Windows.Forms.NumericUpDown numMenu2Count;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.ComboBox comboMenu2;
        private System.Windows.Forms.NumericUpDown numMenu3Count;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.ComboBox comboMenu3;
        private System.Windows.Forms.NumericUpDown numMenu4Count;
        private System.Windows.Forms.Label lblMenu4;
        private System.Windows.Forms.ComboBox comboMenu4;
    }
}