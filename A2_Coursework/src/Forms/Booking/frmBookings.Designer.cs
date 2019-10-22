namespace A2_Coursework.Forms
{
    partial class frmBookings
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
            this.dataGridBookings = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.lblBookingNumberOfPeople = new System.Windows.Forms.Label();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.datePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.datePickerPlaced = new System.Windows.Forms.DateTimePicker();
            this.numPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.comboConfirmed = new System.Windows.Forms.ComboBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.comboPaid = new System.Windows.Forms.ComboBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnViewMeals = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnOpenInvoice = new System.Windows.Forms.Button();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBookings
            // 
            this.dataGridBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookings.Location = new System.Drawing.Point(1, 258);
            this.dataGridBookings.Name = "dataGridBookings";
            this.dataGridBookings.Size = new System.Drawing.Size(818, 314);
            this.dataGridBookings.TabIndex = 19;
            this.dataGridBookings.SelectionChanged += new System.EventHandler(this.dataGridBookings_SelectionChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(75, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Bookings";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(113, 66);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 1;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(50, 69);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(60, 13);
            this.lblFname.TabIndex = 11;
            this.lblFname.Text = "First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(50, 95);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(61, 13);
            this.lblLname.TabIndex = 13;
            this.lblLname.Text = "Last Name:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(113, 92);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 20);
            this.txtLname.TabIndex = 2;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(50, 121);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(48, 13);
            this.lblAdd.TabIndex = 15;
            this.lblAdd.Text = "Address:";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(113, 118);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 3;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(113, 144);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(100, 20);
            this.txtAdd2.TabIndex = 4;
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Location = new System.Drawing.Point(50, 147);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(57, 13);
            this.lblAdd2.TabIndex = 15;
            this.lblAdd2.Text = "Address 2:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(113, 170);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(50, 173);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(113, 196);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtPostcode.TabIndex = 6;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(50, 199);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 15;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(274, 66);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(227, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(227, 69);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone:";
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(473, 194);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateBooking.TabIndex = 16;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // lblBookingNumberOfPeople
            // 
            this.lblBookingNumberOfPeople.AutoSize = true;
            this.lblBookingNumberOfPeople.Location = new System.Drawing.Point(470, 69);
            this.lblBookingNumberOfPeople.Name = "lblBookingNumberOfPeople";
            this.lblBookingNumberOfPeople.Size = new System.Drawing.Size(63, 13);
            this.lblBookingNumberOfPeople.TabIndex = 17;
            this.lblBookingNumberOfPeople.Text = "No. People:";
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(470, 121);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(64, 13);
            this.lblDateEvent.TabIndex = 17;
            this.lblDateEvent.Text = "Event Date:";
            // 
            // lblDatePlaced
            // 
            this.lblDatePlaced.AutoSize = true;
            this.lblDatePlaced.Location = new System.Drawing.Point(470, 95);
            this.lblDatePlaced.Name = "lblDatePlaced";
            this.lblDatePlaced.Size = new System.Drawing.Size(43, 13);
            this.lblDatePlaced.TabIndex = 17;
            this.lblDatePlaced.Text = "Placed:";
            // 
            // datePickerEvent
            // 
            this.datePickerEvent.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.datePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerEvent.Location = new System.Drawing.Point(584, 120);
            this.datePickerEvent.Name = "datePickerEvent";
            this.datePickerEvent.ShowUpDown = true;
            this.datePickerEvent.Size = new System.Drawing.Size(185, 20);
            this.datePickerEvent.TabIndex = 13;
            // 
            // datePickerPlaced
            // 
            this.datePickerPlaced.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.datePickerPlaced.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerPlaced.Location = new System.Drawing.Point(584, 92);
            this.datePickerPlaced.Name = "datePickerPlaced";
            this.datePickerPlaced.ShowUpDown = true;
            this.datePickerPlaced.Size = new System.Drawing.Size(185, 20);
            this.datePickerPlaced.TabIndex = 12;
            // 
            // numPeopleUpDown
            // 
            this.numPeopleUpDown.Location = new System.Drawing.Point(660, 67);
            this.numPeopleUpDown.Name = "numPeopleUpDown";
            this.numPeopleUpDown.Size = new System.Drawing.Size(109, 20);
            this.numPeopleUpDown.TabIndex = 11;
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.Location = new System.Drawing.Point(49, 39);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(74, 18);
            this.lblCust.TabIndex = 23;
            this.lblCust.Text = "Customer";
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(470, 39);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(100, 18);
            this.lblBooking.TabIndex = 23;
            this.lblBooking.Text = "Their Booking";
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Location = new System.Drawing.Point(470, 147);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(149, 13);
            this.lblConfirmed.TabIndex = 17;
            this.lblConfirmed.Text = "10% Deposit Paid (Confirmed):";
            // 
            // comboConfirmed
            // 
            this.comboConfirmed.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboConfirmed.AllowDrop = true;
            this.comboConfirmed.FormattingEnabled = true;
            this.comboConfirmed.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboConfirmed.Location = new System.Drawing.Point(660, 144);
            this.comboConfirmed.Name = "comboConfirmed";
            this.comboConfirmed.Size = new System.Drawing.Size(109, 21);
            this.comboConfirmed.TabIndex = 14;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(470, 173);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(31, 13);
            this.lblPaid.TabIndex = 17;
            this.lblPaid.Text = "Paid:";
            // 
            // comboPaid
            // 
            this.comboPaid.DisplayMember = "ff";
            this.comboPaid.Enabled = false;
            this.comboPaid.FormattingEnabled = true;
            this.comboPaid.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboPaid.Location = new System.Drawing.Point(660, 170);
            this.comboPaid.Name = "comboPaid";
            this.comboPaid.Size = new System.Drawing.Size(109, 21);
            this.comboPaid.TabIndex = 15;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(283, 147);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateCustomer.TabIndex = 10;
            this.btnUpdateCustomer.Text = "Save Changes";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(283, 121);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(93, 9);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(94, 23);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "New Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnViewMeals
            // 
            this.btnViewMeals.Location = new System.Drawing.Point(575, 194);
            this.btnViewMeals.Name = "btnViewMeals";
            this.btnViewMeals.Size = new System.Drawing.Size(94, 23);
            this.btnViewMeals.TabIndex = 17;
            this.btnViewMeals.Text = "View Meals";
            this.btnViewMeals.UseVisualStyleBackColor = true;
            this.btnViewMeals.Click += new System.EventHandler(this.btnViewMeals_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(675, 194);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteBooking.TabIndex = 18;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnOpenInvoice
            // 
            this.btnOpenInvoice.Location = new System.Drawing.Point(473, 223);
            this.btnOpenInvoice.Name = "btnOpenInvoice";
            this.btnOpenInvoice.Size = new System.Drawing.Size(142, 23);
            this.btnOpenInvoice.TabIndex = 24;
            this.btnOpenInvoice.Text = "View Invoice";
            this.btnOpenInvoice.UseVisualStyleBackColor = true;
            this.btnOpenInvoice.Click += new System.EventHandler(this.btnOpenInvoice_Click);
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.Location = new System.Drawing.Point(627, 223);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(142, 23);
            this.btnMarkPaid.TabIndex = 25;
            this.btnMarkPaid.Text = "Mark as Paid";
            this.btnMarkPaid.UseVisualStyleBackColor = true;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // frmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 571);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.btnOpenInvoice);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnViewMeals);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.comboPaid);
            this.Controls.Add(this.comboConfirmed);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.numPeopleUpDown);
            this.Controls.Add(this.datePickerPlaced);
            this.Controls.Add(this.datePickerEvent);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblDatePlaced);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(this.lblDateEvent);
            this.Controls.Add(this.lblBookingNumberOfPeople);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAdd2);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.dataGridBookings);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBookings";
            this.Text = "Events Unlimited: Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBookings;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Label lblBookingNumberOfPeople;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.Label lblDatePlaced;
        private System.Windows.Forms.DateTimePicker datePickerEvent;
        private System.Windows.Forms.DateTimePicker datePickerPlaced;
        private System.Windows.Forms.NumericUpDown numPeopleUpDown;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.ComboBox comboConfirmed;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.ComboBox comboPaid;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnViewMeals;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnOpenInvoice;
        private System.Windows.Forms.Button btnMarkPaid;
    }
}