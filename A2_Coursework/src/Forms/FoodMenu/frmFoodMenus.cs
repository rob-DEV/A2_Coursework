using System;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmFoodMenus : Form
    {
        //menu attribute cache
        private Raw_Stock Meat;
        private Raw_Stock Veg1;
        private Raw_Stock Veg2;
        private Raw_Stock Drink;

        public void LoadFoodMenus()
        {
            dataGridFoodMenus.DataSource = FoodMenu.RetrieveAll();
        }
        public frmFoodMenus()
        {
            InitializeComponent();
            this.CenterToScreen();
            //load created menus
            LoadFoodMenus();

        }
        private void dataGridFoodMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridFoodMenus.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    int selectedMenuId = Convert.ToInt32(dataGridFoodMenus.CurrentRow.Cells[0].Value);

                    FoodMenu selectedMenu = FoodMenu.RetrieveById(selectedMenuId);

                    txtMenuId.Text = selectedMenu.ID.ToString();
                    txtMenuMeat.Text = selectedMenu.Meat;
                    txtMenuVeg1.Text = selectedMenu.Vegetable_1;
                    txtMenuVeg2.Text = selectedMenu.Vegetable_2;
                    txtMenuDrink.Text = selectedMenu.Drink;
                    txtMenuPrice.Text = selectedMenu.Price.ToString();


                }
                catch
                {
                    //should never happen
                    Console.WriteLine("ERROR: Cannot convert current row[0] to int32");
                }
            }

        }
        //Update Menu
        private void editFoodMenuItem(object sender, EventArgs e)
        {

            try
            {

                //gather required data to edit the menu items,
                //this is tedious as there is a foreign key relationship
                TextBox selectedMenuAttribute = sender as TextBox;

                int menuId = Convert.ToInt32(txtMenuId.Text);
                string attributeTag = selectedMenuAttribute.Tag.ToString();

                frmEditFoodMenuAttribute menuEditForm = new frmEditFoodMenuAttribute(menuId, attributeTag);
                menuEditForm.ShowDialog();
                
                //update UI
                LoadFoodMenus();


            }
            catch(Exception ex)
            {

                Console.WriteLine("ERROR: {0}", ex.Message);

            }
            
        }
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {

            string validInputRegex = @"^\£?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$";
            Match match = Regex.Match(txtMenuPrice.Text, validInputRegex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                MessageBox.Show("Incorrect price format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            FoodMenu.UpdateAttribute(Convert.ToInt32(txtMenuId.Text), Convert.ToDecimal(txtMenuPrice.Text));
            LoadFoodMenus();
        
        }

        //Add New Menu
        private void pickFoodMenuItem(object sender, EventArgs e)
        {

            try
            {
                TextBox selectedMenuAttribute = sender as TextBox;

                string attributeTag = selectedMenuAttribute.Tag.ToString();

                frmAddFoodMenuAttribute frmSelectMenuAttrib = new frmAddFoodMenuAttribute(attributeTag);

                frmSelectMenuAttrib.ShowDialog();

                //selected item picked in the attribute selector form
                Raw_Stock selectedItem = frmSelectMenuAttrib.CHOOSEN_ITEM;
                if (selectedItem != null)
                {
                    switch (selectedItem.Category)
                    {
                        case "MEAT":
                            Meat = selectedItem;
                            txtNMenuMeat.Text = selectedItem.Name;
                            break;
                        case "VEG":
                            if (Veg1 == null)
                            {
                                Veg1 = selectedItem;
                                txtNMenuVeg1.Text = selectedItem.Name;
                            }
                            else
                            {
                                Veg2 = selectedItem;
                                txtNMenuVeg2.Text = selectedItem.Name;
                            }
                            break;
                        case "DRINK":
                            Drink = selectedItem;
                            txtNMenuDrink.Text = selectedItem.Name;
                            break;
                        default:
                            MessageBox.Show("An unexpected error has occured! Check you picked an item in a suitable category.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    //calculate cost price based on current menu items
                    if (Meat != null && Veg1 != null && Veg2 != null && Drink != null)
                        txtCostPrice.Text = string.Format("{0}", (Meat.Price + Veg1.Price + Veg2.Price + Drink.Price));

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR: {0}", ex.Message);

            }

        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {

            string validInputRegex = @"^\£?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$";
            Match match = Regex.Match(txtNMenuPrice.Text, validInputRegex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                MessageBox.Show("Incorrect price format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Meat != null & Veg1 != null && Veg2 != null && Drink != null)
            {
                if (FoodMenu.Add(Meat, Veg1, Veg2, Drink, Convert.ToDecimal(txtNMenuPrice.Text)))
                {
                    MessageBox.Show("Menu Added!", "SUCCESS", MessageBoxButtons.OK);
                    LoadFoodMenus();
                }
                else
                {
                    MessageBox.Show("Failed to add Menu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select one of each item!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
