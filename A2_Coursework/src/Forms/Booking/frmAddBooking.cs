using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmAddBooking : Form
    {
        private int customerId = -1;
        public frmAddBooking(int customer_id)
        {
            InitializeComponent();
            this.CenterToScreen();
            customerId = customer_id;

        }

        private void frmAddBooking_Load(object sender, EventArgs e)
        {
            //populate comboboxes with the menu objects
            List<FoodMenu> menus = FoodMenu.RetrieveAll();
            //default no menu choosen
            comboMenu1.Items.Add("None");
            comboMenu2.Items.Add("None");
            comboMenu3.Items.Add("None");
            comboMenu4.Items.Add("None");
            comboMenu1.SelectedItem = comboMenu1.Items[0];
            comboMenu2.SelectedItem = comboMenu2.Items[0];
            comboMenu3.SelectedItem = comboMenu3.Items[0];
            comboMenu4.SelectedItem = comboMenu4.Items[0];

            foreach (FoodMenu menu in menus)
            {
                comboMenu1.Items.Add(menu);
                comboMenu2.Items.Add(menu);
                comboMenu3.Items.Add(menu);
                comboMenu4.Items.Add(menu);
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (numMenu1Count.Value + numMenu2Count.Value + numMenu3Count.Value + numMenu4Count.Value > numPeopleUpDown.Value)
            {
                MessageBox.Show("You cannot specify more menus than there are number of people!", "Error:", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //take the customer and their details and add to the database
                Customer customer = Customer.RetrieveById(customerId);
                Booking inserted_Booking = Booking.Add(new Booking((int)numPeopleUpDown.Value, datePickerPlaced.Value, datePickerEvent.Value,
                    bool.Parse(comboConfirmed.SelectedItem.ToString()),
                    bool.Parse(comboPaid.SelectedItem.ToString()),
                    customerId,
                    ApplicationManagement.ApplicationManager.LoggedInEmployee));

                //add the choosen menus and quantities to the meals table
                if(inserted_Booking != null)
                {
                    try{
                        //the is a max of 4 menus options for each booking

                        if(comboMenu1.Text != "None")
                        {
                            FoodMenu menu1 = (FoodMenu)comboMenu1.SelectedItem;
                            int quantity = (int)numMenu1Count.Value;

                            Meal.Add(new Meal(inserted_Booking, menu1, quantity));
                        }
                        if(comboMenu2.Text != "None")
                        {
                            FoodMenu menu2 = (FoodMenu)comboMenu2.SelectedItem;
                            int quantity = (int)numMenu2Count.Value;

                            Meal.Add(new Meal(inserted_Booking, menu2, quantity));
                        }
                        if(comboMenu3.Text != "None")
                        {
                            FoodMenu menu3 = (FoodMenu)comboMenu3.SelectedItem;
                            int quantity = (int)numMenu3Count.Value;

                            Meal.Add(new Meal(inserted_Booking, menu3, quantity));
                        }
                        if (comboMenu4.Text != "None")
                        {
                            FoodMenu menu4 = (FoodMenu)comboMenu4.SelectedItem;
                            int quantity = (int)numMenu4Count.Value;

                            Meal.Add(new Meal(inserted_Booking, menu4, quantity));
                        }
                        MessageBox.Show("Booking & Food Menu(s) Successfully Added!");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
                MessageBox.Show("Failed to add booking Check Your Input!");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
