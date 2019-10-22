using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmViewBookingMeals : Form
    {
        private Booking m_SelectedBooking;
        public frmViewBookingMeals(int selectedBookingID)
        {
            InitializeComponent();
            this.CenterToScreen();
            m_SelectedBooking = Booking.RetrieveById(selectedBookingID);
        }
        private void frmViewBookingMeals_Load(object sender, EventArgs e)
        {
            if (m_SelectedBooking == null)
                this.Close();
            //setup the menu selection ui

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
            comboMenu1.Tag = "None";
            comboMenu2.Tag = "None";
            comboMenu3.Tag = "None";
            comboMenu4.Tag = "None";

            //add the set menus into the dropdowns for user selection
            foreach (FoodMenu menu in menus)
            {
                comboMenu1.Items.Add(menu);
                comboMenu2.Items.Add(menu);
                comboMenu3.Items.Add(menu);
                comboMenu4.Items.Add(menu);
            }


            lblHeader.Text = string.Format("Meals for {0} {1}'s booking (Booking ID: {2})", m_SelectedBooking.Customer.Firstname, m_SelectedBooking.Customer.Lastname, m_SelectedBooking.ID);

            //a max of 4 meals should be returned 
            List<Meal> selectedBookingMeals = Meal.RetrieveAll(m_SelectedBooking);
            if (selectedBookingMeals != null && selectedBookingMeals.Count < 1)
                //no meals are found -> just leave the ui as is and allow the user to add meals
                return;
            
            //setup menu ui to match the selected items
            Meal menu1 = selectedBookingMeals[0];
            for (int i = 1; i < menus.Count + 1; i++)
            {
                if(((FoodMenu)comboMenu1.Items[i]).ID == menu1.Menu.ID)
                {
                    comboMenu1.SelectedItem = comboMenu1.Items[i];
                    numMenu1Count.Value = menu1.Quantity;
                    //this demarks the box to allow adding of menus
                    comboMenu1.Tag = "";
                    break;
                }
            }
            if (selectedBookingMeals.Count < 2)
                return;
            Meal menu2 = selectedBookingMeals[1];
            for (int i = 1; i < menus.Count + 1; i++)
            {
                if (((FoodMenu)comboMenu2.Items[i]).ID == menu2.Menu.ID)
                {
                    comboMenu2.SelectedItem = comboMenu2.Items[i];
                    numMenu2Count.Value = menu2.Quantity;
                    //this demarks the box to allow adding of menus
                    comboMenu2.Tag = "";
                    break;
                }
            }
            if (selectedBookingMeals.Count < 3)
                return;
            Meal menu3 = selectedBookingMeals[2];
            for (int i = 1; i < menus.Count + 1; i++)
            {
                if (((FoodMenu)comboMenu3.Items[i]).ID == menu3.Menu.ID)
                {
                    comboMenu3.SelectedItem = comboMenu3.Items[i];
                    numMenu3Count.Value = menu3.Quantity;
                    //this demarks the box to allow adding of menus
                    comboMenu3.Tag = "";
                    break;
                }
            }
            if (selectedBookingMeals.Count < 4)
                return;
            Meal menu4 = selectedBookingMeals[3];
            for (int i = 1; i < menus.Count + 1; i++)
            {
                if (((FoodMenu)comboMenu4.Items[i]).ID == menu4.Menu.ID)
                {
                    comboMenu4.SelectedItem = comboMenu4.Items[i];
                    numMenu4Count.Value = menu4.Quantity;
                    //this demarks the box to allow adding of menus
                    comboMenu4.Tag = "";
                    break;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pushErrorMessage(string message = null)
        {
            if(message.Length > 0)
                MessageBox.Show(message, "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Error Submitting Menu Update", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //the is a max of 4 menus options for each booking

                if (comboMenu1.Text != "None")
                {
                    FoodMenu menu1 = (FoodMenu)comboMenu1.SelectedItem;
                    int quantity = (int)numMenu1Count.Value;

                    if ((string)comboMenu1.Tag == "None")
                    {
                        if (!Meal.Add(new Meal(m_SelectedBooking, menu1, quantity)))
                        {
                            pushErrorMessage("Error adding a new menu.");
                            return;
                        }
                        comboMenu1.Tag = "";
                        goto MENU_2;
                    }

                    if (!Meal.Update(new Meal(m_SelectedBooking, ((FoodMenu)comboMenu1.SelectedItem), 0), menu1.ID, quantity))
                    {
                        pushErrorMessage(string.Format("Error submitting menu \"{0}.\" Check you aren't passing two of the same menus!", menu1.ToString()));
                        return;
                    }
                }
                MENU_2:
                if (comboMenu2.Text != "None")
                {
                    FoodMenu menu2 = (FoodMenu)comboMenu2.SelectedItem;
                    int quantity = (int)numMenu2Count.Value;

                    if((string)comboMenu2.Tag == "None")
                    {
                        if(!Meal.Add(new Meal(m_SelectedBooking, menu2, quantity)))
                        {
                            pushErrorMessage("Error adding a new menu.");
                            return;
                        }
                        comboMenu2.Tag = "";
                        goto MENU_3;
                    }

                    if (!Meal.Update(new Meal(m_SelectedBooking, ((FoodMenu)comboMenu2.SelectedItem), 0), menu2.ID, quantity))
                    {
                        pushErrorMessage(string.Format("Error submitting menu \"{0}.\" Check you aren't passing two of the same menus!", menu2.ToString()));
                        return;
                    }
                }
                MENU_3:
                if (comboMenu3.Text != "None")
                {
                    FoodMenu menu3 = (FoodMenu)comboMenu3.SelectedItem;
                    int quantity = (int)numMenu3Count.Value;

                    if ((string)comboMenu3.Tag == "None")
                    {
                        if (!Meal.Add(new Meal(m_SelectedBooking, menu3, quantity)))
                        {
                            pushErrorMessage("Error adding a new menu.");
                            return;
                        }
                        comboMenu3.Tag = "";
                        goto MENU_4;
                    }

                    if (!Meal.Update(new Meal(m_SelectedBooking, ((FoodMenu)comboMenu3.SelectedItem), 0), menu3.ID, quantity))
                    {
                        pushErrorMessage(string.Format("Error submitting menu \"{0}.\" Check you aren't passing two of the same menus!", menu3.ToString()));
                        return;
                    }
                }
                MENU_4:
                if (comboMenu4.Text != "None")
                {
                    FoodMenu menu4 = (FoodMenu)comboMenu4.SelectedItem;
                    int quantity = (int)numMenu4Count.Value;

                    if ((string)comboMenu4.Tag == "None")
                    {
                        if (!Meal.Add(new Meal(m_SelectedBooking, menu4, quantity)))
                        {
                            pushErrorMessage("Error adding a new menu.");
                            return;
                        }

                        comboMenu4.Tag = "";
                        goto MENU_ADD_UPDATE_END;
                    }

                    if (!Meal.Update(new Meal(m_SelectedBooking, ((FoodMenu)comboMenu4.SelectedItem), 0), menu4.ID, quantity))
                    {
                        pushErrorMessage(string.Format("Error submitting menu \"{0}.\" Check you aren't passing two of the same menus!", menu4.ToString()));
                        return;
                    }
                }
                MENU_ADD_UPDATE_END:
                MessageBox.Show("Menus Added / Updated Successfully!");
                this.Close();
            }
            catch(Exception ex)
            {
                //debugging menu addition
                var st = new StackTrace(ex, true);
                var frame = st.GetFrame(0);
                var line = frame.GetFileLineNumber();
                //debugging end
                Console.WriteLine("ERROR : {0} {1}", ex.Message, line);
            }
        }
    }
}