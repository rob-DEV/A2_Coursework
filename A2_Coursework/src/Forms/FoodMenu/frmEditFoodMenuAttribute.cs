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
    public partial class frmEditFoodMenuAttribute : Form
    {

        private int m_SearchTime = 0;
        private int m_SelectedStockItem = -1;
        private int m_MenuId = 0;
        private string m_Attribute = "";

        //used as a callback property so the parent of this form can know what item id was selected
        public int CHOOSEN_ITEM_ID = 0;

        public frmEditFoodMenuAttribute()
        {
            InitializeComponent();
        }

        public frmEditFoodMenuAttribute(int menu_id, string menu_attribute)
        {
            InitializeComponent();
            this.CenterToScreen();
            m_MenuId = menu_id;
            m_Attribute = menu_attribute;
            searchLimter.Start();

            lblHeader.Text = string.Format("Edit: {0} Option", m_Attribute);
            //load the whole stock table initally
            dataGridStock.DataSource = Raw_Stock.RetrieveAll();

        }

        private void searchLimter_Tick(object sender, EventArgs e)
        {
            //regulate how many search queries can be sent each second so not to slow the application
            m_SearchTime++;
        }
        private void txtStockSearch_TextChanged(object sender, EventArgs e)
        {
            //retrieve stock based on a SQL search
            //a timer is used here to ensure SQL queries are limited to 1/sec
            if (m_SearchTime % 1 == 0)
                dataGridStock.DataSource = Raw_Stock.Search(txtStockSearch.Text);
        }
        private void dataGridStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridStock.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    m_SelectedStockItem = Convert.ToInt32(dataGridStock.CurrentRow.Cells[0].Value);
                }
                catch
                {
                    //should never happen
                    Console.WriteLine("ERROR: Cannot convert current row[0] to int32");
                }
            }
        }
        private void btnUpdateMenuAttrib_Click(object sender, EventArgs e)
        {
            //take the selected stock item and assign it to the menu
            //i.e change the foreign key of on of the fields in the menu record
            if (m_SelectedStockItem < 1)
                return;

            if (FoodMenu.UpdateAttribute(m_MenuId, m_Attribute, m_SelectedStockItem))
            {
                MessageBox.Show("Saved Changes Successfully", "SUCCESS", MessageBoxButtons.OK);
                CHOOSEN_ITEM_ID = m_SelectedStockItem;
            }
            else
            {
                MessageBox.Show("Failed to save changes", "ERROR", MessageBoxButtons.OK);
            }

            this.Close();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}