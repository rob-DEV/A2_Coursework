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
    public partial class frmAddFoodMenuAttribute : Form
    {

        private int m_SearchTime = 0;
        private int m_SelectedStockItem = -1;

        //used as a callback property so the parent of this form can know what item id was selected
        public Raw_Stock CHOOSEN_ITEM = null;

        private frmAddFoodMenuAttribute()
        {
            InitializeComponent();
        }

        public frmAddFoodMenuAttribute(string menu_attribute)
        {
            InitializeComponent();
            this.CenterToScreen();
            searchLimter.Start();
            lblHeader.Text = string.Format("Edit: {0} Option", menu_attribute);
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
            if (m_SelectedStockItem < 0)
                return;

            CHOOSEN_ITEM = Raw_Stock.RetrieveById(m_SelectedStockItem);
            Console.WriteLine(CHOOSEN_ITEM.Name);
            this.Close();

        }

        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}